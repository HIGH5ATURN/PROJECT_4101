using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace IUTSMS_MAIN_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //to move form_1 using mouse this code is necessary
        private bool dragging =false;
        private Point startPoint = new Point(0,0);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging= true;
            startPoint= new Point(e.X,e.Y);

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging= false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {

                Point p = PointToScreen(e.Location);

                Location = new Point(p.X-this.startPoint.X,p.Y-this.startPoint.Y);

            }
        }
        //to move form_1 using mouse this code is necessary

        //shifting to admin form
        Thread th; 
        public void openform_admin(object obj)
        {
            Application.Run(new Admin_Form());
        }
        private void SORA_Admin_button_Click(object sender, EventArgs e)
        {
            th = new Thread(openform_admin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }


        public void openform_student(object obj)
        {
            Application.Run(new Student_Form());
        }
        private void SORA_Student_button_Click(object sender, EventArgs e)
        {
            th = new Thread(openform_student);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
    }
}
