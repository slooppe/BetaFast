﻿namespace BetaFastAPI.Model
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string PosterFile { get; set; }
    }
}
