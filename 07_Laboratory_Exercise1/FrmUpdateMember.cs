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
            clubRegistrationQuery = new ClubRegistrationQuery();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            LoadStudentIDs();
            InitializeProgramComboBox();

            UPDGenderComboBox.Items.AddRange(new string[] { "Male", "Female" });
            ClearFields();
            /*Updatebtn.Enabled = false;*/
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
            try
            {
                DataTable studentData = clubRegistrationQuery.GetStudentIDs();
                StudIDcomboBox.Items.Clear();

                if (studentData.Rows.Count > 0)
                {
                    foreach (DataRow row in studentData.Rows)
                    {
                        StudIDcomboBox.Items.Add(row["StudentID"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No registered students found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student IDs: {ex.Message}");
            }
        }

        private void StudentIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudIDcomboBox.SelectedItem != null)
            {
                try
                {
                    long selectedStudentId = long.Parse(StudIDcomboBox.SelectedItem.ToString());
                    DataTable studentData = clubRegistrationQuery.GetStudentByID(selectedStudentId);

                    if (studentData.Rows.Count > 0)
                    {
                        DataRow row = studentData.Rows[0];
                        UPDFirst.Text = row["FirstName"].ToString();
                        UPDmid.Text = row["MiddleName"].ToString();
                        UPDLast.Text = row["LastName"].ToString();
                        UPDage.Text = row["Age"].ToString();
                        UPDGenderComboBox.SelectedItem = row["Gender"].ToString();
                        UPDprogramcomboBox.SelectedItem = row["Program"].ToString();

                    
                        /*Updatebtn.Enabled = true;*/
                    }
                    else
                    {
                        MessageBox.Show("Student data not found.");
                        ClearFields();
                        /*Updatebtn.Enabled = false;*/
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading student data: {ex.Message}");
                    ClearFields();
                    /*Updatebtn.Enabled = false;*/
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

            if (!int.TryParse(UPDage.Text, out int age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            try
            {
                long studentId = long.Parse(StudIDcomboBox.SelectedItem.ToString());
                string firstName = UPDFirst.Text;
                string middleName = UPDmid.Text;
                string lastName = UPDLast.Text;
                string gender = UPDGenderComboBox.SelectedItem.ToString();
                string program = UPDprogramcomboBox.SelectedItem.ToString();

                bool success = clubRegistrationQuery.UpdateStudent(studentId, firstName, middleName, lastName, age, gender, program);

                if (success)
                {
                    MessageBox.Show("Student information updated successfully!");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update student information.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            UPDFirst.Clear();
            UPDmid.Clear();
            UPDLast.Clear();
            UPDage.Clear();
            UPDGenderComboBox.SelectedIndex = -1;
            UPDprogramcomboBox.SelectedIndex = -1;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        
    }
