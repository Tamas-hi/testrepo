using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphicsteszt {
    public partial class Form1 : Form { 

        Timer t = new Timer();
        public Form1() {
            InitializeComponent();
            t.Tick += t_tick; // esemény+=függvénynév
            t.Start();
            
        }
        
        public void t_tick(object sender, EventArgs e) {
            //Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e) {
            e.Graphics.DrawLine(new Pen(Color.Blue, 20), 75, 25, 200, 88); // sima vonal

            // 20 = a vonal szélessége amivel rajzoljuk
            // 100 = x1 koordináta
            // 25 = y1 koordináta
            // 200 = x2 koordináta
            // 88 = y2 koordináta

            e.Graphics.DrawRectangle(new Pen(Color.Blue, 30), 80,90,100,300); // sima téglalap

            // 30 = a vonal szélessége amivel rajzoljuk
            // 80 = a bal felső pont x koordinátája
            // 90 = a bal felső pont y koordinátája
            // 100 = a téglalap szélessége
            // 300 = a téglalap magassága

            e.Graphics.FillRectangle(Brushes.Aqua,10, 30, 200, 25); // telített téglalap
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(127, 255, 0, 0)), 10, 10, 20, 20);

            // 10 = a bal felső pont x koordinátája
            // 30 = a bal felső pont y koordinátája
            // 200 = a téglalap szélessége
            // 25 = a téglalap magassága


            //e.Graphics.FillRectangle(new HatchBrush(HatchStyle.Cross,Color.Blue), 500, 60, 200, 250); // négyzetrács

            // 500 = a bal felső pont x koordinátája
            // 65 = a bal felső pont y koordinátája
            // 200 = a téglalap szélessége
            // 250 = a téglalap magassága

            e.Graphics.DrawString("Hello World", Font, Brushes.White, 10, 12);

            // "Hello World" - a kiírandó szöveg
            // Font = betűtípus
            // Brushes.White - fehér színű szöveg
            // 10 = x koordináta
            // 12 = y koordináta

        }
    }
}
