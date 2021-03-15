using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMDB.Models;

namespace IMDB.ViewModel
{
    public class RandomMovie
    {
        public Movies Movies { get; set; }
        public List<Customers> customers { get; set; }
        
    }
}