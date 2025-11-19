using System.Windows.Forms;

namespace _07_Laboratory_Exercise1
{
    public partial class FrmClubRegistration : Form
    {
        public FrmClubRegistration()
        {
            InitializeComponent();
        }
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName,MiddleName, LastName, Gender, Program;
        private long StudentId;

        ClubRegistrationQuery clubRegistrationquery = new ClubRegistrationQuery();

        public void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();

            dataGridView1.DataSource = clubRegistrationQuery.bindingSource;
        }
        private void FrmClubRegistration_Load_1(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }


    }
}
