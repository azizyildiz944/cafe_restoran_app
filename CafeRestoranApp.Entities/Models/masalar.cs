﻿using CafeRestoranApp.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace CafeRestoranApp.Entities.Models
{
    public class Masalar : IEntity
    {
        public int Id { get; set; }

        public string MasaAdi { get; set; }

        public string Aciklama { get; set; }

        public bool Durumu { get; set; }

        public bool Rezervasiya { get; set; }

        public DateTime ElaveOlmaTarixi { get; set; }

        public DateTime SonIslemTarixi { get; set; }

        public string Islem { get; set; }

        public string SatisKodu { get; set; }

        public int? KullaniciId { get; set; }


        public virtual ICollection<MasaHaraketleri> MasaHaraketleri { get; set; }

        public virtual Istifadeciler İsIstifadeciler { get; set; }


    }
}
