using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace ProductReview
{
    class Management
    {
        public readonly DataTable dt = new DataTable();

        //UC 2
        public void TopRecords(List<ProductReviewClass> ProductReviewlist)
        {
            var recordedData = (from productReviews in ProductReviewlist
                                orderby productReviews.Rating descending
                                select productReviews).Take(3).ToList();
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: " + list.ProductId + " UserID: " + list.UserId + " Rating: " + list.Rating + " Review: " + list.Review + " IsLike: " + list.IsLike);
            }
        }

        //UC 3

        public void FindRecordForGIvenRatingAndGivenID(List<ProductReviewClass> ProductReviewlist)
        {
            var data = (from productReviews in ProductReviewlist
                        where (productReviews.Rating > 3 && (productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9))
                        select productReviews).ToList();
            Console.WriteLine("\n");
            foreach (var list in data)
            {
                Console.WriteLine("ProductID: " + list.ProductId + " UserID: " + list.UserId + " Rating: " + list.Rating + " Review: " + list.Review + " IsLike: " + list.IsLike);
            }
        }

    }
}
