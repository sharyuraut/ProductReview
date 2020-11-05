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

        public void TopRecords(List<ProductReviewClass> ProductReviewlist)
        {
            var recordedData = (from productReviews in ProductReviewlist
                                orderby productReviews.Rating descending
                                select productReviews).Take(3).ToList();
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: " + list.ProductId + " UserID: " + list.UserId + " Rating: " + list.Rating + " Review: " + list.Review + " isLike: " + list.IsLike);
            }
        }
    }
}
