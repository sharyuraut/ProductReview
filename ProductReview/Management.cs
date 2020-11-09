using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace ProductReview
{
    class Management
    {
        public readonly DataTable datatable = new DataTable();

        //UC 2
        /// <summary>
        /// Get Top records
        /// </summary>
        /// <param name="ProductReviewlist"></param>
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
        /// <summary>
        /// Get record for given rating and given id
        /// </summary>
        /// <param name="ProductReviewlist"></param>
        public void FindRecordForGIvenRatingAndGivenID(List<ProductReviewClass> ProductReviewlist)
        {
            var data = (from productReviews in ProductReviewlist
                        where (productReviews.Rating > 3 && (productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9))
                        select productReviews).ToList();
            foreach (var list in data)
            {
                Console.WriteLine("ProductID: " + list.ProductId + " UserID: " + list.UserId + " Rating: " + list.Rating + " Review: " + list.Review + " IsLike: " + list.IsLike);
            }
        }

        /// <summary>
        /// Count records for each id
        /// </summary>
        /// <param name="productReviewList"></param>
        internal void CountRecordsForEachProductID(List<ProductReviewClass> productReviewList)
        {
            var countRecords = productReviewList.GroupBy(x => x.ProductId).Select(x => new { productID = x.Key, Count = x.Count() });
            foreach (var list in countRecords)
            {
                Console.WriteLine(list.productID + "----" + list.Count);
            }
        }

        /// <summary>
        /// Get product id and reviews
        /// </summary>
        /// <param name="productReviewList"></param>
        public void GetProductIdAndReview(List<ProductReviewClass> productReviewList)
        {
            var recordedData = from productReview in productReviewList select new { productReview.ProductId, productReview.Review };

            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + "-->" + list.Review);
            }
        }


        /// <summary>
        /// Skip top 5 records
        /// </summary>
        /// <param name="productReviewList"></param>
        public void SkipTop5Records(List<ProductReviewClass> productReviewList)
        {
            var recordedData = (from productReview in productReviewList select productReview).Skip(5);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID : " + list.ProductId + " " + "UserID : " + list.UserId
                    + " " + "Rating : " + list.Rating + " " + "Review : " + list.Review + " " + "isLike : " + list.IsLike);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productReviewList"></param>
        public void InsertValuesInDataTable(List<ProductReviewClass> productReviewList)
        {
            datatable.Columns.Add("ProductId", typeof(int));
            datatable.Columns.Add("UserId", typeof(int));
            datatable.Columns.Add("Rating", typeof(double));
            datatable.Columns.Add("Review");
            datatable.Columns.Add("IsLike", typeof(bool));

            foreach (ProductReviewClass product in productReviewList)
            {
                datatable.Rows.Add(product.ProductId, product.UserId, product.Rating, product.Review, product.IsLike);
            }
        }

        public void GetRecordsWithIsLikeTrue()
        {
            var recordedData = from ProductReviewClass in datatable.AsEnumerable()
                               where ProductReviewClass.Field<bool>("IsLike") == true
                               select ProductReviewClass;

            foreach (var product in recordedData)
            {
                Console.WriteLine("ProductID : " + product.Field<int>("ProductId") + " " + "UserId : " + product.Field<int>("UserId")
                    + " " + "Rating : " + product.Field<double>("Rating") + " " + "Review : " + product.Field<string>("Review") + " "
                    + "IsLike : " + product.Field<bool>("IsLike"));
            }
        }
    }
}
