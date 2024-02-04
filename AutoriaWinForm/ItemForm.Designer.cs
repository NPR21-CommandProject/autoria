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
            button1 = new Button();
            lbCarName = new Label();
            btnRightImage = new Button();
            lbPrice = new Label();
            lbOdometer = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbCarImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pbCarImage
            // 
            pbCarImage.BackColor = SystemColors.ControlDark;
            pbCarImage.Location = new Point(509, 99);
            pbCarImage.Name = "pbCarImage";
            pbCarImage.Size = new Size(841, 390);
            pbCarImage.TabIndex = 0;
            pbCarImage.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(1239, 441);
            button1.Name = "button1";
            button1.Size = new Size(48, 37);
            button1.TabIndex = 1;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.BackColor = SystemColors.ControlText;
            lbCarName.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbCarName.ForeColor = SystemColors.ControlLightLight;
            lbCarName.Location = new Point(62, 21);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(704, 40);
            lbCarName.TabIndex = 2;
            lbCarName.Text = "Audi S8/ 2007/ D3/ 5.2 FSI Tiptronic (450 к.с.) Quattro";
            // 
            // btnRightImage
            // 
            btnRightImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRightImage.Location = new Point(1293, 441);
            btnRightImage.Name = "btnRightImage";
            btnRightImage.Size = new Size(48, 37);
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
            lbPrice.Location = new Point(1200, 21);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(150, 47);
            lbPrice.TabIndex = 4;
            lbPrice.Text = "12 800$";
            // 
            // lbOdometer
            // 
            lbOdometer.AutoSize = true;
            lbOdometer.BackColor = SystemColors.ControlText;
            lbOdometer.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbOdometer.ForeColor = SystemColors.ControlLightLight;
            lbOdometer.Location = new Point(62, 61);
            lbOdometer.Name = "lbOdometer";
            lbOdometer.Size = new Size(105, 25);
            lbOdometer.TabIndex = 5;
            lbOdometer.Text = "282 th. km";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(62, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlText;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(157, 122);
            label4.Name = "label4";
            label4.Size = new Size(207, 37);
            label4.TabIndex = 7;
            label4.Text = "НеПерекуп 777";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlText;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(157, 168);
            label5.Name = "label5";
            label5.Size = new Size(147, 30);
            label5.TabIndex = 8;
            label5.Text = "(097) 777 7777";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlDark;
            textBox1.Location = new Point(509, 522);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(841, 85);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2024_01_27_16_46_561;
            ClientSize = new Size(1421, 619);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(lbOdometer);
            Controls.Add(lbPrice);
            Controls.Add(btnRightImage);
            Controls.Add(lbCarName);
            Controls.Add(button1);
            Controls.Add(pbCarImage);
            Name = "ItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemForm";
            ((System.ComponentModel.ISupportInitialize)pbCarImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCarImage;
        private Button button1;
        private Label lbCarName;
        private Button btnRightImage;
        private Label lbPrice;
        private Label lbOdometer;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
    }
}