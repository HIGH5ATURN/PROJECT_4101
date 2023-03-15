using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUTSMS_MAIN_
{
    public partial class Student_Form : Form
    {
        public Student_Form()
        {
            InitializeComponent();
        }

        private void Student_Form_Load(object sender, EventArgs e)
        {

        }
    

        private void student_user_control1_MouseDown(object sender, MouseEventArgs e)
        {

        }
        //to move the form
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void Student_Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Student_Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Student_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {

                Point p = PointToScreen(e.Location);

                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }
    }
}
