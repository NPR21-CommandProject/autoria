namespace AutoriaWinForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            NameSurnameTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            PasswordTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            RegistrationButton = new Button();
            AlreadyRegisterdButton = new Button();
            CancelButton = new Button();
            tbSurname = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(566, 41);
            label1.TabIndex = 0;
            label1.Text = "Registration on the \"Tiger auto\" website";
            // 
            // NameSurnameTextBox
            // 
            NameSurnameTextBox.Cursor = Cursors.IBeam;
            NameSurnameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameSurnameTextBox.ForeColor = SystemColors.ScrollBar;
            NameSurnameTextBox.Location = new Point(275, 75);
            NameSurnameTextBox.Multiline = true;
            NameSurnameTextBox.Name = "NameSurnameTextBox";
            NameSurnameTextBox.Size = new Size(267, 34);
            NameSurnameTextBox.TabIndex = 1;
            NameSurnameTextBox.Text = "Name";
            NameSurnameTextBox.Click += NameSurnameTextBox_Click;
            NameSurnameTextBox.TextChanged += NameSurnameTextBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(190, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(190, 184);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Cursor = Cursors.IBeam;
            PasswordTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PasswordTextBox.ForeColor = SystemColors.ScrollBar;
            PasswordTextBox.Location = new Point(275, 197);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(267, 34);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.Text = "Password";
            PasswordTextBox.Click += PasswordTextBox_Click;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Cursor = Cursors.IBeam;
            EmailTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EmailTextBox.ForeColor = SystemColors.ScrollBar;
            EmailTextBox.Location = new Point(275, 259);
            EmailTextBox.Multiline = true;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(267, 34);
            EmailTextBox.TabIndex = 5;
            EmailTextBox.Text = "Email";
            EmailTextBox.Click += EmailTextBox_Click;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Cursor = Cursors.IBeam;
            PhoneTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PhoneTextBox.ForeColor = SystemColors.ScrollBar;
            PhoneTextBox.Location = new Point(275, 334);
            PhoneTextBox.Multiline = true;
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(267, 34);
            PhoneTextBox.TabIndex = 6;
            PhoneTextBox.Text = "Phone numner";
            PhoneTextBox.Click += PhoneTextBox_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(190, 334);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(190, 259);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // RegistrationButton
            // 
            RegistrationButton.Cursor = Cursors.Hand;
            RegistrationButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegistrationButton.ForeColor = Color.FromArgb(0, 192, 0);
            RegistrationButton.Location = new Point(149, 446);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(155, 44);
            RegistrationButton.TabIndex = 9;
            RegistrationButton.Text = "Sign Up";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // AlreadyRegisterdButton
            // 
            AlreadyRegisterdButton.Cursor = Cursors.Hand;
            AlreadyRegisterdButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AlreadyRegisterdButton.ForeColor = Color.Black;
            AlreadyRegisterdButton.Location = new Point(301, 517);
            AlreadyRegisterdButton.Name = "AlreadyRegisterdButton";
            AlreadyRegisterdButton.Size = new Size(188, 44);
            AlreadyRegisterdButton.TabIndex = 10;
            AlreadyRegisterdButton.Text = "Already Registerd?";
            AlreadyRegisterdButton.UseVisualStyleBackColor = true;
            AlreadyRegisterdButton.Click += AlreadyRegisterdButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CancelButton.ForeColor = Color.FromArgb(192, 0, 0);
            CancelButton.Location = new Point(485, 446);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(155, 44);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // tbSurname
            // 
            tbSurname.Cursor = Cursors.IBeam;
            tbSurname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbSurname.ForeColor = SystemColors.ScrollBar;
            tbSurname.Location = new Point(275, 130);
            tbSurname.Multiline = true;
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(267, 34);
            tbSurname.TabIndex = 12;
            tbSurname.Text = "Surname";
            tbSurname.Click += tbSurname_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 573);
            Controls.Add(tbSurname);
            Controls.Add(CancelButton);
            Controls.Add(AlreadyRegisterdButton);
            Controls.Add(RegistrationButton);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(PhoneTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(NameSurnameTextBox);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "RegistrationWindow";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameSurnameTextBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox PasswordTextBox;
        private TextBox EmailTextBox;
        private TextBox PhoneTextBox;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button RegistrationButton;
        private Button AlreadyRegisterdButton;
        private Button CancelButton;
        private TextBox tbSurname;
    }
}
