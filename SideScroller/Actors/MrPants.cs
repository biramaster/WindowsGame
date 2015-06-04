using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScroller.Actors
{
    class MrPants
    {
        Image mrpants = Resource.mr_pants;

        public Image Mrpants
        {
            get { return mrpants; }
            set { mrpants = value; }
        }
        float posX, posY;

        public float PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public float PosX
        {
            get { return posX; }
            set { posX = value; }
        }


        public void Draw(Graphics g)
        {
            SolidBrush myBrush = new SolidBrush(Color.Red);
            g.DrawImage(mrpants, posX, posY);
        }

    }
}
