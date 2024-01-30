namespace AutoriaWinForm
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnLogin = new Button();
            label1 = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            pbTiger = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbTiger).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaptionText;
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.ForeColor = Color.White;
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            txtEmail.ForeColor = SystemColors.ScrollBar;
            txtEmail.Name = "txtEmail";
            txtEmail.UseSystemPasswordChar = true;
            txtEmail.Click += textBox1_Click;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // txtPass
            // 
            resources.ApplyResources(txtPass, "txtPass");
            txtPass.ForeColor = SystemColors.ScrollBar;
            txtPass.Name = "txtPass";
            txtPass.Click += txtPass_Click_1;
            txtPass.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // pbTiger
            // 
            resources.ApplyResources(pbTiger, "pbTiger");
            pbTiger.Name = "pbTiger";
            pbTiger.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(pbTiger);
            Controls.Add(label2);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbTiger).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private Label label1;
        private TextBox txtEmail;
        public TextBox txtPass;
        private Label label2;
        private PictureBox pbTiger;
        private Button button1;
    }
}