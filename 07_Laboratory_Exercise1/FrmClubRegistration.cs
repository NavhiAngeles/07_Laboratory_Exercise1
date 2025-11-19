using System.Windows.Forms;

namespace _07_Laboratory_Exercise1
{
    public partial class FrmClubRegistration : Form
    {
        public FrmClubRegistration()
        {
            InitializeComponent();
            InitializeProgramComboBox();
        }

        private ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentID;

        private void InitializeProgramComboBox()
        {
            ProgcomboBox.Items.AddRange(new object[] {
                "BSIT",
                "BSCS",
                "BSHM",
                "BSIS",
                "BSBA",
                "BSA",
                "BSTM"
            });
            ProgcomboBox.SelectedIndex = 0;
            gendercomboBox.Items.AddRange(new object[] {
                "Male",
                "Female"
            });
            ProgcomboBox.SelectedIndex = 0;
        }

        private void RefreshListOfClubMembers()
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
            if (string.IsNullOrEmpty(studIDtxt.Text) ||
                string.IsNullOrEmpty(LastNametxt.Text) ||
                string.IsNullOrEmpty(FirstNametxt.Text) ||
                string.IsNullOrEmpty(Agetxt.Text) ||
                gendercomboBox.SelectedItem == null ||
                ProgcomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            ID = Registration();
            StudentID = long.Parse(studIDtxt.Text);
            FirstName = FirstNametxt.Text;
            MiddleName = MiddleNametxt.Text;
            LastName = LastNametxt.Text;
            Age = int.Parse(Agetxt.Text);
            Gender = gendercomboBox.SelectedItem.ToString();
            Program = ProgcomboBox.SelectedItem.ToString();

            clubRegistrationQuery.RegisterStudent(ID, StudentID, FirstName, MiddleName, LastName, Age, Gender, Program);

            MessageBox.Show("Student registered successfully!");
            ClearForm();

            RefreshListOfClubMembers();
        }
        private void ClearForm()
        {
            studIDtxt.Clear();
            LastNametxt.Clear();
            FirstNametxt.Clear();
            MiddleNametxt.Clear();
            Agetxt.Clear();
            gendercomboBox.SelectedIndex = -1;
            ProgcomboBox.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUpdateMember updateForm = new FrmUpdateMember();
            updateForm.ShowDialog();
            RefreshListOfClubMembers();
        }
    }
}