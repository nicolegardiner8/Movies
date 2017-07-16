using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movies.Models;

namespace Movies.Repositories
{
    public class ReviewRepository
    {

        public void Create(Review review)
        {
            using (var context = new Context())
            {
                context.Reviews.Add(review);

                context.SaveChanges();
            }
        }

        public void Update(Review review)
        {
            using (var context = new Context())
            {
                var updateReview = context.Reviews.Find(review.Id);
                updateReview.Name = review.Name;
                updateReview.StarRating = review.StarRating;
                updateReview.Recommend = review.Recommend;
                updateReview.Comments = review.Comments;

                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new Context())
            {
                var removeReview = context.Reviews.Find(id);
                context.Reviews.Remove(removeReview);

                context.SaveChanges();
            }
        }

        public List<Review> GetAllReviews()
        {
            List<Review> reviews = new List<Review>();
            using (var context = new Context())
            {
                reviews = context.Reviews.ToList();
            }

            return reviews;
        }

        public Review GetById(int id)
        {
            Review review = null;
            using (var context = new Context())
            {
                review = context.Reviews.Find(id);
            }

            return review;
        }
    }
}