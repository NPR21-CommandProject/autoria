using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace AutoriaWinForm
{
    public partial class LoginForm : Form
    {
       
        public MainForm registerForm = new MainForm();

        public LoginForm()
        {
            InitializeComponent();

           
        }

        private void lbPass_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;

            // TextBox clickedTextBox = (TextBox)sender;

            // TextBoxState currentTxt = new TextBoxState
            // {
            //     Text = clickedTextBox.Text,
            //     BackColor = clickedTextBox.BackColor,
            //     ForeColor = clickedTextBox.ForeColor
            // };
            //if (clickedTextBox == txtEmail)
            // {
            //     //RestoreTxt(txtPass, previousValue);
            //     //previousValue = currentTxt;

            // }
            //else if (clickedTextBox == txtPass)
            // {
            //     //RestoreTxt(txtEmail, previousValue);
            //     //previousValue = currentTxt;
            // }
        }
        private void RestoreTxt(TextBox textBox)
        {
            //textBox.Text = string.Empty;
            //textBox.BackColor = txtState.BackColor;
            //textBox.ForeColor = txtState.ForeColor;
        }

        private void txtPass_Click_1(object sender, EventArgs e)
        {

            txtPass.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm.ShowDialog();
        }
    }
}
