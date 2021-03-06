﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vjezba02.Models
{
    [Table("studenti")]
    public class Student
    {
        [Key]
        [Display(Name = "ID studenta")] //Sadržaj HTML helpera Label
        public int Id { get; set; }

        [Display(Name ="Ime")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "{0} mora biti duljine minimalno {2} a maksimalno {1} znakova")]
        public string Ime { get; set; }

        [Display(Name = "Prezime")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "{0} mora biti duljine minimalno {2} a maksimalno {1} znakova")]
        public string Prezime { get; set; }

        [Display(Name = "Spol")]
        public string Spol { get; set; }

        [Display(Name = "OIB")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "{0} mora biti duljine {1} znakova")]
        public string Oib { get; set; }

        [Column("datum_rodjenja")]
        [Display(Name = "Datum rođenja")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DatumRodjenja { get; set; }

        [Column("godina_studija")]
        [Display(Name = "Godina studija")]
        public GodinaStudija GodinaStudija { get; set; }

        [Column("redovni_student")]
        [Display(Name = "Redovan student")]
        public bool RedovanStudent { get; set; }

        [Column("broj_upisanih_kolegija")]
        [Display(Name = "Broj upisanih kolegija")]
        [Required]
        [Range(1,8)]
        
        public int brojUpisanihKolegija { get; set; }
    }
}