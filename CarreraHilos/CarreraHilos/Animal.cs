using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraHilos
{
    public delegate void Mover(PictureBox pb, int laY, int velocidad, Boolean isLiebre);
    public class Animal
    {
        public event Mover mover;
        PictureBox pb = new PictureBox();
        int laY = 0;
        int velocidad = 0;
        int avanzaLiebre = 0;
        int descansoLiebre = 0;
        Boolean isLiebre = false;
       public Label lblMensaje = new Label();

        public Animal(PictureBox pb, int laY, int vel, int descansoLie, Boolean isLieb)
        {
            this.pb = pb;
            this.laY = laY;
            this.velocidad = vel;
            this.descansoLiebre = descansoLie;
            this.isLiebre = isLieb;
            this.avanzaLiebre = 0;

        }
        public void iniciarCarrera()
        {
            Thread thread = new Thread(()=>mover(pb,laY,velocidad,isLiebre));
            thread.Start();
        }

    }
}
