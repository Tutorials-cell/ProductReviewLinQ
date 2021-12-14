using System;
using System.Collections.Generic;

namespace ProjectReviewManagementWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<ProductReview> listProductReview = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 3, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 4, UserId = 4, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 1, Review = "Bad", isLike = false }
            };

            foreach (var list in listProductReview)
            {
                Console.WriteLine("ProductId: " + list.ProductId + " UserId: " + list.UserId + "Rating: " + list.Rating + " Review: " + list.Review + " IsLike: " + list.isLike);
            }

            Console.WriteLine("-------------------------------------------------------------------");

            Management management = new Management();

            //management.TopRecordsList(listProductReview);

            //management.SelectedRecords(listProductReview);

            management.Retrieve(listProductReview);

        }
    }
}

