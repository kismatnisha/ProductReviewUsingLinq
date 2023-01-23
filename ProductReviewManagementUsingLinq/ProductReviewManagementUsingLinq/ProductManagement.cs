using ProductReviewUsingLINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementUsingLinq
{

    public class ProductManagement
    {
        //********** UC2******
        // Retrieve top 3 records from the list who’s rating is high using LINQ

        public static void RetrieveTopThreeRatedRecords(List<ProductReview> list)
        {
            //using Query Syntax
            var recordedData = (from products in list orderby products.Rating descending select products).Take(3);
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product Id :" + productReview.ProductId + "\t" + "User Id :" + productReview.UserId + "\t" + "Rating :" + productReview.Rating + "\t" + "Review :" + productReview.Review + "\t" + "Is Like :" + productReview.isLike);
            }
        }
    }
}