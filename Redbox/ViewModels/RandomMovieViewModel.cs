﻿using System.Collections.Generic;
using Redbox.Models;

namespace Redbox.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}