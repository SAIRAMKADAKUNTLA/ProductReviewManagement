using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ReviewManagement
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview>productlist)
        {
            var record= (from ProductReview in productlist
                         orderby ProductReview.Rating descending
                         select ProductReview).Take(3);
            foreach(var r in record)
            {
                Console.WriteLine("PRODUCT_ID-" + r.ProductID + "  " + "USER_ID-" + r.UserID + "  " + "RATING-" + r.Rating + "  " + "REVIEW-" + r.Review);
            }
        }
    }
}
