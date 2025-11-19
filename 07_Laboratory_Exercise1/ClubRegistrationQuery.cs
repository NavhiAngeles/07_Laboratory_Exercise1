using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;

namespace _07_Laboratory_Exercise1
{
    internal  class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;

        public DataTable dataTable;
        public BindingSource bindingSource;

        private string connectionString; 

        public string _FirstName, _MiddleName,_LastName,_Gender,_Program;
        public int _Age;

        public ClubRegistrationQuery()
        {
               
        }
    }
}
