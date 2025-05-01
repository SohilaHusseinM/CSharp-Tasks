using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Day11;
namespace Day11
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ - Restriction Operators
            #region LINQ - Restriction Operators
            Console.WriteLine("\n========== Restriction Operators ==========");

            // 1. Products Out Of Stock
            Console.WriteLine("\n1. Products Out Of Stock:");
            var productsOutOfStock = ProductList.Where(p => p.UnitsInStock == 0).ToList();
            foreach (var product in productsOutOfStock)
                Console.WriteLine(product.ProductName);

            // 2. Products In Stock with Price > 300
            Console.WriteLine("\n2. Products In Stock with Price > 300:");
            var expensiveProducts = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 300).ToList();
            foreach (var product in expensiveProducts)
                Console.WriteLine(product);

            // 3. Digits with Name Shorter than Value
            Console.WriteLine("\n3. Digits with Name Shorter than Value:");
            string[] digitsArray = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var shortNameDigits = digitsArray.Where((name, index) => name.Length < index);
            foreach (var digit in shortNameDigits)
                Console.WriteLine(digit);
            #endregion

            // LINQ - Element Operators
            #region LINQ - Element Operators
            Console.WriteLine("\n========== Element Operators ==========");

            // 1. First Product Out Of Stock
            Console.WriteLine("\n1. First Product Out Of Stock:");
            var firstOutOfStock = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            Console.WriteLine(firstOutOfStock?.ProductName ?? "None");

            // 2. First Product with Price > 1000
            Console.WriteLine("\n2. First Product with Price > 1000:");
            var highPriceProduct = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            Console.WriteLine(highPriceProduct?.ProductName ?? "None");

            // 3. Second Number > 5
            Console.WriteLine("\n3. Second Number > 5:");
            int[] numbersArray = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var secondNumberGreaterThanFive = numbersArray.Where(n => n > 5).OrderBy(n => n).ElementAtOrDefault(1);
            Console.WriteLine(secondNumberGreaterThanFive);
            #endregion

            // LINQ - Set Operators
            #region LINQ - Set Operators
            Console.WriteLine("\n========== Set Operators ==========");

            // 1. Unique Category Names
            Console.WriteLine("\n1. Unique Category Names:");
            var uniqueCategories = ProductList.Select(p => p.Category).Distinct();
            foreach (var category in uniqueCategories)
                Console.WriteLine(category);

            // 2. Unique First Letters from Product and Customer Names
            Console.WriteLine("\n2. Unique First Letters from Product and Customer Names:");
            var productFirstLetters = ProductList.Select(p => p.ProductName?[0]);
            var customerFirstLetters = CustomerList.Select(c => c.CompanyName?[0]);
            var uniqueFirstLetters = productFirstLetters.Union(customerFirstLetters);
            foreach (var letter in uniqueFirstLetters)
                Console.WriteLine(letter);

            // 3. Common First Letters
            Console.WriteLine("\n3. Common First Letters:");
            var commonFirstLetters = productFirstLetters.Intersect(customerFirstLetters);
            foreach (var letter in commonFirstLetters)
                Console.WriteLine(letter);

            // 4. Product Letters Not in Customer Letters
            Console.WriteLine("\n4. Product Letters Not in Customer Letters:");
            var exclusiveProductLetters = productFirstLetters.Except(customerFirstLetters);
            foreach (var letter in exclusiveProductLetters)
                Console.WriteLine(letter);
            #endregion

            // LINQ - Aggregate Operators
            #region LINQ - Aggregate Operators
            Console.WriteLine("\n========== Aggregate Operators ==========");

            // 1. Total Number of Characters in Dictionary
            Console.WriteLine("\n1. Total Number of Characters in Dictionary:");
            string filePath = "dictionary_english.txt";
            if (File.Exists(filePath))
            {
                var words = File.ReadAllLines(filePath);
                var totalCharacters = words.Sum(w => w.Length);
                Console.WriteLine($"Total Characters: {totalCharacters}");
            }
            else
            {
                Console.WriteLine("Dictionary file not found!");
            }

            // 2. Total Units in Stock by Category
            Console.WriteLine("\n2. Total Units in Stock by Category:");
            var totalUnitsByCategory = ProductList.GroupBy(p => p.Category).Select(g => new {
                Category = g.Key,
                TotalUnits = g.Sum(p => p.UnitsInStock)
            });
            foreach (var category in totalUnitsByCategory)
                Console.WriteLine(category);

            // 3. Shortest Word Length in Dictionary
            Console.WriteLine("\n3. Shortest Word Length in Dictionary:");
            if (File.Exists(filePath))
            {
                var words = File.ReadAllLines(filePath);
                var shortestWordLength = words.Min(w => w.Length);
                Console.WriteLine($"Shortest Word Length: {shortestWordLength}");
            }

            // 4. Cheapest Price in Each Category
            Console.WriteLine("\n4. Cheapest Price in Each Category:");
            var cheapestByCategory = ProductList.GroupBy(p => p.Category).Select(g => new {
                Category = g.Key,
                MinPrice = g.Min(p => p.UnitPrice)
            });
            foreach (var category in cheapestByCategory)
                Console.WriteLine(category);

            // 5. Products with Cheapest Price in Each Category
            Console.WriteLine("\n5. Products with Cheapest Price in Each Category:");
            var cheapestProductsByCategory = ProductList.GroupBy(p => p.Category)
                .Select(g => new {
                    Category = g.Key,
                    Products = g.Where(p => p.UnitPrice == g.Min(p => p.UnitPrice)).Select(p => p.ProductName)
                });
            foreach (var category in cheapestProductsByCategory)
                Console.WriteLine($"{category.Category}: {string.Join(", ", category.Products)}");

            // 6. Most Expensive Price in Each Category
            Console.WriteLine("\n6. Most Expensive Price in Each Category:");
            var mostExpensiveByCategory = ProductList.GroupBy(p => p.Category).Select(g => new {
                Category = g.Key,
                MaxPrice = g.Max(p => p.UnitPrice)
            });
            foreach (var category in mostExpensiveByCategory)
                Console.WriteLine(category);

            // 7. Products with Most Expensive Price in Each Category
            Console.WriteLine("\n7. Products with Most Expensive Price in Each Category:");
            var expensiveProductsByCategory = ProductList.GroupBy(p => p.Category)
                .Select(g => new {
                    Category = g.Key,
                    Products = g.Where(p => p.UnitPrice == g.Max(p => p.UnitPrice)).Select(p => p.ProductName)
                });
            foreach (var category in expensiveProductsByCategory)
                Console.WriteLine($"{category.Category}: {string.Join(", ", category.Products)}");

            // 8. Average Price by Category
            Console.WriteLine("\n8. Average Price by Category:");
            var averagePriceByCategory = ProductList.GroupBy(p => p.Category).Select(g => new {
                Category = g.Key,
                AveragePrice = g.Average(p => p.UnitPrice)
            });
            foreach (var category in averagePriceByCategory)
                Console.WriteLine(category);
            #endregion

            //------------------------ 5 ------------------------------//
            //LINQ - Ordering Operators
            #region LINQ - Partitioning Operators
            Console.WriteLine("\n======================================4==================================\n");
            Console.WriteLine("\n\n########### LINQ - Ordering Operators ###########\n");

            // 1.
            Console.WriteLine("\n1. Sort a list of products by name.\n");
            var prdName = ProductList.OrderBy(P => P.ProductName);

            foreach (var result in prdName)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");

            // 2.
            Console.WriteLine("\n2. Uses a custom comparer to do a case-insensitive sort of the words in an array.\n");

            string[] Arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var cmprInSens = Arr3.OrderBy(Str => Str, new cstmCmprrCaseInsensetive());

            foreach (var result in cmprInSens)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");


            // 3.
            Console.WriteLine("\n3. Sort a list of products by units in stock from highest to lowest.\n");

            var higToLow = ProductList.OrderByDescending(P => P.UnitsInStock);

            foreach (var result in higToLow)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");


            // 4.
            Console.WriteLine("\n4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.\n");

            string[] Arr4 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sortNameAlph = Arr4.OrderBy(N => N.Length).ThenBy(N => N);

            foreach (var result in sortNameAlph)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");


            // 5.
            Console.WriteLine("\n5. Sort first by word length and then by a case-insensitive sort of the words in an array.\n");

            string[] words1 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortLenThnInsens = words1.OrderBy(N => N.Length).ThenBy(N => N, new cstmCmprrCaseInsensetive());

            foreach (var result in sortLenThnInsens)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");

            // 6.
            Console.WriteLine("\n6. Sort a list of products, first by category, and then by unit price, from highest to lowest.\n");

            var sortCatgThnPrc = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);

            foreach (var result in sortCatgThnPrc)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");

            // 7.
            Console.WriteLine("\n7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.\n");

            var Results25 = words1.OrderBy(N => N.Length).ThenByDescending(N => N, new cstmCmprrCaseInsensetive());

            foreach (var result in Results25)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");

            // 8.
            Console.WriteLine("\n8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.\n");

            var revrsdDig = Arr4.Where(D => D[1] == 'i').Reverse().ToList();

            foreach (var result in revrsdDig)
                Console.WriteLine(result);
            #endregion



            //------------------------ 6 ------------------------------//
            //LINQ - Partitioning Operators
            #region LINQ - Partitioning Operators
            Console.WriteLine("\n====================================== 6 ==================================\n");
            Console.WriteLine("\n\n########### LINQ - Partitioning Operators ###########\n");

            // 1.
            Console.WriteLine("\n1. Get the first 3 orders from customers in Washington.\n");

            // no city called Washington in customerList
            var thrOrd = CustomerList.Where(C => C.City == "Washington").Take(3);

            foreach (var result in thrOrd)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");

            // 2.
            Console.WriteLine("\n2. Get all but the first 2 orders from customers in Washington.\n");

            var fstTwoOrd = CustomerList.Where(C => C.City == "Washington").Skip(2);

            foreach (var result in fstTwoOrd)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");

            // 3.
            Console.WriteLine("\n3. Elements starting from the beginning of the array until a number is hit that is less than its position in the array.\n");

            var noLssPos = Arr2.TakeWhile((N, i) => N >= i);

            foreach (var result in noLssPos)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");

            // 4.
            Console.WriteLine("\n4. Get the elements of the array starting from the first element divisible by 3.\n");

            var divBy3 = Arr2.SkipWhile(N => N % 3 != 0);

            foreach (var result in divBy3)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");


            // 5.
            Console.WriteLine("\n5. Get the elements of the array starting from the first element less than its position.\n");

            var fstLssPos = Arr2.SkipWhile((N, i) => N >= i);

            foreach (var result in fstLssPos)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");
            #endregion


            //------------------------ 7 ------------------------------//
            //LINQ - Projection Operators
            #region LINQ - Projection Operators
            Console.WriteLine("\n====================================== 7 ==================================\n");
            Console.WriteLine("\n\n########### LINQ - Projection Operators ###########\n");

            // 1.
            Console.WriteLine("\n1. A sequence of just the names of a list of products.\n");

            var namsOfLstPro = ProductList.Select(P => P.ProductName);

            foreach (var result in namsOfLstPro)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");


            // 2.
            Console.WriteLine("\n2. A sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).\n");
            string[] words2 = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var upprAndLwrr = words2.Select(N => new { Uppercase = N.ToUpper(), Lowercase = N.ToLower() });

            foreach (var result in upprAndLwrr)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");

            // 3.
            Console.WriteLine("\n3. A sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.\n");

            var incldSmProp = ProductList.Select(P => new { Product = P.ProductName, Category = P.Category, Price = P.UnitPrice });

            foreach (var result in incldSmProp)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");

            // 4.
            Console.WriteLine("\n4. Determine if the value of ints in an array match their position in the array.\n");
            Console.WriteLine("Number: In-place?");

            var valMtchPos = Arr2.Select((N, i) => new { Number = N, Matches = N == i });

            foreach (var result in valMtchPos)
                Console.WriteLine($"{result.Number}: {result.Matches}");
            Console.WriteLine("\n----------------------------\n");


            // 5.
            Console.WriteLine("\n5. all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.\n");
            Console.WriteLine("Pairs where a < b:");

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var nmA_lss_nmB = from A in numbersA
                              from B in numbersB
                              where A < B
                              select new { A, B };
            foreach (var result in nmA_lss_nmB)
                Console.WriteLine($"{result.A} is less than{result.B}");
            Console.WriteLine("\n----------------------------\n");


            // 6.
            Console.WriteLine("\n6. Select all orders where the order total is less than 500.00.\n");

            var lessThan500 = CustomerList.SelectMany(O => O.Orders).Where(O => O.Total < 500.00M);

            foreach (var result in lessThan500)
                Console.WriteLine(result);
            Console.WriteLine("\n----------------------------\n");


            // 7.
            Console.WriteLine("\n7. Select all orders where the order was made in 1998 or later.\n");

            var made98OrLater = CustomerList.SelectMany(O => O.Orders).Where(O => O.OrderDate.Year >= 1998);

            foreach (var result in made98OrLater)
                Console.WriteLine($"OrderID: {result.OrderID}, Date: {result.OrderDate:yyyy-MM-dd}, Total: {result.Total}");

            #endregion


            //------------------------ 8 ------------------------------//
            //LINQ - Quantifiers
            #region LINQ - Quantifiers
            Console.WriteLine("\n====================================== 8 ==================================\n");
            Console.WriteLine("\n\n########### LINQ - Quantifiers ###########\n");

            // 1.
            Console.WriteLine("\n1. Determine if any of the words in dictionary contain the substring 'ei'.\n");

            var contain_ei = words.Any(Word => Word.Contains("ei"));

            Console.WriteLine($"Does any word Contains 'ei'? {contain_ei}");
            Console.WriteLine("\n----------------------------\n");


            // 2.
            Console.WriteLine("\n2. A list of products only for categories that have at least one product that is out of stock.\n");

            var atLeast1OutStkk = ProductList.GroupBy(P => P.Category).Where(grp => grp.Any(P => P.UnitsInStock == 0));

            foreach (var group in atLeast1OutStkk)
            {
                Console.WriteLine($"\nCategory: {group.Key}\n");

                foreach (var product in group)
                    Console.WriteLine($"Product Name: {product.ProductName}, Stock: {product.UnitsInStock}");
            }
            Console.WriteLine("\n----------------------------\n");


            // 3.
            Console.WriteLine("\n3. A list of products only for categories that have all of their products in stock.\n");

            var allInStkk = ProductList.GroupBy(P => P.Category).Where(grp => grp.All(P => P.UnitsInStock > 0));

            foreach (var group in allInStkk)
            {
                Console.WriteLine($"\nCategory: {group.Key}\n");

                foreach (var product in group)
                    Console.WriteLine($"Product Name: {product.ProductName}, Stock: {product.UnitsInStock}");
            }


            #endregion


            //------------------------ 9 ------------------------------//
            //LINQ - Projection Operators
            #region LINQ - Projection Operators
            Console.WriteLine("\n====================================== 9 ==================================\n");
            Console.WriteLine("\n\n########### LINQ - Projection Operators ###########\n");

            // 1.
            Console.WriteLine("\n1. A list of numbers by their remainder when divided by 5.\n");
            int[] Numbers = Enumerable.Range(0, 15).ToArray();

            var remBy5 = from N in Numbers
                         let reminder = N % 5
                         group N by reminder into grp
                         select grp;

            foreach (var group in remBy5)
            {
                Console.WriteLine($"\nNumbers with a remainder of {group.Key} when divided by 5:");

                foreach (var numbers in group)
                    Console.WriteLine(numbers);
            }
            Console.WriteLine("\n----------------------------\n");


            // 2.
            Console.WriteLine("\n2. Uses group by to partition a list of words by their first letter.\n");

            var partBy1stLettr = from W in words
                                 group W by W.ElementAtOrDefault(0) into grp
                                 select grp;

            foreach (var group in partBy1stLettr)
            {
                Console.WriteLine($"\nGroup: {group.Key}:");

                foreach (var Words in group)
                    Console.WriteLine(Words);
            }
            Console.WriteLine("\n----------------------------\n");


            // 3.
            Console.WriteLine("\n3. Group By with a custom comparer that matches words that are consists of the same Characters Together.\n");
            string[] Arr5 = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

            var matchSameChar = Arr5.Select(W => W.Trim()).GroupBy(W => W, new CustomComprer());

            foreach (var group in matchSameChar)
            {
                Console.WriteLine($"\n...");

                foreach (var Words in group)
                    Console.WriteLine(Words);
            }

            #endregion



        }
    }
