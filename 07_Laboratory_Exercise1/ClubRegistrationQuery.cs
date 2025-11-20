using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace _07_Laboratory_Exercise1
{
    internal class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;
        public DataTable dataTable;
        public BindingSource bindingSource;
        private string connectionString;
        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;
        public long _StudentId;

        public ClubRegistrationQuery()
        {
            connectionString = @"Data Source=DESKTOP-1S9DCFG\SQLEXPRESS01;Initial Catalog=ClubDB;
                                Integrated Security=True;Trust Server Certificate=True";

            sqlConnect = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand();
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public bool DisplayList()
        {
            try
            {
                string ViewClubMembers = "SELECT StudentID, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";
                sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);
                dataTable.Clear();
                sqlAdapter.Fill(dataTable);
                bindingSource.DataSource = dataTable;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying list: {ex.Message}");
                return false;
            }
        }

        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Program, string Gender)
        {
            try
            {
                sqlCommand = new SqlCommand("INSERT INTO ClubMembers (ID, StudentID, FirstName, MiddleName, LastName, Age, Program, Gender) VALUES (@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Program, @Gender)", sqlConnect);

                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;
                sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;

                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering student: {ex.Message}");
                return false;
            }
        }

        public DataTable GetStudentIDs()
        {
            try
            {
                string query = "SELECT StudentID FROM ClubMembers ORDER BY StudentID";
                sqlAdapter = new SqlDataAdapter(query, sqlConnect);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student IDs: {ex.Message}");
                return new DataTable();
            }
        }

        public DataTable GetStudentByID(long studentId)
        {
            try
            {
                string query = "SELECT StudentID, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers WHERE StudentID = @StudentID";
                sqlCommand = new SqlCommand(query, sqlConnect);
                sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = studentId;

                sqlAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student data: {ex.Message}");
                return new DataTable();
            }
        }

        public bool UpdateStudent(long studentId, string firstName, string middleName, string lastName, int age, string gender, string program)
        {
            try
            {
                sqlCommand = new SqlCommand("UPDATE ClubMembers SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Age = @Age, Gender = @Gender, Program = @Program WHERE StudentID = @StudentID", sqlConnect);

                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = studentId;
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = firstName;
                sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = middleName;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = lastName;
                sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = age;
                sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = gender;
                sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = program;

                sqlConnect.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}");
                return false;
            }

        }
    }
}