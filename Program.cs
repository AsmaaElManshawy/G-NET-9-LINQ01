using LINQAssignment01.DataSources;
using LINQAssignment01.Models;
using System.Collections.Generic;
using System.Xml.Linq;
using static LINQAssignment01.DataSources.Source;


namespace LINQAssignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment

            #region Question 01
            //--------------------------------------
            //1.Get all products from the "Seafood" category.
            //Print each product's name and price.
            //-------------------------------------

            //var seafoodProducts = ProductList.Where(p => p.Category == "Seafood")
            //                         .Select(p => new {p.ProductName, p.UnitPrice });

            //foreach (var p in seafoodProducts)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

            #endregion

            #region Question 02
            //--------------------------------------
            //2.Get a list of only the product names from ProductList.
            //Print each name.
            //-------------------------------------

            //var productNames = ProductList.Select(p => p.ProductName);

            //foreach (var name in productNames)
            //    Console.WriteLine(name);

            #endregion

            #region Question 03
            //-------------------------------------
            //3.Sort all products by UnitPrice(ascending).
            //Print each product's name and price.
            //-------------------------------------

            //var sortedByPrice = ProductList.OrderBy(p => p.UnitPrice);

            //foreach (var p in sortedByPrice)
            //    Console.WriteLine($"Name : {p.ProductName} - Price : {p.UnitPrice}");

            #endregion

            #region Question 04
            //----------------------------------
            //4.Get all products where UnitPrice is between 10 and 30
            //----------------------------------

            //var midRangeProducts = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //foreach (var p in midRangeProducts)
            //    Console.WriteLine($"Name : {p.ProductName} - Price : {p.UnitPrice}");

            #endregion

            #region Question 05
            //-----------------------------------
            //5.Get all products that are in stock(UnitsInStock > 0) and belong to the "Condiments" category.
            //-----------------------------------

            //var condimentsInStock = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //foreach (var p in condimentsInStock)
            //    Console.WriteLine($"Name : {p.ProductName} - Price : {p.UnitPrice} - Stock : {p.UnitsInStock} - Category : {p.Category}");

            #endregion

            #region Question 06
            //-----------------------------------
            //6.Create a new anonymous type with three properties:
            //● Name → the product name
            //● Price → the unit price
            //● StockStatus → a string: "Available" if UnitsInStock > 0,
            //otherwise "Out of Stock"
            //● Print the result.
            //---------------------------------

            //var productStatus = ProductList.Select(p => new { Name = p.ProductName, Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock" } );

            //foreach (var p in productStatus)
            //    //Console.WriteLine($"{p.Name} - {p.Price} - {p.StockStatus}");
            //    Console.WriteLine(p);


            #endregion

            #region Question 07
            //------------------------------------
            //7.Print each product's name along with its position (1-based) in the list.
            //Expected format: 1.Chai, 2.Chang, etc.
            //------------------------------------

            //var indexedProducts = ProductList.Select((p, index) => new { Index = index + 1, p.ProductName });

            //foreach (var p in indexedProducts)
            //    Console.WriteLine($"{p.Index}.{p.ProductName}");

            #endregion

            #region Question 08
            //------------------------------------
            //8.Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.
            //------------------------------------

            //var sortedProducts = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var p in sortedProducts)
            //    Console.WriteLine($"Category : {p.Category} - Name : {p.ProductName} - Price : {p.UnitPrice}");

            #endregion

            #region Question 09
            //------------------------------------
            //9.Get all products from the "Beverages" category, sorted by UnitsInStock descending.
            //Print name and stock.
            //------------------------------------

            //var beverages = ProductList.Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock)
            //    .Select(p => new { p.ProductName, p.UnitsInStock });

            //foreach (var p in beverages)
            //    Console.WriteLine($"Name : {p.ProductName} - Stock : {p.UnitsInStock}");

            #endregion

            #region Question 10
            //------------------------------------
            //10.Using QUERY SYNTAX with a compound from clause,
            //list all orders placed in 1997 or later
            //showing CustomerID and OrderDate.
            //-------------------------------------

            #endregion

            #region Question 11
            //-------------------------------------
            //11.Show position number alongside ProductName
            //-------------------------------------

            #endregion

            #region Question 12
            //-------------------------------------
            //12.Sort first by-word length and then by a
            //case -insensitive sort of the words in an array.
            //--------------------------------------
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            #endregion

            #region Question 13
            //--------------------------------------
            //13.Create a list of all digits in the array whose second
            //letter is 'i' that is reversed from the order in the original array.
            //--------------------------------------
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine","ten" };

            #endregion

            #endregion

        }
    }
}
