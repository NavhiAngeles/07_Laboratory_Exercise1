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

            DGVList.DataSource = clubRegistrationQuery.bindingSource;
        }
        private void FrmClubRegistration_Load_1(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }
        public int Registration()
        {
            count += 1;
            return count;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           ID = Registration();
           StudentId = long.Parse(studIDtxt.Text);
            LastName = LastNametxt.Text;
            FirstName = FirstNametxt.Text;
            MiddleName = MiddleNametxt.Text;
            Age = int.Parse(Agetxt.Text);
            Program = ProgcomboBox.Text;
            Gender = gendercomboBox.Text;
            clubRegistrationquery.RegisterStudent(ID, StudentId, LastName, FirstName,MiddleName,Age, Program, Gender);

            RefreshListOfClubMembers();

        }

    }
}
