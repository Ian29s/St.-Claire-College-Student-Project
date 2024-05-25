using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUPINGS
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }



        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form2 = new Form4();
            this.Hide();
            form2.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var form2 = new Form4();
            this.Hide();
            form2.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form2 = new Form3();
            this.Hide();
            form2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var form2 = new Form3();
            this.Hide();
            form2.Show();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form2 = new Form3();
            this.Hide();
            form2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
            timer1.Start();
            if (Form1.txtusername1 != null)
            {
                user_name.Text = Form1.txtusername1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datenow_1.Text = DateTime.Now.ToLongDateString();
            time_now1.Text = DateTime.Now.ToLongTimeString();
        }

        private void Datenow_1_Click(object sender, EventArgs e)
        {

        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You sure?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                var form2 = new Form1();
                this.Hide();
                form2.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                var form2 = new Form2();
                this.Hide();
                form2.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            dragging = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
    }

}
