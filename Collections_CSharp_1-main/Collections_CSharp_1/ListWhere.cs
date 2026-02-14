using System;
using System.Linq;

namespace Collections_CSharp_1
{
    public class ListWhere
    {
        public static void UsingListWhere()
        {
            // Creating a list of groceries
            List<Products> groceries = new List<Products>
            {
                new Products { Name = "Milk", Price = 2.99 },
                new Products { Name = "Bread", Price = 1.99 },
                new Products { Name = "Eggs", Price = 3.49 },
                new Products { Name = "Cheese", Price = 4.99 }
            };

            // Using the Where method to filter products with a price greater than 3.00
            // Store the filtered products in a new list called cheaperProducts
            // The "Where" clause is used to filter the products based on the specified condition (Price > 3.00).
            // And it returns NOT A LIST but instead  an IEnumerable<Products> that contains only the products that satisfy the condition.
            //ToList() method is then called to convert the filtered IEnumerable<Products> into a List<Products>.
            List<Products> cheaperProducts = groceries.Where(product => product.Price < 3.00).ToList();

            // Displaying the filtered list of products
            Console.WriteLine("Products with a price less than $3.00:");
            foreach (Products product in cheaperProducts)
            {
                Console.WriteLine("Name: {0}, Price: ${1}", product.Name, product.Price);
            }


        }
    }
}