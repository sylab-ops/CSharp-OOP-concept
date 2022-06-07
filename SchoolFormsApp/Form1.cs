using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
         
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnPushToTest_Click(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.Name = txtSchoolName.Text;
            testSchool.SchoolAddress = txtAddress.Text;
            testSchool.PhoneNumber = txtPhoneNumber.Text;
            testSchool.City = txtCity.Text;
            testSchool.Zip = txtZip.Text;
            testSchool.State = txtState.Text;
            testSchool.TwitterAddress = txtTwitterAddress.Text;
            try
            {
                testSchool.TwitterAddress = txtTwitterAddress.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            MessageBox.Show(testSchool.ToString());

            var student = new Students(); // for testing only  - Remove later
        

        }

        private void btnTestStudent_Click(object sender, EventArgs e)
        {
            var student = new Students();
            var gp = student.ComputeGradeAvg();
            MessageBox.Show("The student grade average is: " + gp);
        }

        private void btnTestTeacher_Click(object sender, EventArgs e)
        {
            var teacher = new Teachers();
            var gp = teacher.ComputeGradeAvg();
            MessageBox.Show("The teacher grade average is: " + gp);
        }
    }
}
