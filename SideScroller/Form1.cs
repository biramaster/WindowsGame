using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideScroller
{
    public partial class Form1 : Form
    {
        scene1 sc1;

        public Form1()
        {
            InitializeComponent();
            Application.Idle += HandleApplicationIdle;
            sc1 = new scene1();
        }

        [DllImport("user32.dll")]
        public static extern int PeekMessage(out NativeMessage message, IntPtr window, uint filterMin, uint filterMax, uint remove);

        private void HandleApplicationIdle(object sender, EventArgs e)
        {
            while (IsApplicationIdle())
            {
                Update();
                Render();
            } 
        }

        private void Render()
        {
            sc1.Draw(this.CreateGraphics());
        }

        private void Update()
        {
          
        }

        private bool IsApplicationIdle()
        {
            NativeMessage result;
            return PeekMessage(out result, IntPtr.Zero, (uint)0, (uint)0, (uint)0) == 0;
        }
    }
}
