namespace denemeKutuphane
{
    partial class kitapListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtKitapAdı = new System.Windows.Forms.TextBox();
            this.btnKitapAdıAra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapYazarı = new System.Windows.Forms.Button();
            this.txtKitapYazar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKitapTuru = new System.Windows.Forms.Button();
            this.txtKitapTuru = new System.Windows.Forms.TextBox();
            this.btnHepsi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 92);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 359);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtKitapAdı
            // 
            this.txtKitapAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdı.Location = new System.Drawing.Point(10, 29);
            this.txtKitapAdı.Multiline = true;
            this.txtKitapAdı.Name = "txtKitapAdı";
            this.txtKitapAdı.Size = new System.Drawing.Size(130, 30);
            this.txtKitapAdı.TabIndex = 2;
            // 
            // btnKitapAdıAra
            // 
            this.btnKitapAdıAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapAdıAra.Location = new System.Drawing.Point(146, 29);
            this.btnKitapAdıAra.Name = "btnKitapAdıAra";
            this.btnKitapAdıAra.Size = new System.Drawing.Size(59, 30);
            this.btnKitapAdıAra.TabIndex = 3;
            this.btnKitapAdıAra.Text = "Ara";
            this.btnKitapAdıAra.UseVisualStyleBackColor = true;
            this.btnKitapAdıAra.Click += new System.EventHandler(this.btnKitapAdıAra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKitapAdıAra);
            this.groupBox1.Controls.Add(this.txtKitapAdı);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitabın Adına Göre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKitapYazarı);
            this.groupBox2.Controls.Add(this.txtKitapYazar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(230, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 84);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitabın Yazarına Göre";
            // 
            // btnKitapYazarı
            // 
            this.btnKitapYazarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapYazarı.Location = new System.Drawing.Point(146, 29);
            this.btnKitapYazarı.Name = "btnKitapYazarı";
            this.btnKitapYazarı.Size = new System.Drawing.Size(59, 30);
            this.btnKitapYazarı.TabIndex = 3;
            this.btnKitapYazarı.Text = "Ara";
            this.btnKitapYazarı.UseVisualStyleBackColor = true;
            this.btnKitapYazarı.Click += new System.EventHandler(this.btnKitapYazarı_Click);
            // 
            // txtKitapYazar
            // 
            this.txtKitapYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapYazar.Location = new System.Drawing.Point(10, 29);
            this.txtKitapYazar.Multiline = true;
            this.txtKitapYazar.Name = "txtKitapYazar";
            this.txtKitapYazar.Size = new System.Drawing.Size(130, 30);
            this.txtKitapYazar.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKitapTuru);
            this.groupBox3.Controls.Add(this.txtKitapTuru);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(458, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 84);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitabın Türüne Göre";
            // 
            // btnKitapTuru
            // 
            this.btnKitapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapTuru.Location = new System.Drawing.Point(146, 29);
            this.btnKitapTuru.Name = "btnKitapTuru";
            this.btnKitapTuru.Size = new System.Drawing.Size(59, 30);
            this.btnKitapTuru.TabIndex = 3;
            this.btnKitapTuru.Text = "Ara";
            this.btnKitapTuru.UseVisualStyleBackColor = true;
            this.btnKitapTuru.Click += new System.EventHandler(this.btnKitapTuru_Click);
            // 
            // txtKitapTuru
            // 
            this.txtKitapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapTuru.Location = new System.Drawing.Point(10, 29);
            this.txtKitapTuru.Multiline = true;
            this.txtKitapTuru.Name = "txtKitapTuru";
            this.txtKitapTuru.Size = new System.Drawing.Size(130, 30);
            this.txtKitapTuru.TabIndex = 2;
            // 
            // btnHepsi
            // 
            this.btnHepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsi.Location = new System.Drawing.Point(697, 2);
            this.btnHepsi.Name = "btnHepsi";
            this.btnHepsi.Size = new System.Drawing.Size(84, 84);
            this.btnHepsi.TabIndex = 7;
            this.btnHepsi.Text = "Bütün Kitaplar";
            this.btnHepsi.UseVisualStyleBackColor = true;
            this.btnHepsi.Click += new System.EventHandler(this.butunKitaplar);
            // 
            // kitapListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHepsi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kitapListele";
            this.Text = "kitapListele";
            this.Load += new System.EventHandler(this.KitapListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKitapAdı;
        private System.Windows.Forms.Button btnKitapAdıAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKitapYazarı;
        private System.Windows.Forms.TextBox txtKitapYazar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKitapTuru;
        private System.Windows.Forms.TextBox txtKitapTuru;
        private System.Windows.Forms.Button btnHepsi;
    }
}