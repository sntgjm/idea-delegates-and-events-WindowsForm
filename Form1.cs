using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sntgjm
namespace AccountRegistration
{
    public delegate long DelegateNumber(long number);
    public delegate string DelegateText(string text);
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            StudentInfoClass.Program = comboBox1.Text.ToString();
            StudentInfoClass.LastName = textBox2.Text.ToString();
            StudentInfoClass.FirstName = textBox3.Text.ToString();
            StudentInfoClass.MiddleName = textBox4.Text.ToString();
            StudentInfoClass.Address = textBox7.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt64(textBox5.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(textBox6.Text);
            StudentInfoClass.StudentNo = Convert.ToInt64(textBox1.Text);

            if (form2.ShowDialog() == DialogResult.OK)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                comboBox1.Text = "";
            }
        }
    }
    class StudentInfoClass
    {
        public static string FirstName = "";
        public static string LastName = "";
        public static string MiddleName = "";
        public static string Address = "";
        public static string Program = "";
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public static string GetFirstName(string FirstName)
        {
            return FirstName;
        }
        public static string GetLastName(string LastName)
        {
            return LastName;
        }
        public static string GetMiddleName(string MiddleName)
        {
            return MiddleName;
        }
        public static string GetAddress(string Address)
        {
            return Address;
        }
        public static string GetProgram(string Program)
        {
            return Program;
        }
        public static long GetAge(long Age)
        {
            return Age;
        }
        public static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }
        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }
    }
}
