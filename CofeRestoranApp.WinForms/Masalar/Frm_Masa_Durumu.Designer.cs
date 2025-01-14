﻿namespace CofeRestoranApp.WinForms.Masalar
{
    partial class Frm_Masa_Durumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Masa_Durumu));
            this.Lbn_Basliq = new DevExpress.XtraEditors.LabelControl();
            this.Group_Emeliyyatlar = new DevExpress.XtraEditors.GroupControl();
            this.Btn_Rezev_Et = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Masa_Ac = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Yeni_Sifaris = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cisix_et = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Group_Emeliyyatlar)).BeginInit();
            this.Group_Emeliyyatlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbn_Basliq
            // 
            this.Lbn_Basliq.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbn_Basliq.Appearance.ForeColor = System.Drawing.Color.Red;
            this.Lbn_Basliq.Appearance.Options.UseFont = true;
            this.Lbn_Basliq.Appearance.Options.UseForeColor = true;
            this.Lbn_Basliq.Appearance.Options.UseTextOptions = true;
            this.Lbn_Basliq.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Lbn_Basliq.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Lbn_Basliq.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbn_Basliq.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbn_Basliq.Location = new System.Drawing.Point(0, 0);
            this.Lbn_Basliq.Name = "Lbn_Basliq";
            this.Lbn_Basliq.Size = new System.Drawing.Size(998, 43);
            this.Lbn_Basliq.TabIndex = 8;
            this.Lbn_Basliq.Text = "Masa Melumati";
            // 
            // Group_Emeliyyatlar
            // 
            this.Group_Emeliyyatlar.Controls.Add(this.Btn_Rezev_Et);
            this.Group_Emeliyyatlar.Controls.Add(this.Btn_Masa_Ac);
            this.Group_Emeliyyatlar.Controls.Add(this.btn_Guncelle);
            this.Group_Emeliyyatlar.Controls.Add(this.Btn_Yeni_Sifaris);
            this.Group_Emeliyyatlar.Controls.Add(this.btn_cisix_et);
            this.Group_Emeliyyatlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Group_Emeliyyatlar.Location = new System.Drawing.Point(0, 621);
            this.Group_Emeliyyatlar.Name = "Group_Emeliyyatlar";
            this.Group_Emeliyyatlar.Size = new System.Drawing.Size(998, 81);
            this.Group_Emeliyyatlar.TabIndex = 9;
            this.Group_Emeliyyatlar.Text = "Əməliyyatlar";
            // 
            // Btn_Rezev_Et
            // 
            this.Btn_Rezev_Et.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rezev_Et.Appearance.Options.UseFont = true;
            this.Btn_Rezev_Et.Appearance.Options.UseTextOptions = true;
            this.Btn_Rezev_Et.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Rezev_Et.Enabled = false;
            this.Btn_Rezev_Et.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Rezev_Et.ImageOptions.Image")));
            this.Btn_Rezev_Et.Location = new System.Drawing.Point(273, 26);
            this.Btn_Rezev_Et.Name = "Btn_Rezev_Et";
            this.Btn_Rezev_Et.Size = new System.Drawing.Size(125, 46);
            this.Btn_Rezev_Et.TabIndex = 4;
            this.Btn_Rezev_Et.Text = "Rezev Et";
            this.Btn_Rezev_Et.Click += new System.EventHandler(this.Btn_Rezev_Et_Click);
            // 
            // Btn_Masa_Ac
            // 
            this.Btn_Masa_Ac.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Masa_Ac.Appearance.Options.UseFont = true;
            this.Btn_Masa_Ac.Appearance.Options.UseTextOptions = true;
            this.Btn_Masa_Ac.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Masa_Ac.Enabled = false;
            this.Btn_Masa_Ac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Masa_Ac.ImageOptions.Image")));
            this.Btn_Masa_Ac.Location = new System.Drawing.Point(143, 26);
            this.Btn_Masa_Ac.Name = "Btn_Masa_Ac";
            this.Btn_Masa_Ac.Size = new System.Drawing.Size(125, 46);
            this.Btn_Masa_Ac.TabIndex = 4;
            this.Btn_Masa_Ac.Text = "Masa Ac";
            this.Btn_Masa_Ac.Click += new System.EventHandler(this.Btn_Masa_Ac_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guncelle.Appearance.Options.UseFont = true;
            this.btn_Guncelle.Appearance.Options.UseTextOptions = true;
            this.btn_Guncelle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guncelle.ImageOptions.Image")));
            this.btn_Guncelle.Location = new System.Drawing.Point(403, 26);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(125, 46);
            this.btn_Guncelle.TabIndex = 4;
            this.btn_Guncelle.Text = "Güncəllə";
            // 
            // Btn_Yeni_Sifaris
            // 
            this.Btn_Yeni_Sifaris.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Yeni_Sifaris.Appearance.Options.UseFont = true;
            this.Btn_Yeni_Sifaris.Appearance.Options.UseTextOptions = true;
            this.Btn_Yeni_Sifaris.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Yeni_Sifaris.Enabled = false;
            this.Btn_Yeni_Sifaris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Yeni_Sifaris.ImageOptions.Image")));
            this.Btn_Yeni_Sifaris.Location = new System.Drawing.Point(13, 26);
            this.Btn_Yeni_Sifaris.Name = "Btn_Yeni_Sifaris";
            this.Btn_Yeni_Sifaris.Size = new System.Drawing.Size(125, 46);
            this.Btn_Yeni_Sifaris.TabIndex = 0;
            this.Btn_Yeni_Sifaris.Text = "Sifarisler";
            this.Btn_Yeni_Sifaris.Click += new System.EventHandler(this.Btn_Yeni_Sifaris_Click);
            // 
            // btn_cisix_et
            // 
            this.btn_cisix_et.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cisix_et.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cisix_et.Appearance.Options.UseFont = true;
            this.btn_cisix_et.Appearance.Options.UseTextOptions = true;
            this.btn_cisix_et.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_cisix_et.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_cisix_et.ImageOptions.SvgImage")));
            this.btn_cisix_et.Location = new System.Drawing.Point(869, 26);
            this.btn_cisix_et.Name = "btn_cisix_et";
            this.btn_cisix_et.Size = new System.Drawing.Size(125, 46);
            this.btn_cisix_et.TabIndex = 3;
            this.btn_cisix_et.Text = "Çıxış";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(998, 578);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // Frm_Masa_Durumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 702);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Group_Emeliyyatlar);
            this.Controls.Add(this.Lbn_Basliq);
            this.Name = "Frm_Masa_Durumu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Masa_Durumu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Masa_Durumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Group_Emeliyyatlar)).EndInit();
            this.Group_Emeliyyatlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Lbn_Basliq;
        private DevExpress.XtraEditors.GroupControl Group_Emeliyyatlar;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton Btn_Yeni_Sifaris;
        private DevExpress.XtraEditors.SimpleButton btn_cisix_et;
        private DevExpress.XtraEditors.SimpleButton Btn_Rezev_Et;
        private DevExpress.XtraEditors.SimpleButton Btn_Masa_Ac;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}