namespace AccountRegistration
{
    public partial class frmRegistration : Form
    {
        DelegateNumber delegateNum;
        DelegateText delegateTxt;
        public frmRegistration()
        {
            InitializeComponent();

            delegateTxt = new DelegateText(StudentInfoClass.GetLastName);
            delegateTxt = new DelegateText(StudentInfoClass.GetFirstName);
            delegateTxt = new DelegateText(StudentInfoClass.GetMiddleName);
            delegateTxt = new DelegateText(StudentInfoClass.GetAddress);
            delegateTxt = new DelegateText(StudentInfoClass.GetProgram);
            delegateNum = new DelegateNumber(StudentInfoClass.GetAge);
            delegateNum = new DelegateNumber(StudentInfoClass.GetContactNo);
            delegateNum = new DelegateNumber(StudentInfoClass.GetStudentNo);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.LastName = txtLastname.Text.ToString();
            StudentInfoClass.FirstName = txtFirstname.Text.ToString();
            StudentInfoClass.MiddleName = txtMiddlename.Text.ToString();
            StudentInfoClass.Address = txtAddress.Text.ToString();
            StudentInfoClass.Program = comboProg.Text.ToString();
            StudentInfoClass.Age = long.Parse(txtAge.Text.ToString());
            StudentInfoClass.ContactNo = long.Parse(txtContact.Text.ToString());
            StudentInfoClass.StudentNo = long.Parse(txtStudNo.Text.ToString());
            
            frmConfirm confirmForm = new frmConfirm();
            DialogResult result = confirmForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtLastname.Text = "";
                txtFirstname.Text = "";
                txtMiddlename.Text = "";
                txtAddress.Text = "";
                comboProg.SelectedIndex = -1;
                txtAge.Text = "";
                txtContact.Text = "";
                txtStudNo.Text = "";
            };

        }
    }
}