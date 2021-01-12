
namespace Kafe21
{
    partial class SiparisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboUrun = new System.Windows.Forms.ComboBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvSiparisDetaylar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMasaNo = new System.Windows.Forms.ComboBox();
            this.btnMasaTasi = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOdemeTutar = new System.Windows.Forms.Label();
            this.btnSiparisIptal = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnAnasayfaya = new System.Windows.Forms.Button();
            this.tsslAcilisZamani = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).BeginInit();
            this.tsslAcilisZamani.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(191, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(533, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Masa No :";
            // 
            // cboUrun
            // 
            this.cboUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrun.FormattingEnabled = true;
            this.cboUrun.Location = new System.Drawing.Point(7, 28);
            this.cboUrun.Name = "cboUrun";
            this.cboUrun.Size = new System.Drawing.Size(156, 26);
            this.cboUrun.TabIndex = 1;
            // 
            // nudAdet
            // 
            this.nudAdet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAdet.Location = new System.Drawing.Point(195, 28);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(118, 26);
            this.nudAdet.TabIndex = 2;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Location = new System.Drawing.Point(330, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(165, 31);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvSiparisDetaylar
            // 
            this.dgvSiparisDetaylar.AllowUserToAddRows = false;
            this.dgvSiparisDetaylar.AllowUserToDeleteRows = false;
            this.dgvSiparisDetaylar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSiparisDetaylar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetaylar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvSiparisDetaylar.Location = new System.Drawing.Point(12, 71);
            this.dgvSiparisDetaylar.MultiSelect = false;
            this.dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
            this.dgvSiparisDetaylar.ReadOnly = true;
            this.dgvSiparisDetaylar.RowHeadersVisible = false;
            this.dgvSiparisDetaylar.RowHeadersWidth = 51;
            this.dgvSiparisDetaylar.RowTemplate.Height = 24;
            this.dgvSiparisDetaylar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisDetaylar.Size = new System.Drawing.Size(505, 321);
            this.dgvSiparisDetaylar.TabIndex = 4;
            this.dgvSiparisDetaylar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSiparisDetaylar_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UrunAd";
            this.Column1.HeaderText = "Ürün";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BirimFiyat";
            this.Column2.HeaderText = "Birim Fiyat";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Adet";
            this.Column3.HeaderText = "Adet";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TutarTL";
            this.Column4.HeaderText = "Tutar";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // cboMasaNo
            // 
            this.cboMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMasaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMasaNo.FormattingEnabled = true;
            this.cboMasaNo.Location = new System.Drawing.Point(537, 25);
            this.cboMasaNo.Name = "cboMasaNo";
            this.cboMasaNo.Size = new System.Drawing.Size(119, 26);
            this.cboMasaNo.TabIndex = 5;
            // 
            // btnMasaTasi
            // 
            this.btnMasaTasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMasaTasi.Location = new System.Drawing.Point(660, 24);
            this.btnMasaTasi.Name = "btnMasaTasi";
            this.btnMasaTasi.Size = new System.Drawing.Size(115, 26);
            this.btnMasaTasi.TabIndex = 3;
            this.btnMasaTasi.Text = "TAŞI";
            this.btnMasaTasi.UseVisualStyleBackColor = true;
            this.btnMasaTasi.Click += new System.EventHandler(this.btnMasaTasi_Click);
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasaNo.BackColor = System.Drawing.Color.Tomato;
            this.lblMasaNo.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMasaNo.Location = new System.Drawing.Point(575, 80);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(148, 140);
            this.lblMasaNo.TabIndex = 0;
            this.lblMasaNo.Text = "03";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(566, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ödeme Tutarı :";
            // 
            // lblOdemeTutar
            // 
            this.lblOdemeTutar.AutoSize = true;
            this.lblOdemeTutar.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTutar.Location = new System.Drawing.Point(684, 240);
            this.lblOdemeTutar.Name = "lblOdemeTutar";
            this.lblOdemeTutar.Size = new System.Drawing.Size(51, 19);
            this.lblOdemeTutar.TabIndex = 0;
            this.lblOdemeTutar.Text = "₺0.00";
            // 
            // btnSiparisIptal
            // 
            this.btnSiparisIptal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisIptal.BackColor = System.Drawing.Color.Firebrick;
            this.btnSiparisIptal.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisIptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiparisIptal.Location = new System.Drawing.Point(518, 274);
            this.btnSiparisIptal.Name = "btnSiparisIptal";
            this.btnSiparisIptal.Size = new System.Drawing.Size(136, 53);
            this.btnSiparisIptal.TabIndex = 3;
            this.btnSiparisIptal.Text = "SİPARİŞ İPTAL";
            this.btnSiparisIptal.UseVisualStyleBackColor = false;
            this.btnSiparisIptal.Click += new System.EventHandler(this.btnSiparisIptal_Click);
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdemeAl.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOdemeAl.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdemeAl.Location = new System.Drawing.Point(662, 274);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(124, 53);
            this.btnOdemeAl.TabIndex = 3;
            this.btnOdemeAl.Text = "ÖDEME AL";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // btnAnasayfaya
            // 
            this.btnAnasayfaya.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnasayfaya.BackColor = System.Drawing.Color.Yellow;
            this.btnAnasayfaya.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfaya.Location = new System.Drawing.Point(518, 334);
            this.btnAnasayfaya.Name = "btnAnasayfaya";
            this.btnAnasayfaya.Size = new System.Drawing.Size(268, 58);
            this.btnAnasayfaya.TabIndex = 3;
            this.btnAnasayfaya.Text = "ANASAYFAYA DÖN";
            this.btnAnasayfaya.UseVisualStyleBackColor = false;
            this.btnAnasayfaya.Click += new System.EventHandler(this.btnAnasayfaya_Click);
            // 
            // tsslAcilisZamani
            // 
            this.tsslAcilisZamani.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsslAcilisZamani.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.tsslAcilisZamani.Location = new System.Drawing.Point(0, 400);
            this.tsslAcilisZamani.Name = "tsslAcilisZamani";
            this.tsslAcilisZamani.Size = new System.Drawing.Size(798, 26);
            this.tsslAcilisZamani.TabIndex = 6;
            this.tsslAcilisZamani.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 20);
            this.toolStripStatusLabel1.Text = "Açılış Zamanı";
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 426);
            this.Controls.Add(this.tsslAcilisZamani);
            this.Controls.Add(this.cboMasaNo);
            this.Controls.Add(this.dgvSiparisDetaylar);
            this.Controls.Add(this.btnMasaTasi);
            this.Controls.Add(this.btnAnasayfaya);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnSiparisIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.cboUrun);
            this.Controls.Add(this.lblOdemeTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "SiparisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SiparisForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).EndInit();
            this.tsslAcilisZamani.ResumeLayout(false);
            this.tsslAcilisZamani.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboUrun;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylar;
        private System.Windows.Forms.ComboBox cboMasaNo;
        private System.Windows.Forms.Button btnMasaTasi;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOdemeTutar;
        private System.Windows.Forms.Button btnSiparisIptal;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnAnasayfaya;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.StatusStrip tsslAcilisZamani;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}