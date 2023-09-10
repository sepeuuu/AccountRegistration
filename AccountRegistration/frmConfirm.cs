using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class frmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelContactNo, DelStudNo;
        public frmConfirm()
        {
            InitializeComponent();

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);



        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            lblStudno.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            lblProg.Text = DelProgram(StudentInfoClass.Program);
            lblLastname.Text = DelLastName(StudentInfoClass.LastName);
            lblFirstname.Text = DelFirstName(StudentInfoClass.FirstName);
            lblMiddlename.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblContact.Text = DelContactNo(StudentInfoClass.ContactNo).ToString();
            lblAddress.Text = DelAddress.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
