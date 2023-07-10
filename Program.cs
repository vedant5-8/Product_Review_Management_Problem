using Product_Review_Management_Problem;

Console.WriteLine("Product Review Management Problem using LINQ");

List<ProductReview> productReviews = new List<ProductReview>()
{
    new ProductReview(){ ProductID = 1, UserID = 1, Rating = 3, Review = "Good", isLike = true },
    new ProductReview(){ ProductID = 2, UserID = 1, Rating = 2, Review = "Bad", isLike = false },
    new ProductReview(){ ProductID = 3, UserID = 1, Rating = 4.9, Review = "Best", isLike = true },
    new ProductReview(){ ProductID = 4, UserID = 2, Rating = 1, Review = "Worst", isLike = false },
    new ProductReview(){ ProductID = 5, UserID = 2, Rating = 4, Review = "Better", isLike = true },
    new ProductReview(){ ProductID = 6, UserID = 3, Rating = 2, Review = "Bad", isLike = false },
    new ProductReview(){ ProductID = 7, UserID = 3, Rating = 3, Review = "Good", isLike = false },
    new ProductReview(){ ProductID = 8, UserID = 4, Rating = 5, Review = "Best", isLike = true },
    new ProductReview(){ ProductID = 9, UserID = 5, Rating = 4, Review = "Better", isLike = true },
    new ProductReview(){ ProductID = 10, UserID = 6, Rating = 1, Review = "Worst", isLike = false },
    new ProductReview(){ ProductID = 11, UserID = 4, Rating = 2, Review = "Bad", isLike = false },
    new ProductReview(){ ProductID = 12, UserID = 4, Rating = 4, Review = "Better", isLike = true },
    new ProductReview(){ ProductID = 13, UserID = 6, Rating = 4.5, Review = "Best", isLike = true },
    new ProductReview(){ ProductID = 14, UserID = 5, Rating = 3, Review = "Good", isLike = false },
    new ProductReview(){ ProductID = 15, UserID = 8, Rating = 1, Review = "Worst", isLike = false },
    new ProductReview(){ ProductID = 16, UserID = 8, Rating = 2, Review = "Bad", isLike = false },
    new ProductReview(){ ProductID = 17, UserID = 7, Rating = 4, Review = "Better", isLike = true },
    new ProductReview(){ ProductID = 18, UserID = 7, Rating = 3, Review = "Good", isLike = true },
    new ProductReview(){ ProductID = 19, UserID = 9, Rating = 4.6, Review = "Best", isLike = true },
    new ProductReview(){ ProductID = 20, UserID = 9, Rating = 1, Review = "Worst", isLike =  false },
    new ProductReview(){ ProductID = 21, UserID = 10, Rating = 4, Review = "Better", isLike = true },
    new ProductReview(){ ProductID = 22, UserID = 11, Rating = 2, Review = "Bad", isLike = false },
    new ProductReview(){ ProductID = 23, UserID = 11, Rating = 3, Review = "Good", isLike = true },
    new ProductReview(){ ProductID = 24, UserID = 10, Rating = 4.4, Review = "Best", isLike = true },
    new ProductReview(){ ProductID = 25, UserID = 11, Rating = 1, Review = "Worst", isLike = false }
};

Management management = new Management();

while (true)
{
    Console.WriteLine("Select an option: ");
    Console.WriteLine("1. Display all reviews.");
    Console.WriteLine("2. Display top three records.");
    Console.WriteLine("0. Exit");
    Console.WriteLine("==> ");
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            foreach (var list in productReviews)
            {
                Console.WriteLine("Product ID: {0} User ID: {1} Rating: {2} Review: {3} IS Like: {4}",
                    list.ProductID.ToString().PadRight(3),
                    list.UserID.ToString().PadRight(3),
                    list.Rating.ToString().PadRight(3),
                    list.Review.ToString().PadRight(6),
                    list.isLike);
            }
            break;
        case 2:
            management.TopRecords(productReviews);
            break;
        case 0:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Enter valid option.");
            break;
    }
}

