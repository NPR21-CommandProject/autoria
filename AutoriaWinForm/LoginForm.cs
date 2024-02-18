﻿using MySql.Data.MySqlClient;
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
        private class TextBoxState
        {
            public string Text { get; set; }
            public Color BackColor { get; set; }
            public Color ForeColor { get; set; }
        }

        private TextBoxState previousValue;


        public LoginForm()
        {
            InitializeComponent();

            previousValue = new TextBoxState
            {
                Text = txtEmail.Text,
                BackColor = txtEmail.BackColor,
                ForeColor = txtEmail.ForeColor
            };

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
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String loginUser = txtEmail.Text;
            String passUser = txtPass.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Yes");
            else
                MessageBox.Show("No");
        }
    }
}
