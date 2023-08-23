using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginatingEFCore.Models
{
    public class TourDTO
    {
     public int Id { get; set; }
    public string TourTitle { get; set; } = string.Empty;
        public string TourDescription { get; set;} = string.Empty;

        public int price { get; set; }

        public string Duration { get; set; } = string.Empty;



    }
}
