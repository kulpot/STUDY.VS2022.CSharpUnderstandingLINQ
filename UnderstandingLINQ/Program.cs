using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace UnderstandingLINQ ////Language Intergrated Querry Syntax to provide filter, sort and perform any aggregated collection of data types
{                           //2 types of style of LINQ syntax --1. querry syntax  2. method syntax
                            
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make = "Toyota", Model = "4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make = "BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make = "Ford", Model = "Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make = "BMW", Model = "55i", StickerPrice=57000, Year=2010 },

            };

            ///&& --logical and operator
            ///bmws ---subset collection
            ///var ---keyword, a different conotation on C# vs other programming lang. ex. javascript, visual basic. etc... does not mean the same  
            // var ---can create very complex querries , no worries of datatype return

            /////-------LINQ Query Syntax
            // LINQ query   criteria = from,where,select
            /*
            var bmws = from car in myCars
                      where car.Make == "BMW"
                      && car.Year == 2010
                      select car;
            */
            /* var orderedCars = from car in myCars
                               orderby car.Year descending
                               select car;
            */

            ////------- LINQ Method Syntax
            //ex.p => p.Make == "BMW"  -- Lambda expression(mini method)
            //Lambda expression --ex.  
            //.Where statements
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            //var orderedCars = myCars.OrderByDescending(p => p.Year);  // Lambda expre
            // var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW"); -----method chainning


            /*  ///How to use .First
            var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");

            Console.WriteLine(firstBMW.VIN);
            */


            // Compact Line of code ---alot of functionality in very small space
            // myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            ///different king of lambda expression
            //myCars.ForEach(p => p.StickerPrice -= 3000);
            // myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            //true of false aggregate function  .Exists
            //Console.WriteLine(myCars.Exists(p => p.Model == "745li"));
            //.Sum aggragate function
            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            /////--------------------------------
            ///-----formula ---p => p.StickerPrice---look for ex. online, create a cheat sheet
            ////------------------------------

            //foreach (var car in bmws)
            /*foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            }
            */

            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007));

            //grandparent of all objects---system.object
            //.GetType Method --all datatypes
            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType());

            //
            //where statement
            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            Console.WriteLine(bmws.GetType());

            //explaining the var keyword
            var newCars = from car in myCars     ///anonymous types
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select new { car.Make, car.Model };
            Console.WriteLine(newCars.GetType());

            Console.ReadLine();


        }
    }

    class Car
    {
        public string VIN { get; set;}
        public string Make { get; set;}
        public string Model { get; set;}
        public int Year { get; set;}
        public double StickerPrice { get; set;}

    }
}