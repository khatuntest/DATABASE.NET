using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static Level2_S5.ListGenerators;

namespace Level2_S5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators 
            //1. Find all products that are out of stock.

            //var AllProductOutOfStock = ProductList.Where((P) => P.UnitsInStock == 0);

            //AllProductOutOfStock = from P in ProductList
            //                       where P.UnitsInStock == 0
            //                       select P;

            //foreach (var Product in AllProductOutOfStock)
            //{
            //    Console.WriteLine(Product);
            //}

            //-------------------------------------------------------------------------------------

            //2.Find all products that are in stock and cost more than 3.00 per unit.

            //var Product = ProductList.Where((P) => P.UnitsInStock > 0 && P.UnitPrice > 3);

            //Product = from P in ProductList
            //          where P.UnitsInStock > 0 && P.UnitsInStock > 3
            //          select P;
            //
            //foreach (var Unit in Product)
            //{
            //    Console.WriteLine(Unit);
            //}

            //------------------------------------------------------------------------------------------

            //3.Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Digits = Arr.Where((num, i) => num.Length < i );

            //foreach (var digit in Digits)
            //{
            //    Console.WriteLine(digit);
            //}

            #endregion

            #region Ordering Operators

            //1.Sort a list of products by name

            ////var OrderProductByName = ProductList.Order();OR

            //var OrderProductByName = ProductList.OrderBy((P) => P.ProductName);

            //OrderProductByName = from p in ProductList
            //                     orderby p.ProductName
            //                     select p;

            //foreach (var order in OrderProductByName)
            //{
            //    Console.WriteLine(order);
            //}


            //=========================================================================================

            //2.Uses a custom comparer to do a case -insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var OrderArray = Arr.OrderBy((W) => W , new CaseInsensitiveSort());
            //foreach (var item in OrderArray)
            //{
            //    Console.WriteLine(item);
            //}

            //================================================================================================

            //3.Sort a list of products by units in stock from highest to lowest.

            //var SortProduct = ProductList.OrderByDescending((P) => P.UnitsInStock);

            //SortProduct = from P in ProductList
            //              orderby P.UnitsInStock descending
            //              select P;

            //foreach (var Product in SortProduct)
            //{
            //    Console.WriteLine(Product);
            //}

            //=======================================================================================================

            //4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var SortDigits = Arr.OrderBy((X) => X.Length).ThenBy(Y=> Y);

            //SortDigits = from W in Arr
            //             orderby W.Length , W
            //             select W;

            //foreach (var x in SortDigits)
            //{
            //    Console.WriteLine(x);
            //}

            //====================================================================================================

            //5.Sort first by word length and then by a case -insensitive sort of the words in an array.

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var SortDigits = words.OrderBy(words => words.Length).ThenBy(W => W , new CaseInsensitiveSort());

            //SortDigits = from w in words 
            //             orderby w.Length , w.ToLower()
            //             select w;

            //foreach (var word in SortDigits)
            //{
            //    Console.WriteLine(word);
            //}

            //===================================================================================================

            //6.Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var SortProduct = ProductList.OrderByDescending((P) => P.Category).ThenByDescending((X) => X.UnitPrice);

            //SortProduct = from P in ProductList
            //              orderby P.Category descending , P.UnitPrice descending
            //              select P;

            //foreach (var item in SortProduct)
            //{
            //    Console.WriteLine(item);
            //}

            //==================================================================================================

            //7.Sort first by word length and then by a case -insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            ////var ArraySort = Arr.OrderBy((X) => X.Length).ThenByDescending(X => X, new CaseInsensitiveSort()); OR

            //var ArraySort = from X in Arr
            //            orderby X.Length , X.ToLower() descending
            //            select X;

            //foreach (var item in ArraySort)
            //{
            //    Console.WriteLine(item);
            //}

            //=======================================================================================================

            //8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var list = Arr.Where((x) => x.Length >= 2 && x[1] == 'i').Reverse();

            //list = (from x in Arr
            //       where x.Length >= 2 && x[1] == 'i'
            //       select x).Reverse();

            //foreach ( var x in list)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion

            #region Transformation Operators
            //1.Return a sequence of just the names of a list of products.

            //var Names = ProductList.Select((P) => P.ProductName);

            //Names = from P in ProductList
            //        select P.ProductName;

            //foreach(var name  in Names)
            //{
            //    Console.WriteLine(name);
            //}

            //==================================================================================================

            //2.Produce a sequence of the uppercase and lowercase
            //versions of each word in the original array(Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Upper = words.Select(x => x.ToUpper());
            //var Lower = words.Select(x => x.ToLower());

            //Upper = from w in words
            //        select w.ToUpper();

            //Lower = from w in words
            //        select w.ToLower();

            //Console.WriteLine("The Upper Version.");
            //foreach ( var x in Upper)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine("\nThe Lower Version.");
            //foreach ( var x in Lower)
            //{
            //    Console.WriteLine(x);
            //}

            //==========================================================================================

            //3.Produce a sequence containing some properties of Products,
            //including UnitPrice which is renamed to Price in the resulting type.

            //var ProductProperties = ProductList.Select((P) => new {P.ProductID , P.ProductName , Price = P.UnitPrice});

            //ProductProperties = from P in ProductList
            //                    select new { P.ProductID, P.ProductName, Price = P.UnitPrice };

            //foreach (var Product in ProductProperties)
            //{
            //    Console.WriteLine(Product);
            //}

            //============================================================================================

            //4.Determine if the value of ints in an array match their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var match = Arr.Select((num, i) => num == i);

            //foreach(var num in match)
            //{
            //    Console.WriteLine(num);
            //}

            //==========================================================================

            //5. Returns all pairs of numbers from both arrays such that
            //the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var matchPairs = numbersA.SelectMany((a) => numbersB.Where ((b) => b > a).Select(b => new {A = a , B = b}));

            //matchPairs = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new {A = a , B = b};

            //foreach ( var pair in matchPairs)
            //{
            //    Console.WriteLine(pair);
            //}

            //=================================================================================

            //6. Select all orders where the order total is less than 500.00.

            //var OrderLess500 = CustomerList.SelectMany((c) => c.Orders.Where((O) => O.Total < 500));

            //OrderLess500 = from c in CustomerList
            //               from o in c.Orders
            //               where o.Total < 500
            //               select o;

            //foreach (var order in OrderLess500)
            //{
            //    Console.WriteLine(order);
            //}

            //==========================================================================

            //7.Select all orders where the order was made in 1998 or later.

            //var ListOfOrders = CustomerList.SelectMany((C) => C.Orders.Where((O) => O.OrderDate.Year >= 1998));

            //ListOfOrders = from c in CustomerList
            //               from o in c.Orders
            //               where o.OrderDate.Year >= 1998
            //               select o;

            //foreach (var O in ListOfOrders)
            //{
            //    Console.WriteLine(O);
            //}

            #endregion

        }
    }
}
