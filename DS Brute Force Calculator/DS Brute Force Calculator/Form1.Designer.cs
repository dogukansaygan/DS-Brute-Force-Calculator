namespace DS_Brute_Force_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PassLbl = new Label();
            PassTxtBx = new TextBox();
            LentghLbl = new Label();
            VarietyLbl = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            CalculateBtn = new Button();
            label4 = new Label();
            TimeTxt = new Label();
            Md5Rd = new RadioButton();
            label2 = new Label();
            panel2 = new Panel();
            CharsTxtBx = new TextBox();
            CharsLbl = new Label();
            ResetBtn = new Button();
            MethodsGrpBx = new GroupBox();
            Sha256Rd = new RadioButton();
            ModesGrpBx = new GroupBox();
            Mode1Rd = new RadioButton();
            NumberofOperationsLbl = new Label();
            NumberofOperations = new NumericUpDown();
            label6 = new Label();
            LangBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            MethodsGrpBx.SuspendLayout();
            ModesGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumberofOperations).BeginInit();
            SuspendLayout();
            // 
            // PassLbl
            // 
            PassLbl.AutoSize = true;
            PassLbl.BackColor = Color.Transparent;
            PassLbl.ForeColor = Color.White;
            PassLbl.Location = new Point(101, 180);
            PassLbl.Name = "PassLbl";
            PassLbl.Size = new Size(73, 20);
            PassLbl.TabIndex = 0;
            PassLbl.Text = "Password:";
            // 
            // PassTxtBx
            // 
            PassTxtBx.BackColor = Color.White;
            PassTxtBx.BorderStyle = BorderStyle.None;
            PassTxtBx.Location = new Point(8, 7);
            PassTxtBx.Name = "PassTxtBx";
            PassTxtBx.Size = new Size(236, 20);
            PassTxtBx.TabIndex = 1;
            PassTxtBx.TextChanged += PassTxtBx_TextChanged;
            // 
            // LentghLbl
            // 
            LentghLbl.AutoSize = true;
            LentghLbl.BackColor = Color.Transparent;
            LentghLbl.ForeColor = Color.White;
            LentghLbl.Location = new Point(102, 351);
            LentghLbl.Name = "LentghLbl";
            LentghLbl.Size = new Size(57, 20);
            LentghLbl.TabIndex = 2;
            LentghLbl.Text = "Lentgh:";
            // 
            // VarietyLbl
            // 
            VarietyLbl.AutoSize = true;
            VarietyLbl.BackColor = Color.Transparent;
            VarietyLbl.ForeColor = Color.White;
            VarietyLbl.Location = new Point(102, 316);
            VarietyLbl.Name = "VarietyLbl";
            VarietyLbl.Size = new Size(123, 20);
            VarietyLbl.TabIndex = 4;
            VarietyLbl.Text = "Character variety:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(PassTxtBx);
            panel1.Location = new Point(180, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 33);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(207, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // CalculateBtn
            // 
            CalculateBtn.Location = new Point(106, 520);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(237, 35);
            CalculateBtn.TabIndex = 8;
            CalculateBtn.Text = "Calculate the estimated time";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 620);
            label4.Name = "label4";
            label4.Size = new Size(132, 19);
            label4.TabIndex = 9;
            label4.Text = "By Doğukan Sayğan";
            // 
            // TimeTxt
            // 
            TimeTxt.AutoSize = true;
            TimeTxt.BackColor = Color.Transparent;
            TimeTxt.ForeColor = Color.White;
            TimeTxt.Location = new Point(103, 568);
            TimeTxt.Name = "TimeTxt";
            TimeTxt.Size = new Size(260, 20);
            TimeTxt.TabIndex = 10;
            TimeTxt.Text = "Estimated time to crack the password:";
            // 
            // Md5Rd
            // 
            Md5Rd.AutoSize = true;
            Md5Rd.BackColor = Color.Transparent;
            Md5Rd.Checked = true;
            Md5Rd.ForeColor = Color.White;
            Md5Rd.Location = new Point(19, 29);
            Md5Rd.Name = "Md5Rd";
            Md5Rd.Size = new Size(62, 24);
            Md5Rd.TabIndex = 11;
            Md5Rd.TabStop = true;
            Md5Rd.Text = "MD5";
            Md5Rd.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(176, 135);
            label2.Name = "label2";
            label2.Size = new Size(197, 19);
            label2.TabIndex = 13;
            label2.Text = "DS Brute Force Calculator V1.0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(CharsTxtBx);
            panel2.Location = new Point(180, 217);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 33);
            panel2.TabIndex = 15;
            // 
            // CharsTxtBx
            // 
            CharsTxtBx.BackColor = Color.White;
            CharsTxtBx.BorderStyle = BorderStyle.None;
            CharsTxtBx.Location = new Point(7, 7);
            CharsTxtBx.Name = "CharsTxtBx";
            CharsTxtBx.Size = new Size(236, 20);
            CharsTxtBx.TabIndex = 1;
            CharsTxtBx.Text = "abcçdefgğhıijklmnoöprsştuüvyz0123456789!'^+%&/()=?_-\\][$#£>\"é*@{},.:;`|<>~ABCÇDEFGĞHIİJKLMNOÖPRSŞTUUÜVYZ";
            // 
            // CharsLbl
            // 
            CharsLbl.AutoSize = true;
            CharsLbl.BackColor = Color.Transparent;
            CharsLbl.ForeColor = Color.White;
            CharsLbl.Location = new Point(101, 224);
            CharsLbl.Name = "CharsLbl";
            CharsLbl.Size = new Size(48, 20);
            CharsLbl.TabIndex = 14;
            CharsLbl.Text = "Chars:";
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(350, 520);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(85, 35);
            ResetBtn.TabIndex = 18;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // MethodsGrpBx
            // 
            MethodsGrpBx.BackColor = Color.Transparent;
            MethodsGrpBx.Controls.Add(Sha256Rd);
            MethodsGrpBx.Controls.Add(Md5Rd);
            MethodsGrpBx.ForeColor = Color.White;
            MethodsGrpBx.Location = new Point(105, 352);
            MethodsGrpBx.Name = "MethodsGrpBx";
            MethodsGrpBx.Size = new Size(327, 69);
            MethodsGrpBx.TabIndex = 19;
            MethodsGrpBx.TabStop = false;
            MethodsGrpBx.Text = "Methods";
            // 
            // Sha256Rd
            // 
            Sha256Rd.AutoSize = true;
            Sha256Rd.BackColor = Color.Transparent;
            Sha256Rd.ForeColor = Color.White;
            Sha256Rd.Location = new Point(87, 29);
            Sha256Rd.Name = "Sha256Rd";
            Sha256Rd.Size = new Size(83, 24);
            Sha256Rd.TabIndex = 12;
            Sha256Rd.Text = "SHA256";
            Sha256Rd.UseVisualStyleBackColor = false;
            // 
            // ModesGrpBx
            // 
            ModesGrpBx.BackColor = Color.Transparent;
            ModesGrpBx.Controls.Add(Mode1Rd);
            ModesGrpBx.ForeColor = Color.White;
            ModesGrpBx.Location = new Point(106, 431);
            ModesGrpBx.Name = "ModesGrpBx";
            ModesGrpBx.Size = new Size(327, 69);
            ModesGrpBx.TabIndex = 20;
            ModesGrpBx.TabStop = false;
            ModesGrpBx.Text = "Modes";
            // 
            // Mode1Rd
            // 
            Mode1Rd.AutoSize = true;
            Mode1Rd.BackColor = Color.Transparent;
            Mode1Rd.Checked = true;
            Mode1Rd.ForeColor = Color.White;
            Mode1Rd.Location = new Point(19, 29);
            Mode1Rd.Name = "Mode1Rd";
            Mode1Rd.Size = new Size(81, 24);
            Mode1Rd.TabIndex = 11;
            Mode1Rd.TabStop = true;
            Mode1Rd.Text = "Mode 1";
            Mode1Rd.UseVisualStyleBackColor = false;
            // 
            // NumberofOperationsLbl
            // 
            NumberofOperationsLbl.AutoSize = true;
            NumberofOperationsLbl.BackColor = Color.Transparent;
            NumberofOperationsLbl.ForeColor = Color.White;
            NumberofOperationsLbl.Location = new Point(102, 271);
            NumberofOperationsLbl.Name = "NumberofOperationsLbl";
            NumberofOperationsLbl.Size = new Size(159, 20);
            NumberofOperationsLbl.TabIndex = 21;
            NumberofOperationsLbl.Text = "Number of operations:";
            // 
            // NumberofOperations
            // 
            NumberofOperations.Location = new Point(264, 266);
            NumberofOperations.Margin = new Padding(3, 4, 3, 4);
            NumberofOperations.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NumberofOperations.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            NumberofOperations.Name = "NumberofOperations";
            NumberofOperations.Size = new Size(83, 27);
            NumberofOperations.TabIndex = 22;
            NumberofOperations.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Location = new Point(349, 270);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 23;
            label6.Text = "(100-100000)";
            // 
            // LangBtn
            // 
            LangBtn.BackColor = Color.Transparent;
            LangBtn.FlatStyle = FlatStyle.Flat;
            LangBtn.ForeColor = Color.White;
            LangBtn.Location = new Point(501, 606);
            LangBtn.Name = "LangBtn";
            LangBtn.Size = new Size(38, 35);
            LangBtn.TabIndex = 24;
            LangBtn.Text = "TR";
            LangBtn.UseVisualStyleBackColor = false;
            LangBtn.Click += LangBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(546, 647);
            Controls.Add(LangBtn);
            Controls.Add(label6);
            Controls.Add(NumberofOperations);
            Controls.Add(NumberofOperationsLbl);
            Controls.Add(ModesGrpBx);
            Controls.Add(MethodsGrpBx);
            Controls.Add(ResetBtn);
            Controls.Add(panel2);
            Controls.Add(CharsLbl);
            Controls.Add(label2);
            Controls.Add(TimeTxt);
            Controls.Add(label4);
            Controls.Add(CalculateBtn);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(VarietyLbl);
            Controls.Add(LentghLbl);
            Controls.Add(PassLbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(564, 694);
            MinimumSize = new Size(564, 694);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DS Brute Force Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            MethodsGrpBx.ResumeLayout(false);
            MethodsGrpBx.PerformLayout();
            ModesGrpBx.ResumeLayout(false);
            ModesGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumberofOperations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PassLbl;
        private TextBox PassTxtBx;
        private Label LentghLbl;
        private Label VarietyLbl;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button CalculateBtn;
        private Label label4;
        private Label TimeTxt;
        private RadioButton Md5Rd;
        private Label label2;
        private Panel panel2;
        private TextBox CharsTxtBx;
        private Label CharsLbl;
        private Button ResetBtn;
        private GroupBox MethodsGrpBx;
        private RadioButton Sha256Rd;
        private GroupBox ModesGrpBx;
        private RadioButton Mode1Rd;
        private Label NumberofOperationsLbl;
        private NumericUpDown NumberofOperations;
        private Label label6;
        private Button LangBtn;
    }
}
