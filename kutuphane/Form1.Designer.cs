namespace kutuphane
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label8 = new Label();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btn_login = new Button();
            btn_logout = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox_kullanici_adi = new TextBox();
            textBox_sifre = new TextBox();
            pictureBox2 = new PictureBox();
            tabPage2 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtAdminKadi = new TextBox();
            label9 = new Label();
            txtAdminsifre = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            button3 = new Button();
            btnAdminGiris = new Button();
            label3 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 437);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 409);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kullanici girisi";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.DarkGray;
            label8.Location = new Point(321, 205);
            label8.Name = "label8";
            label8.Size = new Size(156, 30);
            label8.TabIndex = 3;
            label8.Text = "Kullanici Girisi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(120, 160, 212);
            label4.Location = new Point(211, 160);
            label4.Name = "label4";
            label4.Size = new Size(386, 45);
            label4.TabIndex = 2;
            label4.Text = "12/B Kutuphane Projesi";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.8243732F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.17563F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(label6, 0, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Controls.Add(textBox_kullanici_adi, 1, 0);
            tableLayoutPanel2.Controls.Add(textBox_sifre, 1, 1);
            tableLayoutPanel2.Location = new Point(258, 251);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel2.Size = new Size(279, 120);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btn_login, 0, 0);
            tableLayoutPanel3.Controls.Add(btn_logout, 1, 0);
            tableLayoutPanel3.Location = new Point(89, 59);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(187, 58);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.LimeGreen;
            btn_login.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btn_login.ForeColor = SystemColors.Control;
            btn_login.Location = new Point(3, 3);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(87, 52);
            btn_login.TabIndex = 8;
            btn_login.Text = "Enter";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Red;
            btn_logout.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btn_logout.ForeColor = SystemColors.Control;
            btn_logout.Location = new Point(96, 3);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(87, 52);
            btn_logout.TabIndex = 9;
            btn_logout.Text = "Leave";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(120, 160, 212);
            label5.Location = new Point(8, 6);
            label5.Name = "label5";
            label5.Size = new Size(69, 16);
            label5.TabIndex = 0;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(120, 160, 212);
            label6.Location = new Point(11, 34);
            label6.Name = "label6";
            label6.Size = new Size(64, 16);
            label6.TabIndex = 1;
            label6.Text = "Password:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(120, 160, 212);
            label7.Location = new Point(25, 80);
            label7.Name = "label7";
            label7.Size = new Size(35, 16);
            label7.TabIndex = 2;
            label7.Text = "Login";
            label7.Click += label7_Click;
            // 
            // textBox_kullanici_adi
            // 
            textBox_kullanici_adi.Location = new Point(89, 3);
            textBox_kullanici_adi.Name = "textBox_kullanici_adi";
            textBox_kullanici_adi.Size = new Size(187, 23);
            textBox_kullanici_adi.TabIndex = 4;
            // 
            // textBox_sifre
            // 
            textBox_sifre.Location = new Point(89, 31);
            textBox_sifre.Name = "textBox_sifre";
            textBox_sifre.Size = new Size(187, 23);
            textBox_sifre.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.book;
            pictureBox2.Location = new Point(332, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(135, 120);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 409);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "admin girisi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(319, 206);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 7;
            label1.Text = "Admin Girisi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(120, 160, 212);
            label2.Location = new Point(209, 161);
            label2.Name = "label2";
            label2.Size = new Size(386, 45);
            label2.TabIndex = 6;
            label2.Text = "12/B Kutuphane Projesi";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.8243732F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.17563F));
            tableLayoutPanel1.Controls.Add(txtAdminKadi, 1, 0);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(txtAdminsifre, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label10, 0, 2);
            tableLayoutPanel1.Location = new Point(256, 252);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.Size = new Size(279, 120);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // txtAdminKadi
            // 
            txtAdminKadi.Location = new Point(89, 3);
            txtAdminKadi.Name = "txtAdminKadi";
            txtAdminKadi.Size = new Size(187, 23);
            txtAdminKadi.TabIndex = 3;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.FromArgb(120, 160, 212);
            label9.Location = new Point(11, 34);
            label9.Name = "label9";
            label9.Size = new Size(64, 16);
            label9.TabIndex = 9;
            label9.Text = "Password:";
            // 
            // txtAdminsifre
            // 
            txtAdminsifre.Location = new Point(89, 31);
            txtAdminsifre.Name = "txtAdminsifre";
            txtAdminsifre.Size = new Size(187, 23);
            txtAdminsifre.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(button3, 1, 0);
            tableLayoutPanel4.Controls.Add(btnAdminGiris, 0, 0);
            tableLayoutPanel4.Location = new Point(89, 59);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(187, 58);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(96, 3);
            button3.Name = "button3";
            button3.Size = new Size(88, 52);
            button3.TabIndex = 7;
            button3.Text = "Leave";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnAdminGiris
            // 
            btnAdminGiris.BackColor = Color.LimeGreen;
            btnAdminGiris.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnAdminGiris.ForeColor = SystemColors.Control;
            btnAdminGiris.Location = new Point(3, 3);
            btnAdminGiris.Name = "btnAdminGiris";
            btnAdminGiris.Size = new Size(87, 52);
            btnAdminGiris.TabIndex = 6;
            btnAdminGiris.Text = "Enter";
            btnAdminGiris.UseVisualStyleBackColor = false;
            btnAdminGiris.Click += btnAdminGiris_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(120, 160, 212);
            label3.Location = new Point(8, 6);
            label3.Name = "label3";
            label3.Size = new Size(69, 16);
            label3.TabIndex = 8;
            label3.Text = "Username:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.FromArgb(120, 160, 212);
            label10.Location = new Point(25, 80);
            label10.Name = "label10";
            label10.Size = new Size(35, 16);
            label10.TabIndex = 10;
            label10.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.book;
            pictureBox1.Location = new Point(330, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 120);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtAdminKadi;
        private TextBox txtAdminsifre;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button3;
        private Button btnAdminGiris;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label3;
        private Label label10;
        private TabPage tabPage1;
        private Label label8;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox_kullanici_adi;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btn_logout;
        private Button btn_login;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox_sifre;
        private PictureBox pictureBox2;
    }
}
