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
    ////public class Review
    ////{
    ////    //constructor for creating review entries
    ////    public Review(int id, string name, StarRating.StarRatingType starRatingType, bool recommend, string comments = null)
    ////    {
    ////        Id = id;
    ////        Name = name;
    ////        StarRatingId = (int)starRatingType;
    ////        Recommend = recommend;
    ////        Comments = comments;

    ////    }
    ////    //Id of review entry
    ////    public int Id { get; set; }

    ////    //Movie name of review entry
    ////    public string Name { get; set; }

    ////    //Star rating of review entry
    ////    [Display(Name = "Star Rating")]
    ////    public int StarRatingId { get; set; }

    ////    //Reccomendation of review entry
    ////    public bool Recommend { get; set; }

    ////    //Comments of review entry
    ////    public string Comments { get; set; }






    ////}
}