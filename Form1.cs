using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postcard4Darling
{
    public partial class Heart : Form
    {
        Point movementPoint;

        public Heart()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Heart_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                movementPoint = new Point(e.X, e.Y);
            }
        }

        private void Heart_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point currentPosition = new Point(e.X - movementPoint.X, e.Y - movementPoint.Y);
                this.Location = new Point(this.Location.X + currentPosition.X, this.Location.Y + currentPosition.Y);
            }
        }

        private void Heart_Load(object sender, EventArgs e) // function = 2-2*sin(t)+sin(t)*sqrt(abs(cos(t)))/(sin(t)+1.5)
        {
            System.Drawing.Drawing2D.GraphicsPath Path = new System.Drawing.Drawing2D.GraphicsPath();
            Path.(0, 0, 400, 400, 0, 180);
            //Path.AddArc(45, 10, 50, 50, 225, 180);
            /*Path.AddEllipse(17, 52, 54, 89);
            Path.AddEllipse(88, 52, 51, 89);*/
            //Path.AddArc(0, 0, 150, 120, 30, 120);
            //Path.AddEllipse(50, 50, 50, 100);
            //Path.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(Path);
            this.Region = myRegion;
        } // https://docs.microsoft.com/ru-ru/dotnet/api/system.drawing.drawing2d.graphicspath.addbeziers?view=net-5.0#System_Drawing_Drawing2D_GraphicsPath_AddBeziers_System_Drawing_Point___
    }
}
