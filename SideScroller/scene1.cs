using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScroller
{
    class scene1
    {
        Image MrPants = Resource.mr_pants;
        public void Draw(Graphics g)
        {
            SolidBrush myBrush = new SolidBrush(Color.Red);
            //g.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));
            g.DrawImage(MrPants, 10, 10);
        }
    }
}
