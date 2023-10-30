namespace EvE_Pansiyon_V1._0
{
    partial class frmStoklar
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnKaydet2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDogalgaz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSu = new System.Windows.Forms.TextBox();
            this.txtElektrik = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.txtAtistirmalik = new System.Windows.Forms.TextBox();
            this.txtİcecek = new System.Windows.Forms.TextBox();
            this.txtYiyecek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ColmElektrik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColmSu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColmDogalgaz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 341);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(463, 97);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Yiyecekler";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçecekler";
            this.columnHeader2.Width = 148;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Atıştırmalıklar";
            this.columnHeader3.Width = 168;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BtnKaydet2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDogalgaz);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSu);
            this.groupBox2.Controls.Add(this.txtElektrik);
            this.groupBox2.Location = new System.Drawing.Point(572, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 285);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faturalar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(22, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Elektrik:";
            // 
            // BtnKaydet2
            // 
            this.BtnKaydet2.Location = new System.Drawing.Point(204, 139);
            this.BtnKaydet2.Name = "BtnKaydet2";
            this.BtnKaydet2.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet2.TabIndex = 28;
            this.BtnKaydet2.Text = "Kaydet";
            this.BtnKaydet2.UseVisualStyleBackColor = true;
            this.BtnKaydet2.Click += new System.EventHandler(this.BtnKaydet2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(59, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Su:";
            // 
            // txtDogalgaz
            // 
            this.txtDogalgaz.Location = new System.Drawing.Point(116, 111);
            this.txtDogalgaz.Name = "txtDogalgaz";
            this.txtDogalgaz.Size = new System.Drawing.Size(163, 22);
            this.txtDogalgaz.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Doğalgaz:";
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(116, 73);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(163, 22);
            this.txtSu.TabIndex = 26;
            // 
            // txtElektrik
            // 
            this.txtElektrik.Location = new System.Drawing.Point(116, 38);
            this.txtElektrik.Name = "txtElektrik";
            this.txtElektrik.Size = new System.Drawing.Size(163, 22);
            this.txtElektrik.TabIndex = 25;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(305, 139);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 21;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // txtAtistirmalik
            // 
            this.txtAtistirmalik.Location = new System.Drawing.Point(217, 111);
            this.txtAtistirmalik.Name = "txtAtistirmalik";
            this.txtAtistirmalik.Size = new System.Drawing.Size(163, 22);
            this.txtAtistirmalik.TabIndex = 20;
            // 
            // txtİcecek
            // 
            this.txtİcecek.Location = new System.Drawing.Point(217, 73);
            this.txtİcecek.Name = "txtİcecek";
            this.txtİcecek.Size = new System.Drawing.Size(163, 22);
            this.txtİcecek.TabIndex = 19;
            // 
            // txtYiyecek
            // 
            this.txtYiyecek.Location = new System.Drawing.Point(217, 38);
            this.txtYiyecek.Name = "txtYiyecek";
            this.txtYiyecek.Size = new System.Drawing.Size(163, 22);
            this.txtYiyecek.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Atıştırmalıklar Tuatarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(66, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "İçecek Tuatarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Yiyecek Tuatarı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtYiyecek);
            this.groupBox1.Controls.Add(this.txtİcecek);
            this.groupBox1.Controls.Add(this.txtAtistirmalik);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 285);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mutfak";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColmElektrik,
            this.ColmSu,
            this.ColmDogalgaz});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(572, 341);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(461, 97);
            this.listView2.TabIndex = 30;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // ColmElektrik
            // 
            this.ColmElektrik.Text = "Elektrik";
            this.ColmElektrik.Width = 139;
            // 
            // ColmSu
            // 
            this.ColmSu.Text = "Su";
            this.ColmSu.Width = 148;
            // 
            // ColmDogalgaz
            // 
            this.ColmDogalgaz.Text = "Doğalgaz";
            this.ColmDogalgaz.Width = 168;
            // 
            // frmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStoklar";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.frmStoklar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnKaydet2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDogalgaz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.TextBox txtElektrik;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox txtAtistirmalik;
        private System.Windows.Forms.TextBox txtİcecek;
        private System.Windows.Forms.TextBox txtYiyecek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader ColmElektrik;
        private System.Windows.Forms.ColumnHeader ColmSu;
        private System.Windows.Forms.ColumnHeader ColmDogalgaz;
    }
}