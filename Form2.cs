using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sntgjm
namespace AccountRegistration
{
    public partial class Form2 : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        public Form2()
        {
            InitializeComponent();
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
            label1.Text = Convert.ToString(DelStudNo(StudentInfoClass.StudentNo));
            label6.Text = Convert.ToString(DelNumAge(StudentInfoClass.Age));
            label7.Text = Convert.ToString(DelNumContactNo(StudentInfoClass.ContactNo));
            label3.Text = DelLastName(StudentInfoClass.LastName);
            label4.Text = DelFirstName(StudentInfoClass.FirstName);
            label5.Text = DelMiddleName(StudentInfoClass.MiddleName);
            label8.Text = DelAddress(StudentInfoClass.Address);
            label2.Text = DelProgram(StudentInfoClass.Program);

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }

    }
}
