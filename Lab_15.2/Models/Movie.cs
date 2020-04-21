using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_15._2.Models
{
    public class Movie
    {
        private int movieID;
        private string title;
        private string category;

        public int MovieID { get => movieID; set => movieID = value; }
        public string Title { get => title; set => title = value; }
        public string Category { get => category; set => category = value; }
    }
}
