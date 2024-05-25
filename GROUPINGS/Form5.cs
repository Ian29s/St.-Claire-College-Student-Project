using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROUPINGS
{
    public partial class Form5 : Form
    {
        //Database Connection
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\My files\small projects\St. Claire college project\gradingsheet.mdb");
        public Form5()
        {
            InitializeComponent();
        }

        //Insert Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fullnametbox.Text))
            {
                MessageBox.Show("Please put Full Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fullnametbox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(usernametbox.Text))
            {
                MessageBox.Show("Please put username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernametbox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(passtbox.Text))
            {
                MessageBox.Show("Please put password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passtbox.Focus();
                return;
            }
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert Into sign_up (full_name,u_name,p_word)values('" + fullnametbox.Text + "','" + usernametbox.Text + "','" + passtbox.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Welcome, new admin");
            TxtClear();
        }
        void TxtClear() // clear text box after save data
        {
            usernametbox.Text = "";
            passtbox.Text = "";
            fullnametbox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form5 = new Form1();
            this.Hide();
            form5.Show();
        }

        //FORM DRAG
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
