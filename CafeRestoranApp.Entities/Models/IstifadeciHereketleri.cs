﻿using CafeRestoranApp.Entities.Interfaces;
using System;

namespace CafeRestoranApp.Entities.Models
{
    //[Table("IstifadeciHereketleri")]
    public class IstifadeciHereketleri : IEntity
    {
        public int Id { get; set; }

        public int IstifadeciID { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarix { get; set; }

        public Istifadeciler Istifadeciler { get; set; }

    }
}
