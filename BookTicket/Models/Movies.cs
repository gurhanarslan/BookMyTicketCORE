using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookTicket.Models
{
    public class Movies
    {
        public int MoviesId { get; set; }
        public string MoviesName { get; set; }
        public string MoviesDirector { get; set; }
        public string MoviesDescription { get; set; }
        public string MoviesSeans { get; set; }
        public bool IsApproved { get; set; }
        public bool IsSliderLogin1 { get; set; }
        public bool IsSliderLogin2 { get; set; }
        public bool IsSliderHome { get; set; }
        public string FilmDate { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Ticket Ticket { get; set; }
        public string CategoryName { get; set; }

    }
    public class Ticket
    {   [Key]
        public int BiletNumberId { get; set; }
        [Required(ErrorMessage ="Lütfen Yer Seçiniz.")]
        public bool FullorEmpty { get; set; }
        public bool KoltukNo1 { get; set; }
        public bool KoltukNo2 { get; set; }
        public bool KoltukNo3 { get; set; }
        public bool KoltukNo4 { get; set; }
        public bool KoltukNo5 { get; set; }
        public bool KoltukNo6 { get; set; }
        public bool KoltukNo7 { get; set; }
        public bool KoltukNo8 { get; set; }
        public bool KoltukNo9 { get; set; }
        public bool KoltukNo10 { get; set; }
        public bool KoltukNo11 { get; set; }
        public bool KoltukNo12 { get; set; }
        public bool KoltukNo13 { get; set; }
        public bool KoltukNo14 { get; set; }
        public bool KoltukNo15 { get; set; }
        public bool KoltukNo16 { get; set; }
        public bool KoltukNo17 { get; set; }
        public bool KoltukNo18 { get; set; }
        public bool KoltukNo19 { get; set; }
        public bool KoltukNo20 { get; set; }
        public bool KoltukNo21 { get; set; }
        public bool KoltukNo22 { get; set; }
        public bool KoltukNo23 { get; set; }
        public bool KoltukNo24 { get; set; }
        public bool KoltukNo25 { get; set; }
        public bool KoltukNo26 { get; set; }
        public bool KoltukNo27 { get; set; }
        public bool KoltukNo28 { get; set; }
        public bool KoltukNo29 { get; set; }
        public bool KoltukNo30 { get; set; }


    }

}
