using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProductReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ-Product Review Program!");

            List<ProductReviewClass> productReviewList = new List<ProductReviewClass>()
            {
                new ProductReviewClass() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReviewClass() { ProductId = 2, UserId = 1, Rating = 5, Review = "Bad", IsLike = true },
                new ProductReviewClass() { ProductId = 3, UserId = 2, Rating = 5, Review = "Good", IsLike = true },
                new ProductReviewClass() { ProductId = 4, UserId = 2, Rating = 5, Review = "Bad", IsLike = true },
                new ProductReviewClass() { ProductId = 5, UserId = 2, Rating = 5, Review = "Good", IsLike = false },
                new ProductReviewClass() { ProductId = 6, UserId = 3, Rating = 5, Review = "Good", IsLike = true },
                new ProductReviewClass() { ProductId = 7, UserId = 6, Rating = 5, Review = "Good", IsLike = false },
                new ProductReviewClass() {ProductId=2, UserId = 3, Rating = 4, Review = "Great", IsLike = true},
                new ProductReviewClass() {ProductId=8, UserId = 5, Rating = 3, Review = "Good", IsLike = true},
                new ProductReviewClass() {ProductId=9, UserId = 7, Rating = 2, Review = "Okay", IsLike = true},
                new ProductReviewClass() {ProductId=1, UserId = 8, Rating = 1, Review = "Poor", IsLike = true},
                new ProductReviewClass() {ProductId=1, UserId = 7, Rating = 5, Review = "Super", IsLike = true},
                new ProductReviewClass() {ProductId=2, UserId = 7, Rating = 4, Review = "Great", IsLike = true},
                new ProductReviewClass() {ProductId=13, UserId = 1, Rating = 10, Review = "Good", IsLike = true},
                new ProductReviewClass() {ProductId=14, UserId = 6,Rating=2, Review = "Okay", IsLike = true},
                new ProductReviewClass() {ProductId=15, UserId = 6, Rating = 1, Review = "Poor", IsLike = true},
                new ProductReviewClass() {ProductId=6, UserId = 10, Rating = 5, Review = "Super", IsLike = true},
                new ProductReviewClass() {ProductId=17, UserId = 10, Rating = 4, Review = "Great", IsLike = true},
                new ProductReviewClass() {ProductId=8, UserId = 10, Rating = 7, Review = "Good", IsLike = true},
                new ProductReviewClass() {ProductId=9, UserId = 10, Rating = 2, Review = "Okay", IsLike = true},
                new ProductReviewClass() {ProductId=2, UserId = 10, Rating = 1, Review = "Poor", IsLike = true},
            };

            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID: " + list.ProductId + " " + "UserID: " + list.UserId + " " + "Rating: " + list.Rating + " " + "Review: " + list.Review + " " + "IsLike: " + list.IsLike);
            }

            Console.WriteLine("\nDisplaying top 3 records---------------");

            Management management = new Management();
            
            management.TopRecords(productReviewList);

            Console.WriteLine("\nDisplaying records with rating > 3 and id = 1,4,9---------------");

            management.FindRecordForGIvenRatingAndGivenID(productReviewList);

            Console.WriteLine("\n Retrieve count of reviews for each productID-----------");

            management.CountRecordsForEachProductID(productReviewList);

            Console.WriteLine("\n ProductId and its review: ");

            management.GetProductIdAndReview(productReviewList);
        }


    }
}
