namespace DoyaDoyaAnadolu
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
            cboSehirler = new ComboBox();
            lstOzellikler = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnSehirEkle = new Button();
            btnOzellikEkle = new Button();
            txtSehir = new TextBox();
            txtOzellik = new TextBox();
            label3 = new Label();
            nudPlakaDegeri = new NumericUpDown();
            btnSeciliOzellikKaldir = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPlakaDegeri).BeginInit();
            SuspendLayout();
            // 
            // cboSehirler
            // 
            cboSehirler.DisplayMember = "Ad";
            cboSehirler.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSehirler.FormattingEnabled = true;
            cboSehirler.Location = new Point(25, 102);
            cboSehirler.Name = "cboSehirler";
            cboSehirler.Size = new Size(368, 23);
            cboSehirler.TabIndex = 0;
            cboSehirler.SelectedIndexChanged += cboSehirler_SelectedIndexChanged;
            // 
            // lstOzellikler
            // 
            lstOzellikler.DisplayMember = "Ad";
            lstOzellikler.FormattingEnabled = true;
            lstOzellikler.ItemHeight = 15;
            lstOzellikler.Location = new Point(27, 208);
            lstOzellikler.Name = "lstOzellikler";
            lstOzellikler.Size = new Size(369, 334);
            lstOzellikler.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 31);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "Şehir seç:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 143);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Özellikler:";
            // 
            // btnSehirEkle
            // 
            btnSehirEkle.Location = new Point(318, 54);
            btnSehirEkle.Name = "btnSehirEkle";
            btnSehirEkle.Size = new Size(75, 23);
            btnSehirEkle.TabIndex = 4;
            btnSehirEkle.Text = "Şehir Ekle";
            btnSehirEkle.UseVisualStyleBackColor = true;
            btnSehirEkle.Click += btnSehirEkle_Click;
            // 
            // btnOzellikEkle
            // 
            btnOzellikEkle.Location = new Point(318, 165);
            btnOzellikEkle.Name = "btnOzellikEkle";
            btnOzellikEkle.Size = new Size(75, 23);
            btnOzellikEkle.TabIndex = 5;
            btnOzellikEkle.Text = "Özellik Ekle";
            btnOzellikEkle.UseVisualStyleBackColor = true;
            btnOzellikEkle.Click += btnOzellikEkle_Click;
            // 
            // txtSehir
            // 
            txtSehir.Location = new Point(136, 56);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(176, 23);
            txtSehir.TabIndex = 6;
            // 
            // txtOzellik
            // 
            txtOzellik.Location = new Point(25, 166);
            txtOzellik.Name = "txtOzellik";
            txtOzellik.Size = new Size(287, 23);
            txtOzellik.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 31);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Plaka No:";
            // 
            // nudPlakaDegeri
            // 
            nudPlakaDegeri.Location = new Point(25, 56);
            nudPlakaDegeri.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPlakaDegeri.Name = "nudPlakaDegeri";
            nudPlakaDegeri.Size = new Size(84, 23);
            nudPlakaDegeri.TabIndex = 9;
            nudPlakaDegeri.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSeciliOzellikKaldir
            // 
            btnSeciliOzellikKaldir.Location = new Point(27, 548);
            btnSeciliOzellikKaldir.Name = "btnSeciliOzellikKaldir";
            btnSeciliOzellikKaldir.Size = new Size(366, 23);
            btnSeciliOzellikKaldir.TabIndex = 10;
            btnSeciliOzellikKaldir.Text = "Seçili Özelliği Kaldır";
            btnSeciliOzellikKaldir.UseVisualStyleBackColor = true;
            btnSeciliOzellikKaldir.Click += btnSeciliOzellikKaldir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(430, 591);
            Controls.Add(btnSeciliOzellikKaldir);
            Controls.Add(nudPlakaDegeri);
            Controls.Add(label3);
            Controls.Add(txtOzellik);
            Controls.Add(txtSehir);
            Controls.Add(btnOzellikEkle);
            Controls.Add(btnSehirEkle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstOzellikler);
            Controls.Add(cboSehirler);
            Name = "Form1";
            Text = "Doya Doya Anadolu";
            ((System.ComponentModel.ISupportInitialize)nudPlakaDegeri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSehirler;
        private ListBox lstOzellikler;
        private Label label1;
        private Label label2;
        private Button btnSehirEkle;
        private Button btnOzellikEkle;
        private TextBox txtSehir;
        private TextBox txtOzellik;
        private Label label3;
        private NumericUpDown nudPlakaDegeri;
        private Button btnSeciliOzellikKaldir;
    }
}