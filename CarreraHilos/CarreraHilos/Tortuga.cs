using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraHilos
{
    public class Tortuga: Animal
    {
        public Tortuga(PictureBox pb, int laY) : base(pb, laY, 40, 0, false)
        {
        }
    }
}
