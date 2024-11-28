﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Models
{
    [Table("IstifadeciHereketleri")]
    public class IstifadeciHereketleri
    {
        public int Id { get; set; }

        public int IstifadeciID { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarix { get; set; }


    }
}
