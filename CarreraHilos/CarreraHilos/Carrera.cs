using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraHilos
{
    public partial class Carrera : Form
    {
        delegate void delegado(PictureBox pb, int laY, int vel);


        public Carrera()
        {
            InitializeComponent();
        }

        int avanzaLiebre = 0;
        int descansoLiebre = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ésta línea permite ejecutar varios hilos. Configuración del IDE
            CheckForIllegalCrossThreadCalls = false;
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Aquí se pintarán las líneas necesarias
            Pen lapiz = new Pen(Color.Blue, 1); //color y grosor
            Graphics pintor = CreateGraphics();

            //línea 1, 2
            pintor.DrawLine(lapiz, new Point(20, 100), new Point(400, 100)); //al 50 se le suman 25 de la posición por eso ahora quedó en 75
            pintor.DrawLine(lapiz, new Point(20, 230), new Point(400, 230));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            descansoLiebre = random.Next(50,200);
            botonIniciar.Enabled = false;
            avanzaLiebre = 0;
            lblLiebre.Visible = false;
            Animal liebre = new Liebre(fotouno, fotouno.Location.Y, descansoLiebre);
            liebre.mover += mover;
            Animal tortuga = new Tortuga(fototres, fototres.Location.Y);
            tortuga.mover += mover;
            liebre.iniciarCarrera();
            tortuga.iniciarCarrera();
            //Thread[] hilos = new Thread[2];

            //for(int i = 0; i < hilos.Length; i++)
            //{
            //    hilos[i] = new Thread(metodo);
            //    hilos[i].Name = "h" + i;
            //    hilos[i].Start();
            //}

            botonIniciar.Enabled = true;
        }///

        //public void metodo()
        //{
        //    //foto uno es más rápida, foto tres es más lenta
        //    delegado elDelegado = new delegado(mover);
        //    if (Thread.CurrentThread.Name.Equals("h0")){
        //        elDelegado.Invoke(fotouno, fotouno.Location.Y, 20);

        //    } else if (Thread.CurrentThread.Name.Equals("h1")){
        //        elDelegado.Invoke(fototres, fototres.Location.Y, 40);

        //    }
        //}
        
        public void mover(PictureBox pb,int laY,int velocidad,Boolean isLiebre)
        {
            for (int i = 0; i < 350; i++)
            {
                try
                {
                    pb.Location = new Point(i, laY);
                    Thread.Sleep(velocidad);
                    //if para control de velocidad
                    if (isLiebre)
                    {
                        avanzaLiebre++;
                        if (avanzaLiebre >= descansoLiebre)
                        {
                            Thread.CurrentThread.Abort();
                        }
                    }
                }
                catch (ThreadAbortException)
                {
                    if (lblLiebre != null)
                    {
                        lblLiebre.Invoke(new MethodInvoker(() => lblLiebre.ForeColor=Color.DarkRed));
                        lblLiebre.Invoke(new MethodInvoker(() => lblLiebre.Text = "La liebre se ha quedado dormida!!"));
                        lblLiebre.Invoke(new MethodInvoker(() => lblLiebre.Visible = true));
                    }
                    //MessageBox.Show("La liebre se ha quedado dormida!!");
                }
            }

            if(!isLiebre)
            {
                lblLiebre.Invoke(new MethodInvoker(() => lblLiebre.ForeColor = Color.DarkGreen));

                lblLiebre.Invoke(new MethodInvoker(() => lblLiebre.Text = "La tortuga ganó!!"));
                lblLiebre.Invoke(new MethodInvoker(() => lblLiebre.Visible = true));
            }
        }



    }
}
