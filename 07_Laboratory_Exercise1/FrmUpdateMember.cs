using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Laboratory_Exercise1
{
    public partial class FrmUpdateMember : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;

        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            LoadStudentIDs();
            InitializeProgramComboBox();

            UPDGenderComboBox.Items.AddRange(new string[] { "Male", "Female"});
        }

        private void InitializeProgramComboBox()
        {
            UPDprogramcomboBox.Items.AddRange(new object[] {
                "BSIT",
                "BSCS",
                "BSHM",
                "BSIS",
                "BSBA",
                "BSA",
                "BSTM"
            });
        }

        private void LoadStudentIDs()
        {
            DataTable StudidData = clubRegistrationQuery.RegisterStudent();
            StudIDcomboBox.Items.Clear();

            foreach (DataRow row in StudidData.Rows)
            {
                StudIDcomboBox.Items.Add(row["StudentId"].ToString());
            }
        }

        private void StudentIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudIDcomboBox.SelectedItem != null)
            {
                long selectedStudentId = long.Parse(StudIDcomboBox.SelectedItem.ToString());
                DataTable studentData = clubRegistrationQuery.RegisterStudent(selectedStudentId);

                if (studentData.Rows.Count > 0)
                {
                    DataRow row = studentData.Rows[0];
                    UPDFirst.Text = row["FirstName"].ToString();
                    UPDmid.Text = row["MiddleName"].ToString();
                    UPDLast.Text = row["LastName"].ToString();
                    UPDage.Text = row["Age"].ToString();
                    UPDGenderComboBox.Text = row["Gender"].ToString();
                    UPDprogramcomboBox.Text = row["Program"].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StudIDcomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a Student ID first.");
                return;
            }

            if (string.IsNullOrEmpty(UPDFirst.Text) ||
                string.IsNullOrEmpty(UPDLast.Text) ||
                string.IsNullOrEmpty(UPDage.Text) ||
                UPDGenderComboBox.SelectedItem == null ||
                UPDprogramcomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            long studentId = long.Parse(StudIDcomboBox.SelectedItem.ToString());
            string firstName = UPDFirst.Text;
            string middleName = UPDmid.Text;
            string lastName = UPDLast.Text;
            int age = int.Parse(UPDage.Text);
            string gender = UPDGenderComboBox.SelectedItem.ToString();
            string program = UPDprogramcomboBox.SelectedItem.ToString();

            clubRegistrationQuery.RegisterStudent(studentId, firstName, middleName, lastName, age, gender, program);

            MessageBox.Show("Student information updated successfully!");
            this.Close();
        }

        
    }
}