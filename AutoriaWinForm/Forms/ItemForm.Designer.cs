namespace AutoriaWinForm
{
    partial class ItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
            pbCarImage = new PictureBox();
            btRightClick = new Button();
            lbCarName = new Label();
            btnRightImage = new Button();
            lbPrice = new Label();
            lbOdometer = new Label();
            pictureBox2 = new PictureBox();
            lbUserName = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            lbUserSurnme = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCarImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pbCarImage
            // 
            pbCarImage.BackColor = SystemColors.ControlDark;
            pbCarImage.Location = new Point(582, 132);
            pbCarImage.Margin = new Padding(3, 4, 3, 4);
            pbCarImage.Name = "pbCarImage";
            pbCarImage.Size = new Size(961, 520);
            pbCarImage.TabIndex = 0;
            pbCarImage.TabStop = false;
            // 
            // btRightClick
            // 
            btRightClick.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btRightClick.Location = new Point(1416, 588);
            btRightClick.Margin = new Padding(3, 4, 3, 4);
            btRightClick.Name = "btRightClick";
            btRightClick.Size = new Size(55, 49);
            btRightClick.TabIndex = 1;
            btRightClick.Text = "←";
            btRightClick.UseVisualStyleBackColor = true;
            btRightClick.Click += button1_Click;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.BackColor = SystemColors.ControlText;
            lbCarName.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbCarName.ForeColor = SystemColors.ControlLightLight;
            lbCarName.Location = new Point(71, 28);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(899, 50);
            lbCarName.TabIndex = 2;
            lbCarName.Text = "Audi S8/ 2007/ D3/ 5.2 FSI Tiptronic (450 к.с.) Quattro";
            // 
            // btnRightImage
            // 
            btnRightImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRightImage.Location = new Point(1478, 588);
            btnRightImage.Margin = new Padding(3, 4, 3, 4);
            btnRightImage.Name = "btnRightImage";
            btnRightImage.Size = new Size(55, 49);
            btnRightImage.TabIndex = 3;
            btnRightImage.Text = "→";
            btnRightImage.UseVisualStyleBackColor = true;
            btnRightImage.Click += btnRightImage_Click;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.BackColor = SystemColors.ControlText;
            lbPrice.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbPrice.ForeColor = Color.Green;
            lbPrice.Location = new Point(1371, 28);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(187, 60);
            lbPrice.TabIndex = 4;
            lbPrice.Text = "12 800$";
            // 
            // lbOdometer
            // 
            lbOdometer.AutoSize = true;
            lbOdometer.BackColor = SystemColors.ControlText;
            lbOdometer.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbOdometer.ForeColor = SystemColors.ControlLightLight;
            lbOdometer.Location = new Point(71, 81);
            lbOdometer.Name = "lbOdometer";
            lbOdometer.Size = new Size(130, 32);
            lbOdometer.TabIndex = 5;
            lbOdometer.Text = "282 th. km";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 132);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = SystemColors.ControlText;
            lbUserName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbUserName.ForeColor = SystemColors.ControlLightLight;
            lbUserName.Location = new Point(138, 132);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(109, 46);
            lbUserName.TabIndex = 7;
            lbUserName.Text = "Name";
            lbUserName.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlText;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(37, 254);
            label5.Name = "label5";
            label5.Size = new Size(197, 37);
            label5.TabIndex = 8;
            label5.Text = "(097) 777 7777";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlDark;
            textBox1.Location = new Point(582, 696);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(961, 112);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lbUserSurnme
            // 
            lbUserSurnme.AutoSize = true;
            lbUserSurnme.BackColor = SystemColors.ControlText;
            lbUserSurnme.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbUserSurnme.ForeColor = SystemColors.ControlLightLight;
            lbUserSurnme.Location = new Point(121, 178);
            lbUserSurnme.Name = "lbUserSurnme";
            lbUserSurnme.Size = new Size(152, 46);
            lbUserSurnme.TabIndex = 10;
            lbUserSurnme.Text = "Surname";
            // 
            // ItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2024_01_27_16_46_561;
            ClientSize = new Size(1624, 989);
            Controls.Add(lbUserSurnme);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(lbUserName);
            Controls.Add(pictureBox2);
            Controls.Add(lbOdometer);
            Controls.Add(lbPrice);
            Controls.Add(btnRightImage);
            Controls.Add(lbCarName);
            Controls.Add(btRightClick);
            Controls.Add(pbCarImage);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemForm";
            Load += ItemForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbCarImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCarImage;
        private Button btRightClick;
        private Label lbCarName;
        private Button btnRightImage;
        private Label lbPrice;
        private Label lbOdometer;
        private PictureBox pictureBox2;
        private Label lbUserName;
        private Label label5;
        private TextBox textBox1;
        private Label lbUserSurnme;
    }
}