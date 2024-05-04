using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FastDayCareManagment
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Retrieve the email and password from the textboxes
            string email = textBox1.Text;
            string password = textBox2.Text;

            // Instantiate the LoginController
            LoginController loginController = new LoginController();

            // Get the role of the user
            string role = loginController.GetUserRole(email, password);

            // Check the role and navigate accordingly
            switch (role)
            {
                case "Admin":
                    // Navigate to admin panel
                    AdminController adminController = new AdminController();
                    adminController.LogLogin(email);
                    AdminDashboard1 adminDashboard = new AdminDashboard1();
                    adminDashboard.Show();
                    this.Hide(); // Hide the current login form
                    break;
                case "Staff":
                    // Navigate to staff panel
                    //StaffDashboard staffDashboard = new StaffDashboard();
                    //staffDashboard.Show();
                    //this.Hide(); // Hide the current login form
                    break;
                case "Parent":
                    // Navigate to parent panel
                    //send message of successful login
                    MessageBox.Show("Login Successful");
                    //ParentDashboard parentDashboard = new ParentDashboard();
                    //parentDashboard.Show();
                    //this.Hide(); // Hide the current login form
                    break;
                default:
                    // Handle invalid credentials
                    MessageBox.Show("Invalid email or password. Please try again.");
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}