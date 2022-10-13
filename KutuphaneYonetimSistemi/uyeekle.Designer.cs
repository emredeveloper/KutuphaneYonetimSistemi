namespace KutuphaneYonetimSistemi
{
    partial class uyeekle
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
            this.uyeadi = new System.Windows.Forms.Label();
            this.uyeSoyadi = new System.Windows.Forms.Label();
            this.uyeTelefon = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uyeadi
            // 
            this.uyeadi.AutoSize = true;
            this.uyeadi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uyeadi.Location = new System.Drawing.Point(68, 65);
            this.uyeadi.Name = "uyeadi";
            this.uyeadi.Size = new System.Drawing.Size(70, 22);
            this.uyeadi.TabIndex = 0;
            this.uyeadi.Text = "Üye Adı :";
            // 
            // uyeSoyadi
            // 
            this.uyeSoyadi.AutoSize = true;
            this.uyeSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uyeSoyadi.Location = new System.Drawing.Point(46, 111);
            this.uyeSoyadi.Name = "uyeSoyadi";
            this.uyeSoyadi.Size = new System.Drawing.Size(92, 22);
            this.uyeSoyadi.TabIndex = 1;
            this.uyeSoyadi.Text = "Üye Soyadı :";
            // 
            // uyeTelefon
            // 
            this.uyeTelefon.AutoSize = true;
            this.uyeTelefon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uyeTelefon.Location = new System.Drawing.Point(42, 165);
            this.uyeTelefon.Name = "uyeTelefon";
            this.uyeTelefon.Size = new System.Drawing.Size(96, 22);
            this.uyeTelefon.TabIndex = 2;
            this.uyeTelefon.Text = "Üye Telefon :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(165, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Üye Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(91, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(851, 188);
            this.dataGridView1.TabIndex = 9;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(238, 216);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kadın";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(148, 216);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Erkek";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // uyeekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 583);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uyeTelefon);
            this.Controls.Add(this.uyeSoyadi);
            this.Controls.Add(this.uyeadi);
            this.Name = "uyeekle";
            this.Text = "uyeekle";
            this.Load += new System.EventHandler(this.uyeekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label uyeadi;
        private Label uyeSoyadi;
        private Label uyeTelefon;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private DataGridView dataGridView1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}