using PaginatingEFCore.Data;
using PaginatingEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginatingEFCore
{
    public class Query
    {
        AppDbContext appDbContext = new AppDbContext();
        public void AddNewTour()
        {
            var NewTour = new TourDTO()
            {
                TourDescription = "Tour Around Nyeri",
                TourTitle = "3 Men Army",
                Duration = "02 Days",
                price = 30000

            };
            appDbContext.Tours_table.Add(NewTour);

            appDbContext.SaveChanges();
        }

        public void FetchTours(int pageNumber, int pageSize)
        {
            var tourslist = appDbContext.Tours_table.Skip((pageNumber -1)*(pageSize)).Take(pageSize).
                ToList();

            foreach (var tour in tourslist)
            {
                Console.WriteLine($"{tour.TourTitle} {tour.TourDescription} {tour.price}");
            }

        }
    }
}
