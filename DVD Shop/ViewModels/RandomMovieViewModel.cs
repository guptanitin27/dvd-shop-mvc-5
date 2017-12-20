using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DVD_Shop.Models;

namespace DVD_Shop.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

    }
}