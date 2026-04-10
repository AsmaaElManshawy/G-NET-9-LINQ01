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

            #endregion

            #region Question 04
            //----------------------------------
            //4.Get all products where UnitPrice is between 10 and 30
            //----------------------------------

            #endregion

            #region Question 05
            //-----------------------------------
            //5.Get all products that are in stock(UnitsInStock > 0) and belong to the "Condiments" category.
            //-----------------------------------

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

            #endregion

            #region Question 07
            //------------------------------------
            //7.Print each product's name along with its position (1-based) in the list.
            //Expected format: 1.Chai, 2.Chang, etc.
            //------------------------------------

            #endregion

            #region Question 08
            //------------------------------------
            //8.Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.
            //------------------------------------

            #endregion

            #region Question 09
            //------------------------------------
            //9.Get all products from the "Beverages" category, sorted by UnitsInStock descending.
            //Print name and stock.
            //------------------------------------

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
