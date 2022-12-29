using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Dec_Gagan_CSharp_Learning.CollectionsExample
{
    [TestClass]
    public class Citynames
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*  List<string> citynames = new List<string>();
              citynames.Add("New york");
              citynames.Add("Bangalore");
              citynames.Add("Chicago");
              citynames.Add("Sydney"); */

            List<int> evenNum = new List<int>();
            evenNum.Add(2);
            evenNum.Add(4);
            evenNum.Add(6);
            evenNum.Add(8);
            evenNum.Add(10);

           
            List<int> oddNum = new List<int>();
            oddNum.Add(1);
            oddNum.Add(3);
            oddNum.Add(5);
            oddNum.Add(7);
            oddNum.Add(9);

            List<int> Numbers = new List<int>(evenNum);
            Numbers.AddRange(oddNum);

            Numbers.Sort();
            foreach (var num in Numbers)
            {

                Console.WriteLine(num);
            }



        }
    }
}
