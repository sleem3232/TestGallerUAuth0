using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestGallerUAuth0
{
    public partial class Form1 : Form
    {
        private readonly string Email = "sleem1234@gmail.com";
        private readonly string pass = "Test1234567!!!";

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FindElemnts findElemnts = new FindElemnts();
            findElemnts.SignUp(Email, pass);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string uncorrectName = Email.Replace("@", "");
            FindElemnts findElemnts = new FindElemnts();
            findElemnts.SignUp(uncorrectName, pass);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string uncorrectPass = pass.Replace("Test", "r");
            FindElemnts findElemnts = new FindElemnts();
            findElemnts.SignUp(Email, uncorrectPass);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            FindElemnts findElemnts = new FindElemnts();
            findElemnts.Login(Email, pass);
        }

    }
}