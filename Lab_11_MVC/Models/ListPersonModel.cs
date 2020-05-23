using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_11_MVC.Models
{
    public class ListPersonModel
    {
        public int StartYear { get; set; }
        public int EndYear { get; set; }

        public List<TimesPerson> listOfPeople;
    }
}
