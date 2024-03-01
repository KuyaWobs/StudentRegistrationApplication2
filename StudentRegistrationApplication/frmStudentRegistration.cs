using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string First_Name = FirstName.Text;
            string Last_Name = LastName.Text;
            string Middle_Name = MiddleName.Text;
            string gender;

            if (Male.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = " Female ";

            }

            MessageBox.Show("Student Name: " + First_Name + " " + Middle_Name + " " + Last_Name + "\n" +
                "Gender: " + gender + "\n" +
                "Date of birth: " + Day.Text + "/" + Month.Text + "/" + Year.Text +"\n" +
                "Program: " + Course.Text);


        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 31; i++)
            {

                Day.Items.Add(i);
            }
            string[] MonthName = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            for (int i = 0; i < 12; i++)
            {

                Month.Items.Add(MonthName[i]);
            }

            for (int i = 1900; i <= 2024; i++)
            {

                Year.Items.Add(i);
            }


           ArrayList course = new ArrayList();
            course.Add("Bachelor of Science in Computer Science");
            course.Add("Bachelor of Science in Information Technology");
            course.Add("Bachelor of Science in Information Systems");
            course.Add("Bachelor of Science in Computer Engineering");

            for (int i = 0; i < 4; i++)
            {
                Course.Items.Add(course[i]);

            }

        }

    }
}

