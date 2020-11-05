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
                new ProductReviewClass() { ProductId = 5, UserId = 3, Rating = 5, Review = "Good", IsLike = false },
                new ProductReviewClass() { ProductId = 6, UserId = 3, Rating = 5, Review = "Good", IsLike = true },
                new ProductReviewClass() { ProductId = 7, UserId = 6, Rating = 5, Review = "Good", IsLike = false },
            };

            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID: " + list.ProductId + " " + "UserID: " + list.UserId + " " + "Rating: " + list.Rating + " " + "Review: " + list.Review + " " + "IsLike: " + list.IsLike);
            }

        }


    }
}
