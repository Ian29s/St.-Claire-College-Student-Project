using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GROUPINGS
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\My files\small projects\St. Claire college project\gradingsheet.mdb");
        public static string txtusername1 = "";
        public static string password1 = "";
        public static string codename = " Admin ";

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Please put username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Please put password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpassword.Focus();
                return;
            }
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT COUNT(*) FROM sign_up WHERE u_name='" + txtusername.Text + "' AND p_word='" + txtpassword.Text + "'", con);
                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                DataTable dt = new DataTable(); //this is creating a virtual table  
                adapter.Fill(dt);
                string username = txtusername.Text;
                string password = txtpassword.Text;

                if (dt.Rows[0][0].ToString() == "1")
                {
                    /* If the user is successfully authenticated then the form will be moved to the next form */
                    this.Hide();
                    MessageBox.Show("Welcome," + codename, "Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtusername1 = txtusername.Text;
                    new Form2().Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtusername.Text = "";
                    txtpassword.Text = "";
                }

            }
        }       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form1 = new Form5();
            this.Hide();
            form1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_2(object sender, EventArgs e)
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
