using System;
using System.Linq;
using static LINQ_Demo.ListGenerators;

namespace LINQ_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Implicitly Typed Local Variable [var, dynamic]

            //var Data = 22.3; // double
            /// Compiler Will Detect Variable Datatype Based On Its Initial Value at Compilation Time
            /// Must be Initialized
            /// Can't be Initialized with null
            /// After Initialization, U Can't Change its datatype

            //dynamic Data2; // double
            /// CLR Will Detect Variable Datatype Based On Its Last Value in RunTime
            /// Not Must be initialized
            /// Can be initialized with null
            /// After Initialization, U Can Change its datatype

            //Data2 = "Hello";
            //Data2 = null;
            //Data2 = 66;

            #endregion

            #region Extension Method

            //int X = 12345;
            //int Y = IntExtensions.Reverse(X); // 54321
            //Y = X.Reverse(); // Syntax Sugar
            //Console.WriteLine(Y);

            #endregion

            #region Anonymous Type

            //var E01 = new { ID = 10, Name = "Ahmed", Salary = 20202 };

            //Console.WriteLine(E01.GetType().Name); // AnonymousType0`3
            //Console.WriteLine(E01);

            ////E01.ID = 20; // Immutable Object, You Can't Change

            ////var E04 = E01 with { ID = 13 }; C# 10.0 Feature 


            //var E02 = new { ID = 10, Name = "Hamada", Salary = 34342 };
            //Console.WriteLine(E02.GetType().Name); // AnonymousType0`3
            ///// Same Anonymous Class as long as =>
            ///// 1. Same Properties Names (Case Sensitive)
            ///// 2. Same Properties Datatype
            ///// 3. Same Properties Order

            //var E03 = new { ID = 10, FullName = "Ali", Salary = 22323 };
            //Console.WriteLine(E03.GetType().Name); // AnonymousType1`3

            //var product = new { ProductID = 102, ProductName = "Meat" };
            //Console.WriteLine(product.GetType().Name); // AnonymousType2`2

            #endregion

            #region Restriction | Filtration operator [where]
            ///1. Find all products that are out of stock.
            //var result = ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var p in result)
            //    Console.WriteLine(p);

            ///2. Find all products that are in stock and cost more than 3.00 per unit.
            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00m).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ///3. Returns digits whose name is shorter than their value.
            ///indexed where
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var filteredDigits = Arr.Where((digit, index) => digit.Length < index);
            //Console.WriteLine("Digits whose name is shorter than their value:");
            //foreach (var digit in filteredDigits)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion

            #region Ordering Operators
            ///Sort a list of products by name
            //var sortedProducts = ProductList.OrderByDescending(p => p.ProductName);
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            ///Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            ////1.without LINQ
            //// Use the custom case-insensitive comparer for sorting
            //Array.Sort(Arr, new CaseInsensitiveComparer());

            //// Print the sorted array
            //foreach (string word in Arr)
            //{
            //    Console.WriteLine(word);
            //}


            //2.with LINQ
            //var sortedArr = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //// Print the sorted array
            //foreach (string word in sortedArr)
            //{
            //    Console.WriteLine(word);
            //}


            //Sort a list of products by units in stock from highest to lowest.

            //var sortedlst = ProductList.OrderByDescending(x => x.UnitsInStock);
            //foreach (var str in sortedlst)
            //{
            //    Console.WriteLine(str);
            //}

            //4. Sort a list of digits, first by length of their name,
            //and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var sortedArr = Arr.OrderBy(word => word.Length).ThenBy(word => word);

            //foreach (var item in sortedArr)
            //{
            //    Console.WriteLine(item);
            //}


            ////Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedArr = Arr.OrderBy(word => word.Length).ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in sortedArr)
            //{
            //    Console.WriteLine(item);
            //}


            ////6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var sortedProducts = ProductList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in sortedProducts)
            //{
            //    Console.WriteLine(item);
            //}


            ////7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedArr = Arr.OrderBy(word => word.Length).ThenByDescending(word => StringComparison.OrdinalIgnoreCase);
            //foreach (var item in sortedArr)
            //{
            //    Console.WriteLine(item);
            //}


            ////8. Create a list of all digits in the array whose second letter is 'i' that is reversed
            ////from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var filteredDigits = Arr
            //    .Where(word => word.Length >= 2 && word[1] == 'i')
            //    .Reverse();

            //// Create a list from the filtered and reversed sequence
            //List<string> resultList = filteredDigits.ToList();

            //// Print the list
            //foreach (string word in resultList)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region Transformation Operators [select - selectMany]
            ////1. Return a sequence of just the names of a list of products.
            //var productNames = ProductList.Select(p => p.ProductName);

            //foreach (var productName in productNames)
            //    Console.WriteLine(productName);


            ////2. Produce a sequence of the uppercase and lowercase versions of each word
            ////in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Upperlst = words.Select(word => new
            //{
            //    UpperCase = word.ToUpper(),
            //    LowerCase = word.ToLower(),
            //});

            //foreach (var item in Upperlst)
            //    Console.WriteLine($"UpperCase :: {item.UpperCase} LowerCase :: {item.LowerCase}");


            //3. Produce a sequence containing some properties of Products,
            //including UnitPrice which is renamed to Price in the resulting type.

            //var productV02 = ProductList.Select(Product => new
            //{
            //    Product.ProductID, 
            //    Product.ProductName,
            //    Price = Product.UnitPrice
            //});

            //foreach (var item in productV02)
            //{
            //    Console.WriteLine(item);
            //}


            //Determine if the value of int in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var match = Arr.Select((value, index) => value == index);
            //Console.WriteLine("Number in Place:");
            //for (int i = 0; i < match.Count(); i++)
            //{
            //    Console.WriteLine($"{Arr[i]}::{match.ElementAt(i)}");
            //}


            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { NumberA = a, NumberB = b };

            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"{pair.NumberA} is less than {pair.NumberB}");
            //}

            //  //6. Select all orders where the order total is less than 500.00.
            //  var ordersLessThan500 = CustomerList
            //.SelectMany(customer => customer.Orders.Where(order => order.Total < 500.00m))
            //.ToList();


            //  ///*************
            //  foreach (var order in ordersLessThan500)
            //  {
            //      Console.WriteLine($"Order ID: {order.OrderID}, Total: {order.Total:C}");
            //  }


            //Select all orders where the order was made in 1998 or later.

            //var orderin1998OrLater = CustomerList.SelectMany(customer => customer.Orders.Where(order => order.OrderDate.Year >= 1998)).ToList();
            //foreach (var item in orderin1998OrLater)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Set Operators
            ////1.Find the unique Category names from Product List
            //var UniqueCategoryNames = ProductList.Select(product => product.Category).Distinct();

            //foreach(var item in UniqueCategoryNames)
            //{
            //    Console.WriteLine(item);
            //}

            //2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var uniqueFirstLetters = ProductList.Select(product => product.ProductName.FirstOrDefault())
            //                         .Union(CustomerList.Select(customer => customer.CustomerName.FirstOrDefault()))
            //                         .Distinct();

            //foreach (var item in uniqueFirstLetters)
            //{
            //    Console.WriteLine(item);
            //}

            ////3. Create one sequence that contains the common first letter from both product and customer names.

            //var seq01 = ProductList.Select(product => product.ProductName.FirstOrDefault());
            //var seq02 = CustomerList.Select(customer => customer.CustomerName.FirstOrDefault());

            //var result = seq01.Intersect(seq02);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ///AnotherSolution
            //var commonFirstLetter = ProductList.Select(product => product.ProductName.FirstOrDefault())
            //                         .Intersect(CustomerList.Select(customer => customer.CustomerName.FirstOrDefault()))
            //                         ;

            //foreach (var item in commonFirstLetter)
            //{
            //    Console.WriteLine(item);
            //}


            ////4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = seq01.Except(seq02).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            /// 5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var productSeq = ProductList.Select(product => new string(product.ProductName.TakeLast(3).ToArray()));
            //var customerSeq = CustomerList.Select(customer => new string(customer.CustomerName.TakeLast(3).ToArray()));
            //var result = productSeq.Concat(customerSeq);

            //foreach (var item in result)
            //{
            //    Console.Write(item+"  ");
            //}


            //    var lastThreeChars = ProductList
            //.SelectMany(product => product.ProductName.Reverse().Take(3))
            //.Concat(CustomerList.SelectMany(customer => customer.CustomerName.Reverse().Take(3)))
            //.ToList();

            //    foreach (char character in lastThreeChars)
            //    {
            //        Console.WriteLine(character);
            //    }

            //List<int> List = new List<int>() { 1,2,3,4,5,6,7,8,9};
            //List<int> List01 = new List<int>() { 1,2,3,4,5,6,7,8,9};


            //var result = List.Concat(List01);
            //foreach (var item in result)
            //{
            //    Console.Write(item);
            //}

            #endregion

            #region Aggregate Operators
            ////1. Get the total units in stock for each product category.
            //var categorCountForEachProduct = (from P in ProductList
            //                                  group P by P.Category into categoryGroup
            //                                  select categoryGroup.Key).Count();

            //Console.WriteLine(categorCountForEachProduct);
            ////Key => the value which is the collection group based on it 

            ////2. Get the cheapest price among each category's products
            //var cheapestPricesByCategory = from product in ProductList
            //                               group product by product.Category into categoryGroup
            //                               select new
            //                               {
            //                                   Category = categoryGroup.Key,
            //                                   CheapestPrice = categoryGroup.Min(p => p.UnitPrice)
            //                               };

            //foreach (var categoryPrice in cheapestPricesByCategory)
            //{
            //    Console.WriteLine($"Category: {categoryPrice.Category}, Cheapest Price: {categoryPrice.CheapestPrice}");
            //}

            ///3. Get the products with the cheapest price in each category (Use Let)
            //var cheapestPricesByCategory = from product in ProductList
            //                               group product by product.Category into categoryGroup 
            //                               let _CheapestPrice = categoryGroup.Min(product => product.UnitPrice)
            //                               select new
            //                               {
            //                                   Category = categoryGroup.Key,
            //                                   CheapestPrice = _CheapestPrice
            //                               };

            //foreach (var categoryPrice in cheapestPricesByCategory)
            //{
            //    Console.WriteLine($"Category: {categoryPrice.Category}, Cheapest Price: {categoryPrice.CheapestPrice}");
            //}



            ////another solution using let
            //var cheapestProductsByCategory = from product in ProductList
            //                                 group product by product.Category into categoryGroup
            //                                 let cheapestPrice = categoryGroup.Min(p => p.UnitPrice)
            //                                 select new
            //                                 {
            //                                     Category = categoryGroup.Key,
            //                                     CheapestPrice = cheapestPrice,
            //                                     CheapestProducts = categoryGroup.Where(p => p.UnitPrice == cheapestPrice)
            //                                 };

            //foreach (var categoryData in cheapestProductsByCategory)
            //{
            //    Console.WriteLine($"Category: {categoryData.Category}, Cheapest Price: {categoryData.CheapestPrice}");

            //    foreach (var product in categoryData.CheapestProducts)
            //    {
            //        Console.WriteLine($"Product Name: {product.ProductName}, Price: {product.UnitPrice}");
            //    }
            //}


            ///4. Get the most expensive price among each category's products.
            //var MostExpensiveProducts = from product in ProductList
            //                            group product by product.Category
            //                            into newGroup
            //                            select new
            //                            {
            //                                Category = newGroup.Key,
            //                                expensivePrice = newGroup.Max(price => price.UnitPrice)
            //                            };

            //foreach (var item in MostExpensiveProducts)
            //{
            //    Console.WriteLine($"Category :: {item.Category} Most Expensive Price :: {item.expensivePrice}");
            //}


            ///5. Get the products with the most expensive price in each category.
            //var MostExpensiveProducts = from product in ProductList
            //                            group product by product.Category
            //                            into newGroup
            //                            let expensivePrice = newGroup.Max(p => p.UnitPrice)
            //                            select new
            //                            {
            //                                Category = newGroup.Key,
            //                                ExpensivePrice = expensivePrice,
            //                                ExpensiveProducts = newGroup.Where(p => p.UnitPrice == expensivePrice)
            //                            };

            //foreach (var item in MostExpensiveProducts)
            //{
            //    Console.WriteLine($"Category :: {item.Category} Most Expensive Price :: {item.ExpensivePrice}");

            //    foreach (var product in item.ExpensiveProducts)
            //    {
            //        Console.WriteLine($"Product Name: {product.ProductName}, Price: {product.UnitPrice}");
            //        Console.WriteLine("-------------------------------------------------");
            //    }
            //}

            ///Get the average price of each category's products.
            //var productswithAVGPrice = from product in ProductList
            //                           group product by product.Category
            //                           into AVGPriceLst 
            //                           select AVGPriceLst.Average(_product => _product.UnitPrice);

            //foreach (var AvgPrice in productswithAVGPrice)
            //{
            //    Console.WriteLine(AvgPrice);
            //}
            #endregion

            #region Partitioning Operators
            ////1.Get the first 3 orders from customers in Washington
            //var first3Orders = from customer in CustomerList
            //                   where customer.City == "Washington"
            //                   select customer.Orders.Take(3);

            //foreach (var orderList in first3Orders)
            //{
            //    foreach (var order in orderList)
            //    {
            //        Console.WriteLine($"Order ID: {order.OrderID}, Date: {order.OrderDate}");
            //    }

            //}

            ///2. Get all but the first 2 orders from customers in Washington.
            //var ordersFromWashington = from customer in CustomerList
            //                           where customer.City == "Berlin"
            //                           select customer.Orders.Skip(2);

            //var allButFirst2Orders = ordersFromWashington.SelectMany(orders => orders);

            //foreach (var order in allButFirst2Orders)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}, Date: {order.OrderDate}");
            //}

            ////3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var elementsLessThanItsIndex = numbers.TakeWhile((num,index) => num > index);
            //foreach (var element in elementsLessThanItsIndex)
            //{
            //    Console.WriteLine(element);
            //}
            ///4.Get the elements of the array starting from the first element divisible by 3.
            //int [] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            //var elementsLessThanItsPosition = numbers.SkipWhile(num => num % 3 != 0);
            //foreach (var element in elementsLessThanItsPosition)
            //{
            //    Console.WriteLine(element);
            //}

            ///5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var elementsLessThanItsPosition = numbers.SkipWhile((num, index) => num > index);
            //foreach (var element in elementsLessThanItsPosition)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion

            #region Quantifiers Operators
            /*
             Determine if any of the words in dictionary_english.txt 
            (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
             
             */

            //string[] words;

            //try
            //{
            //    // Read the file into an array of strings
            //    words = File.ReadAllLines("dictionary_english.txt");
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("The file 'dictionary_english.txt' was not found.");
            //    return;
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("An error occurred while reading the file.");
            //    return;
            //}

            //var wordsContains_ei = words.Any(str => str.Contains("ei"));
            //Console.WriteLine(wordsContains_ei);


            ///2. Return a grouped  list of products only for categories that have at least one 
            ///tproduct hat is out of stock.

            //var categoriesWithAllInStock = from product in ProductList
            //                               group product by product.Category into categoryGroup
            //                               where categoryGroup.Any(p => p.UnitsInStock == 0)
            //                               select categoryGroup;

            //foreach (var categoryGroup in categoriesWithAllInStock)
            //{
            //    Console.WriteLine($"Category: {categoryGroup.Key}");
            //    foreach (var product in categoryGroup)
            //    {
            //        Console.WriteLine($"Product Name: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //    }
            //}

            /*
             3. Return a grouped a list of products only for categories that have all of their products in stock.
             */



            //var categoriesWithAllInStock = from product in ProductList
            //                               group product by product.Category into categoryGroup
            //                               where categoryGroup.All(p => p.UnitsInStock > 0)
            //                               select categoryGroup;

            //foreach (var categoryGroup in categoriesWithAllInStock)
            //{
            //    Console.WriteLine($"Category: {categoryGroup.Key}");
            //    foreach (var product in categoryGroup)
            //    {
            //        Console.WriteLine($"Product Name: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //    }
            //}


            #endregion

            #region Casting Operators - Immediate Execution

            //List<Product> products = ProductList.Where(P => P.UnitsInStock == 0).ToList();

            //Product[] PrdArr = ProductList.Where(P => P.UnitsInStock == 0).ToArray();

            //Dictionary<long, Product> PrdDic = ProductList.Where(P => P.UnitsInStock == 0)
            //                                                .ToDictionary(P => P.ProductID);


            //Dictionary<long, string> PrdDic = ProductList.Where(P => P.UnitsInStock == 0)
            //                                                .ToDictionary(P => P.ProductID, P => P.ProductName);

            //HashSet<Product> PrdSet = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();

            #endregion

            #region Element operator - Immediate Execution
            //1. Get first Product out of Stock 
            //var firstOutStockProduct = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(firstOutStockProduct);

            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var firstProductGt1000 = ProductList.FirstOrDefault(p => p.UnitPrice > 0);
            //Console.WriteLine(firstProductGt1000);

            //if i used ProductList.First(p => p.UnitPrice > 0) and there is no match this will throw exception
            //if i used ProductList.FirstOrDefault(p => p.UnitPrice > 0); and there is no match will return null
            //because product is a class which is reference type and the default value of it is null

            //3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondNumGT5 = Arr.Where(x => x > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(secondNumGT5);

            //Skip(); returns collection so i used [FirstOrDefault()] to select first element in the collection



            #endregion

            #region Aggregate Operators - Immediate Execution
            //1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var CountOfoddNumbers = Arr.Count(x => x % 2 == 1);
            //Console.WriteLine(CountOfoddNumbers);

            //Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var totalNumbers = Arr.Count();
            //Console.WriteLine(totalNumbers);

            #region Dictionary q

            //string[] words;

            //try
            //{
            //    // Read the file into an array of strings
            //    words = File.ReadAllLines("dictionary_english.txt");
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("The file 'dictionary_english.txt' was not found.");
            //    return;
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("An error occurred while reading the file.");
            //    return;
            //}

            // Calculate the total number of characters in all words
            //int totalCharacterCount = words.Sum(word => word.Length);

            //Console.WriteLine($"Total number of characters in all words: {totalCharacterCount}");

            /*
             Get the length of the shortest word in dictionary_english.txt 
             (Read dictionary_english.txt into Array of String First).
            */

            // Find the length of the shortest word
            //int shortestLength = words.Min(word => word.Length);
            //Console.WriteLine($"Length of the shortest word: {shortestLength}");

            ////find the length of longest word
            //int maxLength = words.Max(word => word.Length);
            //Console.WriteLine($"Length of the longest word: {maxLength}");

            ////find average length of the words 
            //double angLength = words.Average(word => word.Length);
            //Console.WriteLine($"Length of the longest word: {angLength}");

            #endregion



            #endregion
        }

    }
}