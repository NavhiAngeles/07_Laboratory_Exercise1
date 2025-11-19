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

    }
}