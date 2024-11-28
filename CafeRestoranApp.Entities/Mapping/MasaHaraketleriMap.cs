﻿using CafeRestoranApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Mapping
{
    public class MasaHaraketleriMap : EntityTypeConfiguration<MasaHaraketleri>
    {
        public MasaHaraketleriMap()
        {
            this.ToTable("MasaHaraketleri");

            this.HasKey(p => p.Id);
            
            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            this.Property(p => p.SatisKodu)
                .HasColumnType("varchar")
                .HasMaxLength(50);
           
            this.Property(p => p.Aciklama)
                .HasColumnType("varchar")
                .HasMaxLength(300);
        }
    }
}
