
namespace ArabaKiralamaOtomasyonu
{
    partial class CarAdd
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
            this.platetext = new System.Windows.Forms.TextBox();
            this.modelyeartext = new System.Windows.Forms.TextBox();
            this.colortxt = new System.Windows.Forms.TextBox();
            this.kmtext = new System.Windows.Forms.TextBox();
            this.pricetext = new System.Windows.Forms.TextBox();
            this.fluetext = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCarAdd = new System.Windows.Forms.Button();
            this.btnCarCancel = new System.Windows.Forms.Button();
            this.btnImageAdd = new System.Windows.Forms.Button();
            this.descriptiontxt = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.brandtext = new System.Windows.Forms.TextBox();
            this.serialnumbertext = new System.Windows.Forms.TextBox();
            this.carnametext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // platetext
            // 
            this.platetext.Location = new System.Drawing.Point(100, 36);
            this.platetext.Name = "platetext";
            this.platetext.Size = new System.Drawing.Size(163, 20);
            this.platetext.TabIndex = 0;
            // 
            // modelyeartext
            // 
            this.modelyeartext.Location = new System.Drawing.Point(100, 139);
            this.modelyeartext.Name = "modelyeartext";
            this.modelyeartext.Size = new System.Drawing.Size(163, 20);
            this.modelyeartext.TabIndex = 3;
            // 
            // colortxt
            // 
            this.colortxt.Location = new System.Drawing.Point(100, 164);
            this.colortxt.Name = "colortxt";
            this.colortxt.Size = new System.Drawing.Size(163, 20);
            this.colortxt.TabIndex = 4;
            // 
            // kmtext
            // 
            this.kmtext.Location = new System.Drawing.Point(100, 189);
            this.kmtext.Name = "kmtext";
            this.kmtext.Size = new System.Drawing.Size(163, 20);
            this.kmtext.TabIndex = 5;
            // 
            // pricetext
            // 
            this.pricetext.Location = new System.Drawing.Point(100, 240);
            this.pricetext.Name = "pricetext";
            this.pricetext.Size = new System.Drawing.Size(163, 20);
            this.pricetext.TabIndex = 7;
            // 
            // fluetext
            // 
            this.fluetext.FormattingEnabled = true;
            this.fluetext.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin +Lpg",
            "Lpg"});
            this.fluetext.Location = new System.Drawing.Point(100, 214);
            this.fluetext.Name = "fluetext";
            this.fluetext.Size = new System.Drawing.Size(163, 21);
            this.fluetext.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seri No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Model(Yıl)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "KM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Açıklama";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Yakıt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fiyat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Araba İsmi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(287, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnCarAdd
            // 
            this.btnCarAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnCarAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCarAdd.FlatAppearance.BorderSize = 0;
            this.btnCarAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarAdd.ForeColor = System.Drawing.Color.White;
            this.btnCarAdd.Location = new System.Drawing.Point(157, 373);
            this.btnCarAdd.Name = "btnCarAdd";
            this.btnCarAdd.Size = new System.Drawing.Size(50, 25);
            this.btnCarAdd.TabIndex = 21;
            this.btnCarAdd.Text = "Ekle";
            this.btnCarAdd.UseVisualStyleBackColor = false;
            this.btnCarAdd.Click += new System.EventHandler(this.btnCarAdd_Click);
            // 
            // btnCarCancel
            // 
            this.btnCarCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnCarCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCarCancel.FlatAppearance.BorderSize = 0;
            this.btnCarCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarCancel.ForeColor = System.Drawing.Color.White;
            this.btnCarCancel.Location = new System.Drawing.Point(213, 373);
            this.btnCarCancel.Name = "btnCarCancel";
            this.btnCarCancel.Size = new System.Drawing.Size(50, 25);
            this.btnCarCancel.TabIndex = 22;
            this.btnCarCancel.Text = "İptal";
            this.btnCarCancel.UseVisualStyleBackColor = false;
            this.btnCarCancel.Click += new System.EventHandler(this.btnCarCancel_Click);
            // 
            // btnImageAdd
            // 
            this.btnImageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnImageAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImageAdd.FlatAppearance.BorderSize = 0;
            this.btnImageAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageAdd.ForeColor = System.Drawing.Color.White;
            this.btnImageAdd.Location = new System.Drawing.Point(450, 36);
            this.btnImageAdd.Name = "btnImageAdd";
            this.btnImageAdd.Size = new System.Drawing.Size(75, 23);
            this.btnImageAdd.TabIndex = 23;
            this.btnImageAdd.Text = "Resim Ekle";
            this.btnImageAdd.UseVisualStyleBackColor = false;
            this.btnImageAdd.Click += new System.EventHandler(this.btnImageAdd_Click);
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.Location = new System.Drawing.Point(100, 265);
            this.descriptiontxt.Multiline = true;
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(163, 84);
            this.descriptiontxt.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // brandtext
            // 
            this.brandtext.Location = new System.Drawing.Point(100, 62);
            this.brandtext.Name = "brandtext";
            this.brandtext.Size = new System.Drawing.Size(163, 20);
            this.brandtext.TabIndex = 25;
            // 
            // serialnumbertext
            // 
            this.serialnumbertext.Location = new System.Drawing.Point(100, 114);
            this.serialnumbertext.Name = "serialnumbertext";
            this.serialnumbertext.Size = new System.Drawing.Size(163, 20);
            this.serialnumbertext.TabIndex = 26;
            // 
            // carnametext
            // 
            this.carnametext.Location = new System.Drawing.Point(100, 88);
            this.carnametext.Name = "carnametext";
            this.carnametext.Size = new System.Drawing.Size(163, 20);
            this.carnametext.TabIndex = 28;
            // 
            // CarAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 430);
            this.Controls.Add(this.carnametext);
            this.Controls.Add(this.serialnumbertext);
            this.Controls.Add(this.brandtext);
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
            this.Name = "CarAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt";
            this.Load += new System.EventHandler(this.CarAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox platetext;
        private System.Windows.Forms.TextBox modelyeartext;
        private System.Windows.Forms.TextBox colortxt;
        private System.Windows.Forms.TextBox kmtext;
        private System.Windows.Forms.TextBox pricetext;
        private System.Windows.Forms.ComboBox fluetext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCarAdd;
        private System.Windows.Forms.Button btnCarCancel;
        private System.Windows.Forms.Button btnImageAdd;
        private System.Windows.Forms.TextBox descriptiontxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox brandtext;
        private System.Windows.Forms.TextBox serialnumbertext;
        private System.Windows.Forms.TextBox carnametext;
    }
}