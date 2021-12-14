using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace ProjectReviewManagementWithLinq
{
    public class Management
    {
        public void TopRecordsList(List<ProductReview> review)
        {
            var recordData = (from productReviews in review
                              orderby productReviews.Rating descending
                              select productReviews).Take(3);

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId: " + list.ProductId + " UserId: " + list.UserId + "Rating: " + list.Rating + " Review: " + list.Review + " IsLike: " + list.isLike);
            }
        }

        public void SelectedRecords(List<ProductReview> review)
        {
            var recordData = from productReviews in review
                             where (productReviews.ProductId == 1 ||
                             productReviews.ProductId == 4 ||
                             productReviews.ProductId == 2)
                             && productReviews.Rating > 3
                             select productReviews;

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId: " + list.ProductId + " UserId: " + list.UserId + "Rating: " + list.Rating + " Review: " + list.Review + " IsLike: " + list.isLike);
            }
        }

        public void Retrieve(List<ProductReview> review)
        {
            var recordData = review.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId: " + list.ProductId + "-------" + list.Count);
            }
        }
    }
}
