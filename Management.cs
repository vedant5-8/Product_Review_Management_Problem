using System.Data;
using System.Linq;

namespace Product_Review_Management_Problem
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID: {0} User ID: {1} Rating: {2} Review: {3} IS Like: {4}",
                    list.ProductID.ToString().PadRight(3),
                    list.UserID.ToString().PadRight(3),
                    list.Rating.ToString().PadRight(3),
                    list.Review.ToString().PadRight(6),
                    list.isLike);
            }

        }

        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.ProductID == 1 && productReviews.Rating > 3) ||
                               (productReviews.ProductID == 4 && productReviews.Rating > 3) || 
                               (productReviews.ProductID == 9 && productReviews.Rating > 3) 
                               select productReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID: {0} User ID: {1} Rating: {2} Review: {3} IS Like: {4}",
                    list.ProductID.ToString().PadRight(3),
                    list.UserID.ToString().PadRight(3),
                    list.Rating.ToString().PadRight(3),
                    list.Review.ToString().PadRight(6),
                    list.isLike);
            }
        }

        public void CountOfRecords(List<ProductReview> listProductReview)
        {
            //var countData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            
            var countData = from review in listProductReview
                            group review by review.ProductID into ProductGroup
                            select new { ProductID = ProductGroup.Key, Count = ProductGroup.Count() };

            foreach (var list in countData)
            {
                Console.WriteLine(list.ProductID + "==> " + list.Count);
            }

        }

    }
}
