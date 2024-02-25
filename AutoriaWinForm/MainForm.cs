using AutoriaWinForm.Data;
using AutoriaWinForm.Data.Entities;
using AutoriaWinForm.Forms;

namespace AutoriaWinForm
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            //UserEntity kot = new UserEntity
            //{
            //    FirstName = "Котик",
            //    LastName = "Рижикт",
            //    Email = "kotyk@gmail.com",
            //    Password = "123456",
            //    DateCreated = DateTime.Now,
            //    Phone = "+380 97 638 87 34"
            //};
            //AutoriaContext context = new AutoriaContext();
            //context.Users.Add(kot);
            //context.SaveChanges();
        }
        //public LoginForm loginForm = new LoginForm();

        private void MainForm_Load(object sender, EventArgs e)
        {
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlreadyRegisterdButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Hide();
            loginForm.ShowDialog();


        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            UserEntity user = new UserEntity
            {
                FirstName = NameSurnameTextBox.Text,
                LastName = tbSurname.Text,
                Email = EmailTextBox.Text,
                Password = PasswordTextBox.Text,
                DateCreated = DateTime.Now,
                Phone = PhoneTextBox.Text

            };
            AutoriaContext context = new AutoriaContext();
            context.Users.Add(user);
            context.SaveChanges();
            this.Hide();
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void NameSurnameTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void NameSurnameTextBox_Click(object sender, EventArgs e)
        {
            NameSurnameTextBox.Text = string.Empty;
        }

        private void tbSurname_Click(object sender, EventArgs e)
        {
            tbSurname.Text = string.Empty;
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = string.Empty;
        }

        private void EmailTextBox_Click(object sender, EventArgs e)
        {
            EmailTextBox.Text = string.Empty;

        }

        private void PhoneTextBox_Click(object sender, EventArgs e)
        {
            PhoneTextBox.Text = string.Empty;
        }
        //..
    }
}
//