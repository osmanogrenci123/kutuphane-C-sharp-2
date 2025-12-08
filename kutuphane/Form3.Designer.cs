namespace kutuphane
{
    partial class Form3
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
            tableLayoutPanel2 = new TableLayoutPanel();
            button3 = new Button();
            btnyenile = new Button();
            DataGridView_kitaplar = new DataGridView();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button9 = new Button();
            button10 = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_kitaplar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.40288F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.59712F));
            tableLayoutPanel2.Controls.Add(button3, 1, 5);
            tableLayoutPanel2.Controls.Add(button8, 0, 5);
            tableLayoutPanel2.Controls.Add(btnyenile, 0, 4);
            tableLayoutPanel2.Controls.Add(button7, 1, 4);
            tableLayoutPanel2.Location = new Point(12, 82);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(278, 171);
            tableLayoutPanel2.TabIndex = 13;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(132, 131);
            button3.Name = "button3";
            button3.Size = new Size(143, 37);
            button3.TabIndex = 7;
            button3.Text = "Leave";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnyenile
            // 
            btnyenile.BackColor = Color.LimeGreen;
            btnyenile.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            btnyenile.ForeColor = SystemColors.Control;
            btnyenile.Location = new Point(3, 93);
            btnyenile.Name = "btnyenile";
            btnyenile.Size = new Size(123, 32);
            btnyenile.TabIndex = 10;
            btnyenile.Text = "Enter";
            btnyenile.UseVisualStyleBackColor = false;
            // 
            // DataGridView_kitaplar
            // 
            DataGridView_kitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_kitaplar.Location = new Point(296, 84);
            DataGridView_kitaplar.Name = "DataGridView_kitaplar";
            DataGridView_kitaplar.Size = new Size(492, 169);
            DataGridView_kitaplar.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(296, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(492, 169);
            dataGridView1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.book;
            pictureBox1.Location = new Point(15, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(95, 49);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 19;
            label1.Text = "Admin Girisi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(120, 160, 212);
            label2.Location = new Point(85, 9);
            label2.Name = "label2";
            label2.Size = new Size(386, 45);
            label2.TabIndex = 18;
            label2.Text = "12/B Kutuphane Projesi";
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(703, 40);
            button4.Name = "button4";
            button4.Size = new Size(85, 39);
            button4.TabIndex = 20;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(703, 2);
            button5.Name = "button5";
            button5.Size = new Size(85, 38);
            button5.TabIndex = 21;
            button5.Text = "Leave";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Navy;
            button6.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(477, 19);
            button6.Name = "button6";
            button6.Size = new Size(85, 39);
            button6.TabIndex = 22;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Goldenrod;
            button7.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(132, 93);
            button7.Name = "button7";
            button7.Size = new Size(143, 32);
            button7.TabIndex = 11;
            button7.Text = "Clean";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Navy;
            button8.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button8.ForeColor = SystemColors.Control;
            button8.Location = new Point(3, 131);
            button8.Name = "button8";
            button8.Size = new Size(123, 30);
            button8.TabIndex = 23;
            button8.Text = "Update";
            button8.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.40288F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.59712F));
            tableLayoutPanel1.Controls.Add(button1, 1, 4);
            tableLayoutPanel1.Controls.Add(button2, 0, 4);
            tableLayoutPanel1.Controls.Add(button9, 0, 3);
            tableLayoutPanel1.Controls.Add(button10, 1, 3);
            tableLayoutPanel1.Location = new Point(12, 259);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(278, 171);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(132, 133);
            button1.Name = "button1";
            button1.Size = new Size(143, 35);
            button1.TabIndex = 7;
            button1.Text = "Leave";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(3, 133);
            button2.Name = "button2";
            button2.Size = new Size(123, 35);
            button2.TabIndex = 23;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.LimeGreen;
            button9.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(3, 95);
            button9.Name = "button9";
            button9.Size = new Size(123, 32);
            button9.TabIndex = 10;
            button9.Text = "Enter";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.Goldenrod;
            button10.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            button10.ForeColor = SystemColors.Control;
            button10.Location = new Point(132, 95);
            button10.Name = "button10";
            button10.Size = new Size(143, 32);
            button10.TabIndex = 11;
            button10.Text = "Clean";
            button10.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(DataGridView_kitaplar);
            Controls.Add(tableLayoutPanel2);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_kitaplar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button button3;
        private Button btnyenile;
        private DataGridView DataGridView_kitaplar;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button6;
        private Button button8;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button9;
        private Button button10;
    }
}