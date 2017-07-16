using System.Web.Mvc;
using Movies.Models;
using Movies.Repositories;

namespace Movies.Controllers
{
    public class ReviewController : Controller
    {
        private ReviewRepository reviewRepository;

        //Submit
        [HttpGet]
        public ActionResult Submit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitReview(Review review)
        {
            if (!ModelState.IsValid)
            {
                return View("Submit");
            }

            reviewRepository = new ReviewRepository();
            reviewRepository.Create(review);
            return RedirectToAction("Reviews");
        }

        //Edit 
        [HttpGet]
        public ActionResult Edit(int id)
        {
            reviewRepository = new ReviewRepository();
            var review = reviewRepository.GetById(id);
            return View(review);
        }

        [HttpPost]
        public ActionResult Edit(Review review)
        {
            reviewRepository = new ReviewRepository();
            reviewRepository.Update(review);
            return RedirectToAction("Reviews");
        }

        [HttpGet]
        public ActionResult Reviews()
        {
            reviewRepository = new ReviewRepository();
            var reviews = reviewRepository.GetAllReviews();

            return View(reviews);
        }

        //Delete
        [HttpGet]
        public ActionResult Delete(int id)
        {
            reviewRepository = new ReviewRepository();
            var review = reviewRepository.GetById(id);
            return View(review);
        }

        
        [HttpPost]
        public ActionResult Delete(Review review)
        {
            reviewRepository = new ReviewRepository();
            reviewRepository.Delete(review.Id);
            return RedirectToAction("Reviews");
        }

        //Details
        [HttpGet]
        public ActionResult Details(int id)
        {
            reviewRepository = new ReviewRepository();

            return View(reviewRepository.GetById(id));
        }
    }

}