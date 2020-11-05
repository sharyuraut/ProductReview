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
                new ProductReviewClass(){ProductId=21,UserId=13,Rating=4,Review="Great",IsLike=true},
                new ProductReviewClass(){ProductId=8,UserId=15,Rating=3,Review="Good",IsLike=true},
                new ProductReviewClass(){ProductId=9,UserId=17,Rating=2,Review="Okay",IsLike=true},
                new ProductReviewClass(){ProductId=10,UserId=18,Rating=1,Review="Poor",IsLike=true},
                new ProductReviewClass(){ProductId=11,UserId=19,Rating=5,Review="Super",IsLike=true},
                new ProductReviewClass(){ProductId=12,UserId=21,Rating=4,Review="Great",IsLike=true},
                new ProductReviewClass(){ProductId=13,UserId=23,Rating=10,Review="Good",IsLike=true},
                new ProductReviewClass(){ProductId=14,UserId=25,Rating=2,Review="Okay",IsLike=true},
                new ProductReviewClass(){ProductId=15,UserId=27,Rating=1,Review="Poor",IsLike=true},
                new ProductReviewClass(){ProductId=16,UserId=29,Rating=5,Review="Super",IsLike=true},
                new ProductReviewClass(){ProductId=17,UserId=31,Rating=4,Review="Great",IsLike=true},
                new ProductReviewClass(){ProductId=18,UserId=33,Rating=7,Review="Good",IsLike=true},
                new ProductReviewClass(){ProductId=19,UserId=35,Rating=2,Review="Okay",IsLike=true},
                new ProductReviewClass(){ProductId=20,UserId=37,Rating=1,Review="Poor",IsLike=true},
            };

            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID: " + list.ProductId + " " + "UserID: " + list.UserId + " " + "Rating: " + list.Rating + " " + "Review: " + list.Review + " " + "IsLike: " + list.IsLike);
            }

            Console.WriteLine("Displaying top 3 records---------------");

            Management management = new Management();
            management.TopRecords(productReviewList);

            Console.WriteLine("Displaying records with rating > 3 and id = 1,4,9---------------");

            management.FindRecordForGIvenRatingAndGivenID(productReviewList);
        }


    }
}
