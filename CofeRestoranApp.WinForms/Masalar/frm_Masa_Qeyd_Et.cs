﻿using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using CafeRestoranApp.Entities.Utilities;
using System;
using System.Windows.Forms;

namespace CofeRestoranApp.WinForms.Masalar
{
    public partial class Frm_Masa_Qeyd_Et : DevExpress.XtraEditors.XtraForm
    {
        private readonly CafeContext context = new CafeContext();
        private readonly MasalarDAL masalarDal = new MasalarDAL();
        private readonly CafeRestoranApp.Entities.Models.Masalar _entity;
        public bool Qeydet { get; private set; }

        public Frm_Masa_Qeyd_Et(CafeRestoranApp.Entities.Models.Masalar entity)
        {
            InitializeComponent();
            _entity = entity;
            txt_Urun_Adi.DataBindings.Add("Text", _entity, "MasaAdi");
            txtR_Aciklama.DataBindings.Add("Text", _entity, "Aciklama");

        }
        private void Frm_Masa_Qeyd_Et_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cisix_et_Click(object sender, EventArgs e)
        {
            Qeydet = false;
            this.Close();
        }

        private void brn_Qeyd_Er_Click(object sender, EventArgs e)
        {
            try
            {
                if (_entity.Id == 0)
                {
                    _entity.Durumu = false;
                    _entity.Rezervasiya = false;
                    _entity.ElaveOlmaTarixi = DateTime.Now;
                    _entity.SonIslemTarixi = DateTime.Now;
                    _entity.Islem = "Yeni masa əlavə edildi";
                }
                else if (_entity.Id != 0)
                {
                    _entity.SonIslemTarixi = DateTime.Now;
                    _entity.Islem = "Masa yeniləndi";
                }

                if (masalarDal.AddOrUpdate(context, _entity))
                {
                    masalarDal.Save(context);
                    Qeydet = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir xəta baş verdi:\n{ex.Message}\n\nSətir məlumatı:\n{ex.StackTrace}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogXeta(ex);
            }

        }

        private void txtR_Aciklama_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}