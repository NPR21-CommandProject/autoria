namespace AutoriaWinForm
{
    partial class MainPageForm
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
            vScrollBar1 = new VScrollBar();
            Exit_btn = new Button();
            Sell_btn = new Button();
            SearchTextBox = new TextBox();
            label1 = new Label();
            Type_comboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            Brand_comboBox = new ComboBox();
            label4 = new Label();
            Model_comboBox = new ComboBox();
            label5 = new Label();
            PriceFrom_textBox = new TextBox();
            PriceTo_textBox = new TextBox();
            Сurrency_comboBox = new ComboBox();
            MlgTo_textBox = new TextBox();
            MlgFrom_textBox = new TextBox();
            label6 = new Label();
            VlmTo_textBox = new TextBox();
            VlmFrom_textBox = new TextBox();
            label7 = new Label();
            dataGridView = new DataGridView();
            LoginBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1395, 9);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 601);
            vScrollBar1.TabIndex = 2;
            // 
            // Exit_btn
            // 
            Exit_btn.Location = new Point(1260, 9);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(132, 30);
            Exit_btn.TabIndex = 5;
            Exit_btn.Text = "Exit";
            Exit_btn.UseVisualStyleBackColor = true;
            Exit_btn.Click += Exit_btn_Click;
            // 
            // Sell_btn
            // 
            Sell_btn.Location = new Point(903, 9);
            Sell_btn.Name = "Sell_btn";
            Sell_btn.Size = new Size(288, 30);
            Sell_btn.TabIndex = 6;
            Sell_btn.Text = "Sell car";
            Sell_btn.UseVisualStyleBackColor = true;
            Sell_btn.Click += Sell_btn_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(470, 9);
            SearchTextBox.Multiline = true;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(361, 30);
            SearchTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(345, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 8;
            label1.Text = "Car search";
            label1.Click += label1_Click;
            // 
            // Type_comboBox
            // 
            Type_comboBox.Font = new Font("Segoe UI", 12F);
            Type_comboBox.ForeColor = SystemColors.WindowFrame;
            Type_comboBox.FormattingEnabled = true;
            Type_comboBox.Items.AddRange(new object[] { "Легкові", "Мото", "Вантажівки", "Причепи", "Спецтехніка", "Сільгосптехніка", "Автобуси", "Водний транспорт", "Повітряний транспорт", "Автобудинки" });
            Type_comboBox.Location = new Point(12, 141);
            Type_comboBox.Name = "Type_comboBox";
            Type_comboBox.Size = new Size(217, 29);
            Type_comboBox.TabIndex = 9;
            Type_comboBox.Text = "All types of transport";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 10;
            label2.Text = "Type of transport";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 177);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 12;
            label3.Text = "Brand";
            // 
            // Brand_comboBox
            // 
            Brand_comboBox.Font = new Font("Segoe UI", 12F);
            Brand_comboBox.ForeColor = SystemColors.WindowFrame;
            Brand_comboBox.FormattingEnabled = true;
            Brand_comboBox.Location = new Point(12, 201);
            Brand_comboBox.Name = "Brand_comboBox";
            Brand_comboBox.Size = new Size(217, 29);
            Brand_comboBox.TabIndex = 11;
            Brand_comboBox.Text = "Choose";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 240);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 14;
            label4.Text = "Model";
            // 
            // Model_comboBox
            // 
            Model_comboBox.Font = new Font("Segoe UI", 12F);
            Model_comboBox.ForeColor = SystemColors.WindowFrame;
            Model_comboBox.FormattingEnabled = true;
            Model_comboBox.Location = new Point(12, 264);
            Model_comboBox.Name = "Model_comboBox";
            Model_comboBox.Size = new Size(217, 29);
            Model_comboBox.TabIndex = 13;
            Model_comboBox.Text = "Choose";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 303);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 15;
            label5.Text = "Price";
            // 
            // PriceFrom_textBox
            // 
            PriceFrom_textBox.Font = new Font("Segoe UI", 12F);
            PriceFrom_textBox.ForeColor = SystemColors.WindowFrame;
            PriceFrom_textBox.Location = new Point(12, 327);
            PriceFrom_textBox.Name = "PriceFrom_textBox";
            PriceFrom_textBox.Size = new Size(70, 29);
            PriceFrom_textBox.TabIndex = 16;
            PriceFrom_textBox.Text = "from";
            // 
            // PriceTo_textBox
            // 
            PriceTo_textBox.Font = new Font("Segoe UI", 12F);
            PriceTo_textBox.ForeColor = SystemColors.WindowFrame;
            PriceTo_textBox.Location = new Point(88, 327);
            PriceTo_textBox.Name = "PriceTo_textBox";
            PriceTo_textBox.Size = new Size(70, 29);
            PriceTo_textBox.TabIndex = 17;
            PriceTo_textBox.Text = "to";
            // 
            // Сurrency_comboBox
            // 
            Сurrency_comboBox.Font = new Font("Segoe UI", 12F);
            Сurrency_comboBox.ForeColor = SystemColors.WindowText;
            Сurrency_comboBox.FormattingEnabled = true;
            Сurrency_comboBox.Items.AddRange(new object[] { "$", "€", "₴" });
            Сurrency_comboBox.Location = new Point(164, 327);
            Сurrency_comboBox.Name = "Сurrency_comboBox";
            Сurrency_comboBox.Size = new Size(65, 29);
            Сurrency_comboBox.TabIndex = 18;
            Сurrency_comboBox.Text = "$";
            // 
            // MlgTo_textBox
            // 
            MlgTo_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MlgTo_textBox.ForeColor = SystemColors.WindowFrame;
            MlgTo_textBox.Location = new Point(126, 392);
            MlgTo_textBox.Name = "MlgTo_textBox";
            MlgTo_textBox.Size = new Size(103, 29);
            MlgTo_textBox.TabIndex = 21;
            MlgTo_textBox.Text = "to";
            // 
            // MlgFrom_textBox
            // 
            MlgFrom_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MlgFrom_textBox.ForeColor = SystemColors.WindowFrame;
            MlgFrom_textBox.Location = new Point(12, 392);
            MlgFrom_textBox.Name = "MlgFrom_textBox";
            MlgFrom_textBox.Size = new Size(108, 29);
            MlgFrom_textBox.TabIndex = 20;
            MlgFrom_textBox.Text = "from";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(12, 368);
            label6.Name = "label6";
            label6.Size = new Size(181, 21);
            label6.TabIndex = 19;
            label6.Text = "Mileage (thousand km.)";
            // 
            // VlmTo_textBox
            // 
            VlmTo_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            VlmTo_textBox.ForeColor = SystemColors.WindowFrame;
            VlmTo_textBox.Location = new Point(126, 456);
            VlmTo_textBox.Name = "VlmTo_textBox";
            VlmTo_textBox.Size = new Size(103, 29);
            VlmTo_textBox.TabIndex = 24;
            VlmTo_textBox.Text = "to";
            // 
            // VlmFrom_textBox
            // 
            VlmFrom_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            VlmFrom_textBox.ForeColor = SystemColors.WindowFrame;
            VlmFrom_textBox.Location = new Point(12, 456);
            VlmFrom_textBox.Name = "VlmFrom_textBox";
            VlmFrom_textBox.Size = new Size(108, 29);
            VlmFrom_textBox.TabIndex = 23;
            VlmFrom_textBox.Text = "from";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(12, 432);
            label7.Name = "label7";
            label7.Size = new Size(139, 21);
            label7.TabIndex = 22;
            label7.Text = "Engine volume (l.)";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(314, 86);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(1050, 485);
            dataGridView.TabIndex = 25;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(26, 12);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(132, 30);
            LoginBtn.TabIndex = 26;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // MainPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            BackgroundImage = Properties.Resources.photo_2024_01_27_16_46_561;
            ClientSize = new Size(1421, 619);
            Controls.Add(LoginBtn);
            Controls.Add(dataGridView);
            Controls.Add(VlmTo_textBox);
            Controls.Add(VlmFrom_textBox);
            Controls.Add(label7);
            Controls.Add(MlgTo_textBox);
            Controls.Add(MlgFrom_textBox);
            Controls.Add(label6);
            Controls.Add(Сurrency_comboBox);
            Controls.Add(PriceTo_textBox);
            Controls.Add(PriceFrom_textBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Model_comboBox);
            Controls.Add(label3);
            Controls.Add(Brand_comboBox);
            Controls.Add(label2);
            Controls.Add(Type_comboBox);
            Controls.Add(label1);
            Controls.Add(SearchTextBox);
            Controls.Add(Sell_btn);
            Controls.Add(Exit_btn);
            Controls.Add(vScrollBar1);
            ForeColor = SystemColors.ControlText;
            Name = "MainPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private VScrollBar vScrollBar1;
        private Button Exit_btn;
        private Button Sell_btn;
        private TextBox SearchTextBox;
        private Label label1;
        private ComboBox Type_comboBox;
        private Label label2;
        private Label label3;
        private ComboBox Brand_comboBox;
        private Label label4;
        private ComboBox Model_comboBox;
        private Label label5;
        private TextBox PriceFrom_textBox;
        private TextBox PriceTo_textBox;
        private ComboBox Сurrency_comboBox;
        private TextBox MlgTo_textBox;
        private TextBox MlgFrom_textBox;
        private Label label6;
        private TextBox VlmTo_textBox;
        private TextBox VlmFrom_textBox;
        private Label label7;
        private DataGridView dataGridView;
        private Button LoginBtn;
    }
}
