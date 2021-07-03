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

        private void Heart_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath Path = new System.Drawing.Drawing2D.GraphicsPath();
            Path.AddArc(25, 25, 125, 125, 135, 180);
            Path.AddArc(113, 25, 125, 125, 225, 180);
            Path.AddLine(220, 130, 128, 223);
            Region myRegion = new Region(Path);
            this.Region = myRegion;
        } 
    }
}
