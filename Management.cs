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

    }
}
