using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StarRating { get; set; }
        public bool Recommend { get; set; }
        public string Comments { get; set; }
    }

    public enum StarRating
    {
        OneStar,
        TwoStars,
        ThreeStars,
        FourStars,
        FiveStars
    }
}