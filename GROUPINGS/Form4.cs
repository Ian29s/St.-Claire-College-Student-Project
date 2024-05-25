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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GROUPINGS
{
    public partial class Form4 : Form
    {
        //Database Connection
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\iamce\source\repos\GROUPINGS\gradingsheet.mdb");
        
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Insert Button
        private void Register_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(fullnametextbox.Text)){
                MessageBox.Show("Please put Full Name.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                fullnametextbox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(gendercombobox.Text))
            {
                MessageBox.Show("Please select Gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gendercombobox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(comboxcourse.Text))
            {
                MessageBox.Show("Please select Course", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboxcourse.Focus();
                return;
            }
            if (string.IsNullOrEmpty(comboxyrlevel.Text))
            {
                MessageBox.Show("Please select yearlevel", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboxyrlevel.Focus();
                return;
            }
            if (string.IsNullOrEmpty(comboxsem.Text))
            {
                MessageBox.Show("Please select semester", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboxsem.Focus();
                return;
            }
            if (string.IsNullOrEmpty(comboxschoolyr.Text))
            {
                MessageBox.Show("Please select schoolyear", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboxschoolyr.Focus();
                return;
            }
            if (string.IsNullOrEmpty(comboxsubcode.Text))
            {
                MessageBox.Show("Please put Subject Code ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboxsubcode.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txsubdesc.Text))
            {
                MessageBox.Show("Please put Subject Description ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txsubdesc.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txnumunit.Text))
            {
                MessageBox.Show("Please put Number of Units ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txnumunit.Focus();
                return;
            }

            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert Into grades (student_name,COURSE,gender,year_level,semester,school_year,subject_code,subject_description,number_of_units,Date_Time)values('" + fullnametextbox.Text + "','" + comboxcourse.Text + "','" + gendercombobox.Text + "','" + comboxyrlevel.Text + "','" + comboxsem.Text + "','" + comboxschoolyr.Text + "','" + comboxsubcode.Text + "','" + txsubdesc.Text + "','" + txnumunit.Text + "','" + dateTimePicker1.Value + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved");
            TxtClear();
        }

        private void TxtClear() // clear text box after save data
        {
            fullnametextbox.Text = "";
            comboxcourse.SelectedIndex = -1;
            gendercombobox.SelectedIndex = -1;
            comboxyrlevel.SelectedIndex = -1;
            comboxsem.SelectedIndex = -1;
            comboxschoolyr.SelectedIndex = -1;
            comboxsubcode.Text = "";
            txsubdesc.Text = "";
            txnumunit.Text = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            fullnametextbox.Text = "";
            comboxcourse.SelectedIndex = -1;
            gendercombobox.SelectedIndex = -1;
            comboxyrlevel.SelectedIndex = -1;
            comboxsem.SelectedIndex = -1;
            comboxschoolyr.SelectedIndex = -1;
            comboxsubcode.Text = "";
            txsubdesc.Text = "";
            txnumunit.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stud_Num_Click(object sender, EventArgs e)
        {

        }

        private void numberofunits_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form4 = new Form2();
            this.Hide();
            form4.Show();
        }


        private void Code()

        {

            if (comboxcourse.Text == "BSCS" || comboxcourse.Text == "BSCS" ||
                comboxcourse.Text == "BSHM" || comboxcourse.Text == "BSTM" ||
                comboxcourse.Text == "BSBA" || comboxcourse.Text == "BEED" ||
                comboxcourse.Text == "BSED ENG" || comboxcourse.Text == "BSED MATH" ||
                comboxcourse.Text == "AB POLSCI" || comboxyrlevel.Text == "FIRST YEAR" ||
                comboxyrlevel.Text == "SECOND YEAR" || comboxyrlevel.Text == "THIRD YEAR" ||
                comboxyrlevel.Text == "FOURTH YEAR" || comboxsem.Text == "FIRST SEMESTER" ||
                comboxsem.Text == "SECOND SEMESTER" || comboxsem.Text == "SUMMER")
            {

                txsubdesc.Clear();
                txnumunit.Clear();
                comboxsubcode.SelectedIndex = -1;
            }


            // ---------------------------------- STARTING POINT-----------------------------------

            //BSCS ========================================================================================

            // BSCS First year and First semester
            if (comboxcourse.Text == "BSCS" &&
                comboxyrlevel.Text == "FIRST YEAR" &&
                comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("CC101");
                comboxsubcode.Items.Add("CC102");
                comboxsubcode.Items.Add("GE1");
                comboxsubcode.Items.Add("GE2");
                comboxsubcode.Items.Add("NSTP 1");
                comboxsubcode.Items.Add("PE 1");
                comboxsubcode.Items.Add("PDP 1");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");

            }
            // BSCS First year and second semester
            else if (comboxcourse.Text == "BSCS" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("CC103");
                comboxsubcode.Items.Add("GE4");
                comboxsubcode.Items.Add("GE5");
                comboxsubcode.Items.Add("GE6");
                comboxsubcode.Items.Add("DS101");
                comboxsubcode.Items.Add("NSTP 2");
                comboxsubcode.Items.Add("PE 2");
                comboxsubcode.Items.Add("PDP 2");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");

            }
            // BSCS Second year and first semester
            else if (comboxcourse.Text == "BSCS" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE7");
                comboxsubcode.Items.Add("GE8");
                comboxsubcode.Items.Add("CC104");
                comboxsubcode.Items.Add("DS102");
                comboxsubcode.Items.Add("SDF104");
                comboxsubcode.Items.Add("PE 3");
                comboxsubcode.Items.Add("PDP 3");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }
            // BSCS Second year and second semester
            else if (comboxcourse.Text == "BSCS" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE9");
                comboxsubcode.Items.Add("GE10");
                comboxsubcode.Items.Add("CC105");
                comboxsubcode.Items.Add("AL101");
                comboxsubcode.Items.Add("MATH ELE");
                comboxsubcode.Items.Add("PE 4");
                comboxsubcode.Items.Add("PDP 4");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }
            // BSCS Third year and first semester
            else if (comboxcourse.Text == "BSCS" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE11");
                comboxsubcode.Items.Add("GE12");
                comboxsubcode.Items.Add("CC106");
                comboxsubcode.Items.Add("AL102");
                comboxsubcode.Items.Add("AR101");
                comboxsubcode.Items.Add("IAS101");
                comboxsubcode.Items.Add("GV101");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }
            // BSCS Third year and second semester
            else if (comboxcourse.Text == "BSCS" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE13");
                comboxsubcode.Items.Add("GE14");
                comboxsubcode.Items.Add("PL101");
                comboxsubcode.Items.Add("SE101");
                comboxsubcode.Items.Add("SP101");
                comboxsubcode.Items.Add("IS101");
                comboxsubcode.Items.Add("CN101");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSCS Summer
            else if (comboxcourse.Text == "BSCS" &&
                comboxyrlevel.Text == "THIRD YEAR" &&
                comboxsem.Text == "SUMMER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("PRAC101");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSCS Fourth year and first semester
            else if (comboxcourse.Text == "BSCS" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE15");
                comboxsubcode.Items.Add("GE16");
                comboxsubcode.Items.Add("OS101");
                comboxsubcode.Items.Add("SE102");
                comboxsubcode.Items.Add("SF101");
                comboxsubcode.Items.Add("HCI101");
                comboxsubcode.Items.Add("THS101");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSCS Fourth year and second semester
            else if (comboxcourse.Text == "BSCS" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE17");
                comboxsubcode.Items.Add("GE18");
                comboxsubcode.Items.Add("NC101");
                comboxsubcode.Items.Add("PD101");
                comboxsubcode.Items.Add("THS102");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSHM ============================================================

            //BSHM 1st year and 1st semester
            else if (comboxcourse.Text == "BSHM" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE1");
                comboxsubcode.Items.Add("GE2");
                comboxsubcode.Items.Add("GE3");
                comboxsubcode.Items.Add("THC1");
                comboxsubcode.Items.Add("THC2");
                comboxsubcode.Items.Add("NSTP 1");
                comboxsubcode.Items.Add("PE 1");
                comboxsubcode.Items.Add("PDP 1");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            //BSHM 1st year and 2nd semester
            else if (comboxcourse.Text == "BSHM" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("THC3");
                comboxsubcode.Items.Add("THC4");
                comboxsubcode.Items.Add("THC5");
                comboxsubcode.Items.Add("HPC1");
                comboxsubcode.Items.Add("HPC2");
                comboxsubcode.Items.Add("NSTP 2");
                comboxsubcode.Items.Add("PE 2");
                comboxsubcode.Items.Add("PDP 2");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            //BSHM 2nd year and 1st semester
            else if (comboxcourse.Text == "BSHM" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE4");
                comboxsubcode.Items.Add("GE Elec1");
                comboxsubcode.Items.Add("HPC3");
                comboxsubcode.Items.Add("HPC4");
                comboxsubcode.Items.Add("HPC5");
                comboxsubcode.Items.Add("HMPE 1");
                comboxsubcode.Items.Add("PE 3");
                comboxsubcode.Items.Add("PDP 3");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            //BSHM 2nd year and 2nd semester
            else if (comboxcourse.Text == "BSHM" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE5");
                comboxsubcode.Items.Add("GE6");
                comboxsubcode.Items.Add("HPC6");
                comboxsubcode.Items.Add("HPC7");
                comboxsubcode.Items.Add("HMPE 2");
                comboxsubcode.Items.Add("HPC8");
                comboxsubcode.Items.Add("HMPE 3");
                comboxsubcode.Items.Add("PE 4");
                comboxsubcode.Items.Add("PDP 4");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            //BSHM 3rd year and 1st semester
            else if (comboxcourse.Text == "BSHM" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE7");
                comboxsubcode.Items.Add("HMPE 4");
                comboxsubcode.Items.Add("HMPE 5");
                comboxsubcode.Items.Add("BME 1");
                comboxsubcode.Items.Add("THC6");
                comboxsubcode.Items.Add("THC7");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            //BSHM 3rd year and 2nd semester
            else if (comboxcourse.Text == "BSHM" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("BME2");
                comboxsubcode.Items.Add("THC8");
                comboxsubcode.Items.Add("THC9");
                comboxsubcode.Items.Add("THC10");
                comboxsubcode.Items.Add("HPC9");
                comboxsubcode.Items.Add("HMPE 6");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            //BSHM 4th year and 1st semester
            else if (comboxcourse.Text == "BSHM" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("HMPE 7");
                comboxsubcode.Items.Add("GE 8");
                comboxsubcode.Items.Add("HPC10");
                comboxsubcode.Items.Add("GE Elec2");
                comboxsubcode.Items.Add("GE Elec3");
                comboxsubcode.Items.Add("GE9");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            //BSHM 4th year and 2nd semester
            else if (comboxcourse.Text == "BSHM" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("PRAC");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSTM ===========================================================================

            //BSTM 1st year and 1st semester
            else if (comboxcourse.Text == "BSTM" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE1");
                comboxsubcode.Items.Add("GE2");
                comboxsubcode.Items.Add("GE3");
                comboxsubcode.Items.Add("THC1");
                comboxsubcode.Items.Add("THC2");
                comboxsubcode.Items.Add("NSTP 1");
                comboxsubcode.Items.Add("PE 1");
                comboxsubcode.Items.Add("PDP 1");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            //BSTM 1st year and 2nd semester
            else if (comboxcourse.Text == "BSTM" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("TPC1");
                comboxsubcode.Items.Add("THC3");
                comboxsubcode.Items.Add("THC4");
                comboxsubcode.Items.Add("THC5");
                comboxsubcode.Items.Add("TMCC1");
                comboxsubcode.Items.Add("NSTP 2");
                comboxsubcode.Items.Add("PE 2");
                comboxsubcode.Items.Add("PDP 2");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }
            //BSTM 2nd year and 1st semester
            else if (comboxcourse.Text == "BSTM" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE4");
                comboxsubcode.Items.Add("GE ELECTIVE 1");
                comboxsubcode.Items.Add("TPC2");
                comboxsubcode.Items.Add("TPC3");
                comboxsubcode.Items.Add("HMPE1");
                comboxsubcode.Items.Add("PE 3");
                comboxsubcode.Items.Add("PDP 3");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }
            //BSTM 2nd year and 2nd semester
            else if (comboxcourse.Text == "BSTM" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE5");
                comboxsubcode.Items.Add("GE6");
                comboxsubcode.Items.Add("TPC4");
                comboxsubcode.Items.Add("TPC5");
                comboxsubcode.Items.Add("HM PE2");
                comboxsubcode.Items.Add("TPC6");
                comboxsubcode.Items.Add("PE 4");
                comboxsubcode.Items.Add("PDP 4");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }
            //BSTM 3rd year and 1st semester
            else if (comboxcourse.Text == "BSTM" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE7");
                comboxsubcode.Items.Add("TPC7");
                comboxsubcode.Items.Add("HMPE3");
                comboxsubcode.Items.Add("BME1");
                comboxsubcode.Items.Add("THC6");
                comboxsubcode.Items.Add("THC7");
                comboxsubcode.Items.Add("MICE 1"); ;
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }
            //BSTM 3rd year and 2nd semester
            else if (comboxcourse.Text == "BSTM" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("THC8");
                comboxsubcode.Items.Add("BME2");
                comboxsubcode.Items.Add("HMPE4");
                comboxsubcode.Items.Add("THC9");
                comboxsubcode.Items.Add("THC10");
                comboxsubcode.Items.Add("TPC8");
                comboxsubcode.Items.Add("MICE 2");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }
            //BSTM 4th year and 1st semester
            else if (comboxcourse.Text == "BSTM" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("HMPE5");
                comboxsubcode.Items.Add("Rizal");
                comboxsubcode.Items.Add("TPC9");
                comboxsubcode.Items.Add("GE Elective 2");
                comboxsubcode.Items.Add("GE Elective 3");
                comboxsubcode.Items.Add("GE8");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }
            //BSTM 4th year and 2nd semester
            else if (comboxcourse.Text == "BSTM" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("PRAC");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSBA ==============================================================================

            // BSBA 1st year and 1st semester
            else if (comboxcourse.Text == "BSBA" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE1");
                comboxsubcode.Items.Add("GE2");
                comboxsubcode.Items.Add("GE3");
                comboxsubcode.Items.Add("GE4");
                comboxsubcode.Items.Add("NSTP 1");
                comboxsubcode.Items.Add("PE 1");
                comboxsubcode.Items.Add("PDP 1");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSBA 1st year and 2nd semester
            else if (comboxcourse.Text == "BSBA" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE5");
                comboxsubcode.Items.Add("GE6");
                comboxsubcode.Items.Add("GE7");
                comboxsubcode.Items.Add("GE8");
                comboxsubcode.Items.Add("BA 1");
                comboxsubcode.Items.Add("NSTP 2");
                comboxsubcode.Items.Add("PE 2");
                comboxsubcode.Items.Add("PDP 2");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSBA 2nd year and 1st semester
            else if (comboxcourse.Text == "BSBA" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE9");
                comboxsubcode.Items.Add("GE Elective 1");
                comboxsubcode.Items.Add("GE Elective 2");
                comboxsubcode.Items.Add("BA CC 1");
                comboxsubcode.Items.Add("BA 2");
                comboxsubcode.Items.Add("Prof. 1");
                comboxsubcode.Items.Add("PE 3");
                comboxsubcode.Items.Add("PDP 3");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSBA 2nd year and 2nd semester
            else if (comboxcourse.Text == "BSBA" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE Elective 3");
                comboxsubcode.Items.Add("Prof Elective");
                comboxsubcode.Items.Add("BA CC 2");
                comboxsubcode.Items.Add("BA CC 3");
                comboxsubcode.Items.Add("Prof. 2");
                comboxsubcode.Items.Add("Prof. 3");
                comboxsubcode.Items.Add("PE 4");
                comboxsubcode.Items.Add("PDP 4");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSBA 3rd year and 1st semester
            else if (comboxcourse.Text == "BSBA" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("CBMEC");
                comboxsubcode.Items.Add("BA CC 4");
                comboxsubcode.Items.Add("BA CC 5");
                comboxsubcode.Items.Add("BA CC 6");
                comboxsubcode.Items.Add("Prof. 4");
                comboxsubcode.Items.Add("Prof. 5");
                comboxsubcode.Items.Add("BA 3");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSBA 3rd year and 2nd semester
            else if (comboxcourse.Text == "BSBA" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("BA CC 7");
                comboxsubcode.Items.Add("BMEC");
                comboxsubcode.Items.Add("Prof. 6");
                comboxsubcode.Items.Add("Prof. 7");
                comboxsubcode.Items.Add("Elective 1");
                comboxsubcode.Items.Add("BA 4");
                comboxsubcode.Items.Add("BA 5");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSBA 4th year and 1st semester
            else if (comboxcourse.Text == "BSBA" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("Prof. 8");
                comboxsubcode.Items.Add("Elective 2");
                comboxsubcode.Items.Add("Elective 3");
                comboxsubcode.Items.Add("BA CC 8");
                comboxsubcode.Items.Add("Prof Elec 4");
                comboxsubcode.Items.Add("BA 6");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSBA 4th year and 1st semester
            else if (comboxcourse.Text == "BSBA" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("Elective 4");
                comboxsubcode.Items.Add("Practicum");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BEED ==========================================================================

            // BEED 1st year and 1st semester
            else if (comboxcourse.Text == "BEED" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE1");
                comboxsubcode.Items.Add("GE2");
                comboxsubcode.Items.Add("GE3");
                comboxsubcode.Items.Add("GE4");
                comboxsubcode.Items.Add("GE5");
                comboxsubcode.Items.Add("GE6");
                comboxsubcode.Items.Add("EDUC101");
                comboxsubcode.Items.Add("NSTP 1");
                comboxsubcode.Items.Add("PE 1");
                comboxsubcode.Items.Add("PDP 1");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BEED 1st year and 2nd semester
            else if (comboxcourse.Text == "BEED" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE7");
                comboxsubcode.Items.Add("GE8");
                comboxsubcode.Items.Add("GE9");
                comboxsubcode.Items.Add("GE10");
                comboxsubcode.Items.Add("GE11");
                comboxsubcode.Items.Add("GE12");
                comboxsubcode.Items.Add("EDUC102");
                comboxsubcode.Items.Add("NSTP 2");
                comboxsubcode.Items.Add("PE 2");
                comboxsubcode.Items.Add("PDP 2");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BEED 2nd year and 1st semester
            else if (comboxcourse.Text == "BEED" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("TTL1");
                comboxsubcode.Items.Add("EDUC103");
                comboxsubcode.Items.Add("SCI1");
                comboxsubcode.Items.Add("MATH1");
                comboxsubcode.Items.Add("SSC1");
                comboxsubcode.Items.Add("FIL1");
                comboxsubcode.Items.Add("VED");
                comboxsubcode.Items.Add("PE 3");
                comboxsubcode.Items.Add("PDP 3");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BEED 2nd year and 2nd semester
            else if (comboxcourse.Text == "BEED" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("EDUC104");
                comboxsubcode.Items.Add("EDUC105");
                comboxsubcode.Items.Add("SCI2");
                comboxsubcode.Items.Add("MATH2");
                comboxsubcode.Items.Add("MTB-MLE");
                comboxsubcode.Items.Add("SSC2");
                comboxsubcode.Items.Add("TLE1");
                comboxsubcode.Items.Add("PE 4");
                comboxsubcode.Items.Add("PDP 4");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BEED 3rd year and 1st semester
            else if (comboxcourse.Text == "BEED" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("ENG1");
                comboxsubcode.Items.Add("EDUC106");
                comboxsubcode.Items.Add("TTL2");
                comboxsubcode.Items.Add("EDUC107");
                comboxsubcode.Items.Add("MUSIC");
                comboxsubcode.Items.Add("ENG2");
                comboxsubcode.Items.Add("ARTS");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BEED 3rd year and 2nd semester
            else if (comboxcourse.Text == "BEED" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("EDUC108");
                comboxsubcode.Items.Add("EDUC109");
                comboxsubcode.Items.Add("ELEC");
                comboxsubcode.Items.Add("PEH");
                comboxsubcode.Items.Add("FIL2");
                comboxsubcode.Items.Add("RES");
                comboxsubcode.Items.Add("TLE2");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BEED 4th year and 1st semester
            else if (comboxcourse.Text == "BEED" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("FS1");
                comboxsubcode.Items.Add("FS2");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BEED 4th year and 2nd semester
            else if (comboxcourse.Text == "BEED" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("TI");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSED ENGSLISH =====================================================================

            // ENG 1st year and 1st sem
            else if (comboxcourse.Text == "BSED ENG" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("LING1");
                comboxsubcode.Items.Add("LING2");
                comboxsubcode.Items.Add("LING3");
                comboxsubcode.Items.Add("GE1");
                comboxsubcode.Items.Add("GE2");
                comboxsubcode.Items.Add("GE3");
                comboxsubcode.Items.Add("GE4");
                comboxsubcode.Items.Add("NSTP 1");
                comboxsubcode.Items.Add("PE 1");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // ENG 1st year and 2nd sem
            else if (comboxcourse.Text == "BSED ENG" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("ELT1");
                comboxsubcode.Items.Add("ELT2");
                comboxsubcode.Items.Add("ELT3");
                comboxsubcode.Items.Add("GE5");
                comboxsubcode.Items.Add("GE6");
                comboxsubcode.Items.Add("GE7");
                comboxsubcode.Items.Add("EDUC101");
                comboxsubcode.Items.Add("NSTP 2");
                comboxsubcode.Items.Add("PE 2");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // ENG 2nd year and 1st sem
            else if (comboxcourse.Text == "BSED ENG" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("ELT4");
                comboxsubcode.Items.Add("ELT5");
                comboxsubcode.Items.Add("ELT6");
                comboxsubcode.Items.Add("ELT7");
                comboxsubcode.Items.Add("GE8");
                comboxsubcode.Items.Add("GE9");
                comboxsubcode.Items.Add("GE10");
                comboxsubcode.Items.Add("EDUC102");
                comboxsubcode.Items.Add("PE 3");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // ENG 2nd year and 2nd sem
            else if (comboxcourse.Text == "BSED ENG" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("ELT8");
                comboxsubcode.Items.Add("LIT101");
                comboxsubcode.Items.Add("LIT102");
                comboxsubcode.Items.Add("LIT103");
                comboxsubcode.Items.Add("GE11");
                comboxsubcode.Items.Add("GE12");
                comboxsubcode.Items.Add("EDUC109");
                comboxsubcode.Items.Add("PE 4");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // ENG 3rd year and 1st sem
            else if (comboxcourse.Text == "BSED ENG" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("LIT104");
                comboxsubcode.Items.Add("LIT105");
                comboxsubcode.Items.Add("LIT106");
                comboxsubcode.Items.Add("LIT107");
                comboxsubcode.Items.Add("TTL1");
                comboxsubcode.Items.Add("EDUC103");
                comboxsubcode.Items.Add("EDUC105");
                comboxsubcode.Items.Add("EDUC107");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // ENG 3rd year and 2nd sem
            else if (comboxcourse.Text == "BSED ENG" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("CJ");
                comboxsubcode.Items.Add("ELT9");
                comboxsubcode.Items.Add("TTL2");
                comboxsubcode.Items.Add("ELEC1");
                comboxsubcode.Items.Add("ELEC2");
                comboxsubcode.Items.Add("EDUC104");
                comboxsubcode.Items.Add("EDUC106");
                comboxsubcode.Items.Add("EDUC108");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // ENG 4th year and 1st sem
            else if (comboxcourse.Text == "BSED ENG" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();


                comboxsubcode.Items.Add("FS1");
                comboxsubcode.Items.Add("FS2");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // ENG 4th year and 2nd sem
            else if (comboxcourse.Text == "BSED ENG" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("TI");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // BSED MATHEMATICS =============================================================

            // MATH 1st year and 1st sem
            else if (comboxcourse.Text == "BSED MATH" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("M100");
                comboxsubcode.Items.Add("M101");
                comboxsubcode.Items.Add("TSF");
                comboxsubcode.Items.Add("GE1");
                comboxsubcode.Items.Add("GE2");
                comboxsubcode.Items.Add("GE3");
                comboxsubcode.Items.Add("GE4");
                comboxsubcode.Items.Add("NSTP 1");
                comboxsubcode.Items.Add("PE 1");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // MATH 1st year and 2nd sem
            else if (comboxcourse.Text == "BSED MATH" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("M102");
                comboxsubcode.Items.Add("M103");
                comboxsubcode.Items.Add("M104");
                comboxsubcode.Items.Add("GE5");
                comboxsubcode.Items.Add("GE6");
                comboxsubcode.Items.Add("GE7");
                comboxsubcode.Items.Add("GE8");
                comboxsubcode.Items.Add("NSTP 2");
                comboxsubcode.Items.Add("PE 2");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // MATH 2nd year and 1st sem
            else if (comboxcourse.Text == "BSED MATH" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("M106");
                comboxsubcode.Items.Add("M109");
                comboxsubcode.Items.Add("M110");
                comboxsubcode.Items.Add("GE9");
                comboxsubcode.Items.Add("GE10");
                comboxsubcode.Items.Add("EDUC101");
                comboxsubcode.Items.Add("TP");
                comboxsubcode.Items.Add("PE 3");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // MATH 2nd year and 2nd sem
            else if (comboxcourse.Text == "BSED MATH" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("M107");
                comboxsubcode.Items.Add("M111");
                comboxsubcode.Items.Add("M112");
                comboxsubcode.Items.Add("M105");
                comboxsubcode.Items.Add("GE11");
                comboxsubcode.Items.Add("GE12");
                comboxsubcode.Items.Add("EDUC109");
                comboxsubcode.Items.Add("PE 4");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // MATH 3rd year and 1st sem
            else if (comboxcourse.Text == "BSED MATH" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("M108");
                comboxsubcode.Items.Add("M113");
                comboxsubcode.Items.Add("M115");
                comboxsubcode.Items.Add("M116");
                comboxsubcode.Items.Add("EDUC103");
                comboxsubcode.Items.Add("EDUC105");
                comboxsubcode.Items.Add("EDUC107");
                comboxsubcode.Items.Add("TTL1");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // MATH 3rd year and 2nd sem
            else if (comboxcourse.Text == "BSED MATH" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("M114");
                comboxsubcode.Items.Add("M117");
                comboxsubcode.Items.Add("M118");
                comboxsubcode.Items.Add("M119");
                comboxsubcode.Items.Add("EDUC104");
                comboxsubcode.Items.Add("EDUC106");
                comboxsubcode.Items.Add("EDUC108");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // MATH 4th year and 1st sem
            else if (comboxcourse.Text == "BSED MATH" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("FS1");
                comboxsubcode.Items.Add("FS2");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // MATH 4th year and 2nd sem
            else if (comboxcourse.Text == "BSED MATH" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("TI");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // AB POLSCI ==========================================================================

            // POLSCI 1st year and 1st sem
            else if (comboxcourse.Text == "AB POLSCI" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE1");
                comboxsubcode.Items.Add("GE2");
                comboxsubcode.Items.Add("GE3");
                comboxsubcode.Items.Add("SOCSCI 101");
                comboxsubcode.Items.Add("BAPOL 1");
                comboxsubcode.Items.Add("NSTP 1");
                comboxsubcode.Items.Add("PE 1");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // POLSCI 1st year and 2nd sem
            else if (comboxcourse.Text == "AB POLSCI" &&
                     comboxyrlevel.Text == "FIRST YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE4");
                comboxsubcode.Items.Add("GE5");
                comboxsubcode.Items.Add("GE6");
                comboxsubcode.Items.Add("BAPOL 2");
                comboxsubcode.Items.Add("NSTP 2");
                comboxsubcode.Items.Add("PE 2");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // POLSCI 2nd year and 1st sem
            else if (comboxcourse.Text == "AB POLSCI" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE7");
                comboxsubcode.Items.Add("BAPOL 3");
                comboxsubcode.Items.Add("GE8");
                comboxsubcode.Items.Add("SOCSCI 0");
                comboxsubcode.Items.Add("PE 3");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // POLSCI 2nd year and 2nd sem
            else if (comboxcourse.Text == "AB POLSCI" &&
                     comboxyrlevel.Text == "SECOND YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("GE9");
                comboxsubcode.Items.Add("BAPOL 4");
                comboxsubcode.Items.Add("BAPOL 5");
                comboxsubcode.Items.Add("PE 4");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // POLSCI 3rd year and 1st sem'
            else if (comboxcourse.Text == "AB POLSCI" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("BAPOL 6");
                comboxsubcode.Items.Add("BAPOL 7");
                comboxsubcode.Items.Add("POL ELE 1");
                comboxsubcode.Items.Add("O ELE 1");
                comboxsubcode.Items.Add("FRE ELE 1");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // POLSCI 3rd year and 2nd sem
            else if (comboxcourse.Text == "AB POLSCI" &&
                     comboxyrlevel.Text == "THIRD YEAR" &&
                     comboxsem.Text == "SECOND SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("BAPOL 8");
                comboxsubcode.Items.Add("BAPOL 9");
                comboxsubcode.Items.Add("POL ELE 2");
                comboxsubcode.Items.Add("O ELE 2");
                comboxsubcode.Items.Add("FRE ELE 2");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // POLSCI 4th year and 1st sem
            else if (comboxcourse.Text == "AB POLSCI" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("BAPOL 10");
                comboxsubcode.Items.Add("POL ELE 3");
                comboxsubcode.Items.Add("FRE ELE 3");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // POLSCI 4th year and 2nd sem
            else if (comboxcourse.Text == "AB POLSCI" &&
                     comboxyrlevel.Text == "FOURTH YEAR" &&
                     comboxsem.Text == "FIRST SEMESTER")
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
                comboxsubcode.Items.Add("O ELE 3");
                comboxsubcode.Items.Add("FRE ELE 4");
                comboxsubcode.Items.Add("FRE ELE 5");
                comboxschoolyr.Items.Add("2020-2021");
                comboxschoolyr.Items.Add("2021-2022");
            }

            // Innaplicable Selection
            else
            {
                comboxsubcode.Items.Clear();
                comboxschoolyr.Items.Clear();
            }
        }


        //------------------------------------- END POINT --------------------------------------

        private void subcode()
        {
            // BSCS 1st year and 1st sem
            if (comboxsubcode.Text == "CC101" &&
                comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Introduction to Computing";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "CC102" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Fundamentals of Programming";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "GE1" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Communication Skills 1";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "GE2" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Komunikasyon sa Akademikong Filipino";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "GE3" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "College Algebra";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "NSTP 1" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "National Service Training Program 1";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "PE 1" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Physical Fitness";
                txnumunit.Text = "2";
            }
            else if (comboxsubcode.Text == "PDP 1" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Professional Development Program 1";
                txnumunit.Text = "2";
            }

            // BSCS 1st year and 2nd sem

            else if (comboxsubcode.Text == "CC103" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Intermediate Programming";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "GE4" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Communication Skills 2";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "GE5" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Pagbasa at Pagsulat Tungo sa Pananaliksik";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "GE6" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Art Appreciation";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "DS101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Discrete Structures 1";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "NSTP 2" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "National Service Training Program 2";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "PE 2" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Rhythmic Activities";
                txnumunit.Text = "2";
            }
            else if (comboxsubcode.Text == "PDP 2" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Professional Development Program 2";
                txnumunit.Text = "2";
            }

            // BSCS 2nd year and 1st sem

            else if (comboxsubcode.Text == "GE7" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Speech and Oral Communication";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "GE8" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Probabilities and Statistics";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "CC104" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Data Structure and Algorithms";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "DS102" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Discrete Structures 2";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "SDF104" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Object-oriented Programming";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "PE 3" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Individual & Dual Sports";
                txnumunit.Text = "2";
            }
            else if (comboxsubcode.Text == "PDP 3" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Professional Development Program 3";
                txnumunit.Text = "2";
            }

            // BSCS 2nd year and 2nd sem

            else if (comboxsubcode.Text == "GE9" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "College Physics";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "GE10" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Introduction to Literature including Phil. Setting";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "CC105" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Information Management";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "AL101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Algorithms and Complexity";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "MATH ELE" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Discrete Mathematics";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "PE 4" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Team Sports";
                txnumunit.Text = "2";
            }
            else if (comboxsubcode.Text == "PDP 4" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Professional Development Program 4";
                txnumunit.Text = "2";
            }

            // BSCS 3rd year and 1st sem
            else if (comboxsubcode.Text == "GE11" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Trigonometry";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "GE12" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Philosophy of Man and Ethics";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "CC106" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Applications Development and Emerging Technologies";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "AL102" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Automata Theory and Formal Languages";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "AR101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Architecture and Organization";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "IAS101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Information Assurance and Security";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "GV101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Graphics and Visual Computing (elective)";
                txnumunit.Text = "3";
            }

            // BSCS 3rd year and 2nd sem
            else if (comboxsubcode.Text == "GE13" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Electricity & Electromagnetism";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "GE14" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Life and Works of Rizal";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "PL101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Programming Languages";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "SE101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Software Engineering 1";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "SP101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Social Issues and Professional Practice";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "IS101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Intelligent Systems (elective)";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "CN101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Computational Science";
                txnumunit.Text = "3";
            }

            // BSCS Summer
            else if (comboxsubcode.Text == "PRAC101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Practicum (200hrs.)";
                txnumunit.Text = "3";
            }

            // BSCS 4th year and 1st sem

            else if (comboxsubcode.Text == "GE15" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Philippine History and Culture";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "GE16" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Politics & Governance (w/ Philippine Constitution)";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "OS101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Operating Systems";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "SE102" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Software Engineering 2";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "SF101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "System Fundamentals (elective)";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "HCI101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Human Computer Interaction";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "THS101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "CS Thesis Writing 1";
                txnumunit.Text = "3";
            }

            // BSCS 4th year and 2nd sem

            else if (comboxsubcode.Text == "GE17" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Economics (w/ Taxation & Agrarian Reform Integrated)";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "GE18" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Asian/Western Civilization";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "NC101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Networks and Communications";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "PD101" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "Parallel and Distributed Computing";
                txnumunit.Text = "3";
            }
            else if (comboxsubcode.Text == "THS102" &&
                     comboxcourse.Text == "BSCS")
            {
                txsubdesc.Text = "CS Thesis Writing 2";
                txnumunit.Text = "3";
            }

            // BSHM ****************************************************************

            // BSHM 1st year and 1st sem

            else if (comboxsubcode.Text == "GE1" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Purposive Communication";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE2" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Readings in Phil. History";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE1" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Purposive Communication";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE3" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Mathematics in the Modern World";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "THC1" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Macro Perspective of Toursim and Hospirtality";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "THC2" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Risk Management as Applied to Safety, Security and Sanitation";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "NSTP 1" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "National Service Training Program 1";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 1" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Physical Fitness";
                txnumunit.Text = "2";
            }

            else if (comboxsubcode.Text == "PDP 1" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Professional Development Program 1";
                txnumunit.Text = "2";
            }

            // BSHM 1st year and 2nd sem

            else if (comboxsubcode.Text == "THC3" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Quality Service Management in Tourism and Hospitality";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "THC4" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Philippines Tourism, Geography and Culture";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "THC5" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Micro Perspective of Tourism and Hospitality";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HPC1" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Kitchen Essentials and Basic Food Preparation";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HPC2" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Fundamentals in Lodging Operations";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "NSTP 2" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "National Service Training Program 2";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 2" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Rhytmic Activities";
                txnumunit.Text = "2";
            }

            else if (comboxsubcode.Text == "PDP 2" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Professional Development 2";
                txnumunit.Text = "2";
            }

            // BSHM 2nd year and 1st sem

            else if (comboxsubcode.Text == "GE4" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Understanding the Self";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE Elec1" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Environmental Science";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HPC3" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Applied Bus Tools and Technologies (PMS) with Lab";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HPC4" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Supply Chain Management in Hospitality Industry";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HPC5" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Foreign Language 1";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HMPE 1" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Asian Cuisine";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 3" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Individual and Dual Sports";
                txnumunit.Text = "2";
            }

            else if (comboxsubcode.Text == "PDP 3" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Professional Development Program 3";
                txnumunit.Text = "2";
            }

            //BSHM 2nd year and 2nd sem

            else if (comboxsubcode.Text == "GE5" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Science, Technology and Society";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE6" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Ethics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HPC6" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Fundamentals in Food Service Operations";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HPC7" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Introduction to MICE";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HMPE 2" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Bread and Pastry";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HPC8" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Foreign Language 2 (HPC)";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HMPE 3" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Cruise Ship Management";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 4" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Team Sports";
                txnumunit.Text = "2";
            }

            else if (comboxsubcode.Text == "PDP 4" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Professional Development Program 4";
                txnumunit.Text = "2";
            }

            //BSHM 3rd year and 1st sem

            else if (comboxsubcode.Text == "GE7" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "The Contemporary World";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HMPE 4" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Bar and Beverage Management w/ lab";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HMPE 5" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Front Office Operation";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "BME 1" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Operations Management in TH Industry";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "THC6" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Professional Development and Applied Ethics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "THC7" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Tourism and Hospitality Marketing";
                txnumunit.Text = "3";
            }

            // BSHM 3rd year and 2nd sem

            else if (comboxsubcode.Text == "BME2" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Strategic Management in Tourism and Hospitality";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "THC8" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Legal Aspects in Tourism and Hospitality";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "THC9" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Multicultural Diversity in Workplace for the Tourism Professional";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "THC10" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Entrepreneurship in Tourism and Hospitality";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HPC9" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Ergonomics and Facilities Planning for the Hospitality Industry";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HMPE 6" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Catering Management";
                txnumunit.Text = "3";
            }

            // BSHM 4th year and 1st sem

            else if (comboxsubcode.Text == "HMPE 7" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Cost Control";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE 8" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Art Appreciation";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "HPC10" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Research in Hospitality";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE Elec2" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Living in the IT Era";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE Elec3" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Entrepreneurial Mind";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE9" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Life and Works of Rizal";
                txnumunit.Text = "3";
            }

            // BSHM 4th year and 2nd sem

            else if (comboxsubcode.Text == "PRAC" &&
                     comboxcourse.Text == "BSHM")
            {
                txsubdesc.Text = "Practicum (600 hrs)";
                txnumunit.Text = "3";
            }

            // BEED 1st year and 1st sem

            else if (comboxsubcode.Text == "GE1" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Understanding the Self";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE2" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Readings in Philippine History";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE3" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "The Contemporary World";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE4" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Mathematics in the Modern World";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE5" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Purposive Communication";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE6" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Art Appreciation";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC101" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "The Child and Adolescent Learners and Learning Principles";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "NSTP 1" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "National Service Training Program 1";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 1" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Physical Fitness";
                txnumunit.Text = "2";
            }

            else if (comboxsubcode.Text == "PDP 1" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Personal Development Program 1";
                txnumunit.Text = "2";
            }

            // BEED 1st year and 2nd sem

            else if (comboxsubcode.Text == "GE7" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Science, Technology, and Society";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE8" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Ethics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE9" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Living in the IT Era";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE10" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Gender and Society";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE11" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Reading Visual Arts";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE12" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Life and Works of Rizal";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC102" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "The Teaching Profession";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "NSTP 2" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "National Service Training Program 2";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 2" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Rhythmic Activities";
                txnumunit.Text = "2";
            }

            else if (comboxsubcode.Text == "PDP 2" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Professional Development Program 2";
                txnumunit.Text = "2";
            }

            // BEED 2nd year and 1st sem

            else if (comboxsubcode.Text == "TTL1" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Technology for Teaching and Learning 1";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC103" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Facilitating Learner-Centered Teaching";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "SCI1" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Teaching Science in Elementary Grades (Biology and Chemistry)";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "MATH1" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Teaching Math in the Primary Grades";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "SSC1" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Teaching Social Studies in Elementary Grades (Philippine History & Government)";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "FIL1" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Pagtuturo and Filipino sa Elementarya (I) - Estruktura at Gamit ng Wikang Filipino";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "VED" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Good Manners and Right Conduct (Edukasyon sa Pagpapakatao)";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 3" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Individual and Dual Sports";
                txnumunit.Text = "2";
            }

            else if (comboxsubcode.Text == "PDP 3" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Professional Development Program 3";
                txnumunit.Text = "2";
            }

            // BEED 2nd year and 2nd sem

            else if (comboxsubcode.Text == "EDUC104" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Building and Enhancing New Literacies Across the Curriculum";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC105" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Foundation of Special and Inclusive Education";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "SCI2" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Teaching Science in the Elementary Grades (Physics, Earth and Space Science)";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "MATH2" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Teaching Math in the Intermediate Grades";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "MTB-MLE" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Teaching Social Studies in the Elementary Grades (Culture and Geography)";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "TLE1" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Edukasyong Pantahanan at Pangkabuhayan";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 4" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Team Sports";
                txnumunit.Text = "2";
            }

            else if (comboxsubcode.Text == "PDP 4" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Professional Development Program 4";
                txnumunit.Text = "2";
            }

            // BEED 3rd year and 1st sem

            else if (comboxsubcode.Text == "ENG1" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Teaching English in the Elementary Grades (Language Arts)";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC106" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "The Teacher and the School Curriculum";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "TTL2" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Technology for Teaching in the Elementary Grades";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC107" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Assessment in Learning 1";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "MUSIC" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Teaching Music in the Elementary Grades";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "ENG2" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Teaching English in the Elementary Grades  Through Literature";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "ARTS" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Teaching Arts in the Elementary  Grades";
                txnumunit.Text = "3";
            }

            // BEED 3rd year and 2nd sem

            else if (comboxsubcode.Text == "EDUC108" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Assessment in Learning 2";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC109" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "The Teacher and the Community , School  Culture and Organizational Leadership";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "ELEC" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Teaching Multi-grade Classes";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PEH" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Teaching PE and Health in the Elementary Grades";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "FIL2" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Pagtuturo ng Filipino sa Elementarya (II) Panitikan ng Pilipinas";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "RES" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Research in Education";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "TLE2" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Edukasyon Pantahanan at Pangkabuhayan with Entrepreneurship";
                txnumunit.Text = "3";
            }

            // BEED 4th year and 1st sem

            else if (comboxsubcode.Text == "FS1" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Field Study 1 (In-campus)";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "FS2" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Field Study 2 (In-campus)";
                txnumunit.Text = "3";
            }

            // BEED 4th year and 2nd sem

            else if (comboxsubcode.Text == "TI" && comboxcourse.Text == "BEED")
            {
                txsubdesc.Text = "Teaching Internship  (Off-campus)";
                txnumunit.Text = "6";
            }

            // ENG ************************************************************


            // ENG 1st year and 1st sem

            else if (comboxsubcode.Text == "LING1" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Introduction to Linguistics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "LING2" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Language, Culture and Society";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "LING3" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Structures of English";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE1" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Understanding the Self";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE2" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Readings in Philippine History";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE3" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "The Contemporary World";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE4" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Mathematics in the Modern World";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "NSTP 1" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "National Service Training Program 1";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 1" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Physical Fitness";
                txnumunit.Text = "2";
            }

            // ENG 1st year and 2nd sem
            else if (comboxsubcode.Text == "ELT1" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Principles and Theories of Language Acquisition and Learning";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "ELT2" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Language Programs and Policies in Multilingual Societies";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "ELT3" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Language Learning Materials Development";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE5" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Purposive Communication";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE6" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Art Appreciation";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE7" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Science, Technology and Society";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC101" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "The Child and Adolescent Learner and Learning Principles";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "NSTP 2" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "National Service Training Program 2";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 2" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Rhythmic Activities";
                txnumunit.Text = "2";
            }

            // ENG 2nd year and 1st sem
            else if (comboxsubcode.Text == "ELT4" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Teaching and Assessment of Literature Studies";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "ELT5" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Teaching and Assessment of the Macroskills";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "ELT6" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Teaching and Assessment of Grammar";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "ELT7" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Speech and Theater Arts";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE8" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Ethics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE9" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Living in the IT Era";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE10" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Gender and Society";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC102" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "The Teaching Profession";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 3" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Individual and Dual Sports";
                txnumunit.Text = "2";
            }

            // ENG 2nd year and 2nd sem
            else if (comboxsubcode.Text == "ELT8" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Language Education Research";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "LIT101" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Children and Adolescent Literature";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "LIT102" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Mythology and Folklore";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "LIT103" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Survey of Philippine Literature in English";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE11" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Reading Visual Arts";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE12" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Life and Works of Rizal";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC109" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "The Teacher and the Community, School Culture and Organizational Leadership";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 4" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Team Sports";
                txnumunit.Text = "2";
            }

            // ENG 3rd year and 1st sem
            else if (comboxsubcode.Text == "LIT104" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Survey of Afro-Asian Literature";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "LIT105" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Survey of English and American Literature";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "LIT106" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Contemporary, Popular, and Emergent Literature";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "LIT107" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Literary Criticism";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "TTL1" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Technology for Teaching and Learning 1";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC103" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Facilitating Learner-Centered teaching";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC105" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Foundation of Special  and Inclusive Education";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC107" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Assessment in Learning 1";
                txnumunit.Text = "3";
            }

            // ENG 3rd year and 2nd sem
            else if (comboxsubcode.Text == "CJ" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Campus Journalism";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "ELT9" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Technical Writing";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "TTL2" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Technology for Teaching and Learning 2 (Technology in Language Education)";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "ELEC1" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "English for Specific Purposes";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "ELEC2" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Creative Writing";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC104" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Building and Enhancing New Literacies Across the Curriculum";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC106" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "The Teacher and the School Curriculum";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC108" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Assessment in Learning 2";
                txnumunit.Text = "3";
            }

            // ENG 4th year and 1st sem
            else if (comboxsubcode.Text == "FS1" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Field Study 1 (In-campus)";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "FS2" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Field Study 2 (In-campus)";
                txnumunit.Text = "3";
            }

            //ENG 4th year / 2nd sem
            else if (comboxsubcode.Text == "TI" && comboxcourse.Text == "BSED ENGLISH")
            {
                txsubdesc.Text = "Teaching Internship  (Off-campus)";
                txnumunit.Text = "6";
            }

            // MATH ************************************************************

            //MATH 1st year / 1st sem
            else if (comboxsubcode.Text == "M100" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "History of Mathematics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M101" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "College and Advanced Algebra";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "TSF" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Teaching in the Specialized Field";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE1" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Understanding the Self";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE2" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Readings in Philippine History";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE3" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "The Contemporary World";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE4" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Mathematics in the Modern World";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "NSTP 1" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "National Service Training Program 1";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 1" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Physical Fitness";
                txnumunit.Text = "2";
            }

            //MATH 1st year / 2nd sem
            else if (comboxsubcode.Text == "M102" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Trigonometry";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M103" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Plane and Solid Geometry";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M104" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Logic and Set Theory";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE5" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Purposive Communication";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE6" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Art Appreciation";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE7" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Science, Technology and Society";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE8" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Ethics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "NSTP 2" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "National Service Training Program 2";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 2" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Rhythmic Activities";
                txnumunit.Text = "2";
            }

            //MATH 2nd year / 1st sem
            else if (comboxsubcode.Text == "M106" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Calculus I with Analytic Geometry";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M109" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Modern Geometry";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M110" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Mathematics of Investment";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE9" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Living in the IT Era";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE10" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Gender and Society";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC101" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "The Child and Adolescent Learner and Learning Principles";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "TP" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "The Teaching Profession";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 3" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Individual and Dual Sports";
                txnumunit.Text = "3";
            }

            //MATH 2nd year / 2nd sem
            else if (comboxsubcode.Text == "M107" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Calculus 2";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M111" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Number Theory";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M112" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Linear Algebra";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M105" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Elementary Statistics and Probability";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE11" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Reading Visual Arts";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE12" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Life and Works of Rizal";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC109" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "The Teacher and the Community, School Culture and Organizational Leadership";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 4" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Team Sports";
                txnumunit.Text = "2";
            }

            //MATH 3rd year / 1st sem
            else if (comboxsubcode.Text == "M108" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Calculus 3";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M113" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Advanced Statistics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M115" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Problem Solving, Mathematical Investigation and Modeling";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M116" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Principles and Strategies in Teaching Mathematics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC103" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Facilitating Learner-Centered Teaching";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC105" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Foundation of Special and Inclusive Education";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC107" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Assessment in Learning 1";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "TTL1" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Technology for Teaching and Learning 1";
                txnumunit.Text = "3";
            }

            //MATH 3rd year / 2nd sem
            else if (comboxsubcode.Text == "M114" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Abstract Algebra";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M117" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Technology for Teaching and Learning 2 (Instrumentation & Technology in Mathematics)";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M118" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Research in Mathematics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M119" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Assessment and Evaluation in Mathematics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC104" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Building and Enhancing New Literacies Across the Curriculum";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC106" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "The Teacher and the School Curriculum";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC108" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Assessment in Learning 2";
                txnumunit.Text = "3";
            }

            //MATH 4th year / 1st sem
            else if (comboxsubcode.Text == "FS1" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Field Study 1 (In-campus)";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "FS2" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Field Study 2 (In-campus)";
                txnumunit.Text = "3";
            }

            //MATH 4th year  / 2nd sem
            else if (comboxsubcode.Text == "TI" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Teaching Internship  (Off-campus)";
                txnumunit.Text = "6";
            }
            // MATH ************************************************************

            //MATH 1st year / 1st sem
            else if (comboxsubcode.Text == "GE1" && comboxcourse.Text == "AB POLSCI")
            {
                txsubdesc.Text = "Purposive Communication";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE2" && comboxcourse.Text == "AB POLSCI")
            {
                txsubdesc.Text = "Life and Works of Rizal";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE3" && comboxcourse.Text == "AB POLSCI")
            {
                txsubdesc.Text = "Understanding the Self";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "SOCSCI 101" && comboxcourse.Text == "AB POLSCI")
            {
                txsubdesc.Text = "Foundation of Behavioral Science";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "BAPOL 1" && comboxcourse.Text == "AB POLSCI")
            {
                txsubdesc.Text = "Fundamental of Political Science";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "NSTP 1" && comboxcourse.Text == "AB POLSCI")
            {
                txsubdesc.Text = "National Service Training Program 1";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 1" && comboxcourse.Text == "AB POLSCI")
            {
                txsubdesc.Text = "Physical Fitness";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "NSTP 1" && comboxcourse.Text == "AB POLSCI")
            {
                txsubdesc.Text = "National Service Training Program 1";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 1" && comboxcourse.Text == "AB POLSCI")
            {
                txsubdesc.Text = "Physical Fitness";
                txnumunit.Text = "2";
            }

            //MATH 1st year / 2nd sem
            else if (comboxsubcode.Text == "M102" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Trigonometry";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M103" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Plane and Solid Geometry";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M104" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Logic and Set Theory";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE5" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Purposive Communication";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE6" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Art Appreciation";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE7" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Science, Technology and Society";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE8" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Ethics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "NSTP 2" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "National Service Training Program 2";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 2" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Rhythmic Activities";
                txnumunit.Text = "2";
            }

            //MATH 2nd year / 1st sem
            else if (comboxsubcode.Text == "M106" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Calculus I with Analytic Geometry";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M109" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Modern Geometry";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M110" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Mathematics of Investment";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE9" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Living in the IT Era";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE10" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Gender and Society";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC101" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "The Child and Adolescent Learner and Learning Principles";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "TP" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "The Teaching Profession";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 3" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Individual and Dual Sports";
                txnumunit.Text = "3";
            }

            //MATH 2nd year / 2nd sem
            else if (comboxsubcode.Text == "M107" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Calculus 2";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M111" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Number Theory";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M112" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Linear Algebra";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M105" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Elementary Statistics and Probability";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE11" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Reading Visual Arts";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "GE12" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Life and Works of Rizal";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC109" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "The Teacher and the Community, School Culture and Organizational Leadership";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "PE 4" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Team Sports";
                txnumunit.Text = "2";
            }

            //MATH 3rd year / 1st sem
            else if (comboxsubcode.Text == "M108" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Calculus 3";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M113" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Advanced Statistics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M115" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Problem Solving, Mathematical Investigation and Modeling";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M116" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Principles and Strategies in Teaching Mathematics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC103" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Facilitating Learner-Centered Teaching";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC105" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Foundation of Special and Inclusive Education";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC107" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Assessment in Learning 1";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "TTL1" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Technology for Teaching and Learning 1";
                txnumunit.Text = "3";
            }

            //MATH 3rd year / 2nd sem
            else if (comboxsubcode.Text == "M114" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Abstract Algebra";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M117" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Technology for Teaching and Learning 2 (Instrumentation & Technology in Mathematics)";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M118" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Research in Mathematics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "M119" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Assessment and Evaluation in Mathematics";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC104" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Building and Enhancing New Literacies Across the Curriculum";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC106" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "The Teacher and the School Curriculum";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "EDUC108" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Assessment in Learning 2";
                txnumunit.Text = "3";
            }

            //MATH 4th year / 1st sem
            else if (comboxsubcode.Text == "FS1" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Field Study 1 (In-campus)";
                txnumunit.Text = "3";
            }

            else if (comboxsubcode.Text == "FS2" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Field Study 2 (In-campus)";
                txnumunit.Text = "3";
            }

            //MATH 4th year  / 2nd sem
            else if (comboxsubcode.Text == "TI" && comboxcourse.Text == "BSED MATH")
            {
                txsubdesc.Text = "Teaching Internship  (Off-campus)";
                txnumunit.Text = "6";
            }

        }


        private void comboxsubcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            subcode();
        }

        private void cbcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Code();
        }

        private void cbyearlvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Code();
        }

        private void cbsem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Code();
        }

        private void txsubdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txnumunit_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
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
