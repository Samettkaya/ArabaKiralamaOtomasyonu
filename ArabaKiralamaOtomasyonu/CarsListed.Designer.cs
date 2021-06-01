
namespace ArabaKiralamaOtomasyonu
{
    partial class CarsListed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsListed));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboCar = new System.Windows.Forms.ComboBox();
            this.btnImageAdd = new System.Windows.Forms.Button();
            this.btnCarCancel = new System.Windows.Forms.Button();
            this.btnCarAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fluetext = new System.Windows.Forms.ComboBox();
            this.pricetext = new System.Windows.Forms.TextBox();
            this.descriptiontxt = new System.Windows.Forms.TextBox();
            this.kmtext = new System.Windows.Forms.TextBox();
            this.colortxt = new System.Windows.Forms.TextBox();
            this.modelyeartext = new System.Windows.Forms.TextBox();
            this.platetext = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.serialnumbertext = new System.Windows.Forms.TextBox();
            this.carnametext = new System.Windows.Forms.TextBox();
            this.brandtext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 391);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboCar
            // 
            this.comboCar.FormattingEnabled = true;
            this.comboCar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.comboCar.Location = new System.Drawing.Point(828, 29);
            this.comboCar.Name = "comboCar";
            this.comboCar.Size = new System.Drawing.Size(164, 21);
            this.comboCar.TabIndex = 1;
            this.comboCar.SelectedIndexChanged += new System.EventHandler(this.comboCar_SelectedIndexChanged);
            // 
            // btnImageAdd
            // 
            this.btnImageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnImageAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImageAdd.FlatAppearance.BorderSize = 0;
            this.btnImageAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageAdd.ForeColor = System.Drawing.Color.White;
            this.btnImageAdd.Location = new System.Drawing.Point(9, 347);
            this.btnImageAdd.Name = "btnImageAdd";
            this.btnImageAdd.Size = new System.Drawing.Size(75, 23);
            this.btnImageAdd.TabIndex = 47;
            this.btnImageAdd.Text = "Resim Ekle";
            this.btnImageAdd.UseVisualStyleBackColor = false;
            this.btnImageAdd.Click += new System.EventHandler(this.btnImageAdd_Click);
            // 
            // btnCarCancel
            // 
            this.btnCarCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnCarCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCarCancel.FlatAppearance.BorderSize = 0;
            this.btnCarCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarCancel.ForeColor = System.Drawing.Color.White;
            this.btnCarCancel.Location = new System.Drawing.Point(203, 474);
            this.btnCarCancel.Name = "btnCarCancel";
            this.btnCarCancel.Size = new System.Drawing.Size(50, 25);
            this.btnCarCancel.TabIndex = 46;
            this.btnCarCancel.Text = "İptal";
            this.btnCarCancel.UseVisualStyleBackColor = false;
            this.btnCarCancel.Click += new System.EventHandler(this.btnCarCancel_Click);
            // 
            // btnCarAdd
            // 
            this.btnCarAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnCarAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCarAdd.FlatAppearance.BorderSize = 0;
            this.btnCarAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarAdd.ForeColor = System.Drawing.Color.White;
            this.btnCarAdd.Location = new System.Drawing.Point(128, 474);
            this.btnCarAdd.Name = "btnCarAdd";
            this.btnCarAdd.Size = new System.Drawing.Size(69, 25);
            this.btnCarAdd.TabIndex = 45;
            this.btnCarAdd.Text = "Güncelle";
            this.btnCarAdd.UseVisualStyleBackColor = false;
            this.btnCarAdd.Click += new System.EventHandler(this.btnCarAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(90, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Araba İsmi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Yakıt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Açıklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "KM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Model(Yıl)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Seri No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Plaka";
            // 
            // fluetext
            // 
            this.fluetext.FormattingEnabled = true;
            this.fluetext.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin +Lpg",
            "Lpg"});
            this.fluetext.Location = new System.Drawing.Point(90, 207);
            this.fluetext.Name = "fluetext";
            this.fluetext.Size = new System.Drawing.Size(163, 21);
            this.fluetext.TabIndex = 33;
            // 
            // pricetext
            // 
            this.pricetext.Location = new System.Drawing.Point(90, 233);
            this.pricetext.Name = "pricetext";
            this.pricetext.Size = new System.Drawing.Size(163, 20);
            this.pricetext.TabIndex = 32;
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.Location = new System.Drawing.Point(90, 258);
            this.descriptiontxt.Multiline = true;
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(163, 84);
            this.descriptiontxt.TabIndex = 31;
            // 
            // kmtext
            // 
            this.kmtext.Location = new System.Drawing.Point(90, 182);
            this.kmtext.Name = "kmtext";
            this.kmtext.Size = new System.Drawing.Size(163, 20);
            this.kmtext.TabIndex = 30;
            // 
            // colortxt
            // 
            this.colortxt.Location = new System.Drawing.Point(90, 157);
            this.colortxt.Name = "colortxt";
            this.colortxt.Size = new System.Drawing.Size(163, 20);
            this.colortxt.TabIndex = 29;
            // 
            // modelyeartext
            // 
            this.modelyeartext.Location = new System.Drawing.Point(90, 132);
            this.modelyeartext.Name = "modelyeartext";
            this.modelyeartext.Size = new System.Drawing.Size(163, 20);
            this.modelyeartext.TabIndex = 28;
            // 
            // platetext
            // 
            this.platetext.Location = new System.Drawing.Point(90, 29);
            this.platetext.Name = "platetext";
            this.platetext.Size = new System.Drawing.Size(163, 20);
            this.platetext.TabIndex = 25;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // serialnumbertext
            // 
            this.serialnumbertext.Location = new System.Drawing.Point(90, 106);
            this.serialnumbertext.Name = "serialnumbertext";
            this.serialnumbertext.Size = new System.Drawing.Size(163, 20);
            this.serialnumbertext.TabIndex = 48;
            // 
            // carnametext
            // 
            this.carnametext.Location = new System.Drawing.Point(90, 81);
            this.carnametext.Name = "carnametext";
            this.carnametext.Size = new System.Drawing.Size(163, 20);
            this.carnametext.TabIndex = 49;
            // 
            // brandtext
            // 
            this.brandtext.Location = new System.Drawing.Point(90, 55);
            this.brandtext.Name = "brandtext";
            this.brandtext.Size = new System.Drawing.Size(163, 20);
            this.brandtext.TabIndex = 50;
            // 
            // CarsListed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1004, 521);
            this.Controls.Add(this.brandtext);
            this.Controls.Add(this.carnametext);
            this.Controls.Add(this.serialnumbertext);
            this.Controls.Add(this.btnImageAdd);
            this.Controls.Add(this.btnCarCancel);
            this.Controls.Add(this.btnCarAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fluetext);
            this.Controls.Add(this.pricetext);
            this.Controls.Add(this.descriptiontxt);
            this.Controls.Add(this.kmtext);
            this.Controls.Add(this.colortxt);
            this.Controls.Add(this.modelyeartext);
            this.Controls.Add(this.platetext);
            this.Controls.Add(this.comboCar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarsListed";
            this.Text = "Araçlar";
            this.Load += new System.EventHandler(this.CarsListed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboCar;
        private System.Windows.Forms.Button btnImageAdd;
        private System.Windows.Forms.Button btnCarCancel;
        private System.Windows.Forms.Button btnCarAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fluetext;
        private System.Windows.Forms.TextBox pricetext;
        private System.Windows.Forms.TextBox descriptiontxt;
        private System.Windows.Forms.TextBox kmtext;
        private System.Windows.Forms.TextBox colortxt;
        private System.Windows.Forms.TextBox modelyeartext;
        private System.Windows.Forms.TextBox platetext;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox serialnumbertext;
        private System.Windows.Forms.TextBox carnametext;
        private System.Windows.Forms.TextBox brandtext;
    }
}