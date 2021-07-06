using System;
using System.Collections.Generic;

namespace ReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Product review syatem**");
            List<ProductReview> list = new List<ProductReview>()
            {
            new ProductReview() { ProductID = 1, UserID = 22, Rating = 10, Review = "EXCELLENT" },
            new ProductReview() { ProductID = 2, UserID = 23, Rating = 9, Review = "EXCELLENT" },
            new ProductReview() { ProductID = 3, UserID = 24, Rating = 8, Review = "EXCELLENT" },
            new ProductReview() { ProductID = 4, UserID = 25, Rating = 7.7, Review = "GOOD" },
            new ProductReview() { ProductID = 5, UserID = 26, Rating = 7.5, Review = "GOOD" },
            new ProductReview() { ProductID = 6, UserID = 27, Rating = 7, Review = "GOOD" },
            new ProductReview() { ProductID = 7, UserID = 28, Rating = 6.8, Review = "AVERAGE" },
            new ProductReview() { ProductID = 8, UserID = 29, Rating = 6.5, Review = "AVERAGE" },
            new ProductReview() { ProductID = 9, UserID = 30, Rating = 6, Review = "AVERAGE" },
            new ProductReview() { ProductID = 10, UserID = 31, Rating = 5.5, Review = "AVERAGE" },
            new ProductReview() { ProductID = 11, UserID = 32, Rating = 5, Review = "BAD" },
            new ProductReview() { ProductID = 12, UserID = 33, Rating = 4, Review = "BAD" },
            new ProductReview() { ProductID = 13, UserID = 34, Rating = 3, Review = "BAD" },
            new ProductReview() { ProductID = 14, UserID = 35, Rating = 2, Review = "BAD" }
            };
            //foreach (var result in list)
            //{
            //    Console.WriteLine("PRODUCT_ID-" + result.ProductID + "  " + "USER_ID-" + result.UserID + "  " + "RATING-" + result.Rating + "  " + "REVIEW-" + result.Review);
            //}
            Management management = new Management();
            //management.TopRecords(list);
            //management.Retrive(list);
            management.Count(list);
        }
    }
}
