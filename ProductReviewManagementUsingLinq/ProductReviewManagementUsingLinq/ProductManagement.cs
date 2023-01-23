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
        public void SelectedRecords(List<ProductReview> review)
        {

            var recordedData = from products in review
                               where (products.ProductId == 1 && products.Rating > 3) ||
                                (products.ProductId == 4 && products.Rating > 3) ||
                                 (products.ProductId == 9 && products.Rating > 3)
                               select products;
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product Id :" + productReview.ProductId + "\t" + "User Id :" + productReview.UserId + "\t" + "Rating :" + productReview.Rating + "\t" + "Review :" + productReview.Review + "\t" + "Is Like :" + productReview.isLike);
            }

        }
        public void RetriviewCountOfRecord(List<ProductReview> reviews)
        {
            var records = reviews.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, count= x.Count() });
            foreach (var record in records)
            {
                Console.WriteLine(record.ProductId + " _________________________" + record.count);
            }
        }
    }

    
}

