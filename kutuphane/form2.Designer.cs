namespace kutuphane
{
    partial class form2
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
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label9 = new Label();
            label3 = new Label();
            txtara = new RichTextBox();
            combatur = new ComboBox();
            button3 = new Button();
            btnyenile = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            DataGridView_kitaplar = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_kitaplar).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(92, 52);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 11;
            label1.Text = "Admin Girisi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(120, 160, 212);
            label2.Location = new Point(82, 12);
            label2.Name = "label2";
            label2.Size = new Size(386, 45);
            label2.TabIndex = 10;
            label2.Text = "12/B Kutuphane Projesi";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.8429317F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.15707F));
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(txtara, 1, 0);
            tableLayoutPanel1.Controls.Add(combatur, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 91);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.97436F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.02564F));
            tableLayoutPanel1.Size = new Size(385, 195);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.FromArgb(120, 160, 212);
            label9.Location = new Point(17, 157);
            label9.Name = "label9";
            label9.Size = new Size(80, 35);
            label9.TabIndex = 9;
            label9.Text = "Tags:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(120, 160, 212);
            label3.Location = new Point(4, 59);
            label3.Name = "label3";
            label3.Size = new Size(106, 35);
            label3.TabIndex = 8;
            label3.Text = "Search:";
            // 
            // txtara
            // 
            txtara.Location = new Point(117, 3);
            txtara.Name = "txtara";
            txtara.Size = new Size(265, 148);
            txtara.TabIndex = 14;
            txtara.Text = "";
            txtara.TextChanged += txtara_TextChanged;
            // 
            // combatur
            // 
            combatur.Anchor = AnchorStyles.None;
            combatur.FormattingEnabled = true;
            combatur.Items.AddRange(new object[] { "isim", "kitap_id", "basim_yili", "ev" });
            combatur.Location = new Point(117, 163);
            combatur.Name = "combatur";
            combatur.Size = new Size(265, 23);
            combatur.TabIndex = 15;
            combatur.SelectedIndexChanged += combatur_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(3, 276);
            button3.Name = "button3";
            button3.Size = new Size(376, 65);
            button3.TabIndex = 7;
            button3.Text = "Leave";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnyenile
            // 
            btnyenile.BackColor = Color.LimeGreen;
            btnyenile.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnyenile.ForeColor = SystemColors.Control;
            btnyenile.Location = new Point(3, 3);
            btnyenile.Name = "btnyenile";
            btnyenile.Size = new Size(379, 68);
            btnyenile.TabIndex = 6;
            btnyenile.Text = "Enter";
            btnyenile.UseVisualStyleBackColor = false;
            btnyenile.Click += btnyenile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.book;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Location = new Point(12, 88);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(776, 350);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(button3, 0, 1);
            tableLayoutPanel3.Controls.Add(DataGridView_kitaplar, 0, 0);
            tableLayoutPanel3.Location = new Point(391, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 79.360466F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.639534F));
            tableLayoutPanel3.Size = new Size(382, 344);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // DataGridView_kitaplar
            // 
            DataGridView_kitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_kitaplar.Location = new Point(3, 3);
            DataGridView_kitaplar.Name = "DataGridView_kitaplar";
            DataGridView_kitaplar.Size = new Size(376, 267);
            DataGridView_kitaplar.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(button1, 0, 1);
            tableLayoutPanel4.Controls.Add(btnyenile, 0, 0);
            tableLayoutPanel4.Location = new Point(12, 289);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(385, 149);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(3, 77);
            button1.Name = "button1";
            button1.Size = new Size(379, 68);
            button1.TabIndex = 7;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            // 
            // form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "form2";
            Text = "form2";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_kitaplar).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label9;
        private Button button3;
        private Button btnyenile;
        private Label label3;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button1;
        private RichTextBox txtara;
        private ComboBox combatur;
        private DataGridView DataGridView_kitaplar;
    }
}