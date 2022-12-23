using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dec_Gagan_CSharp_Learning.HomyFoods
{
    [TestClass]
    public class Restaurant 
    {
        string restaurantName = "HomyFoods";
        long[] restaurantContactNumber1 = { 9876543210 , 9876543211 , 9876543212 };
        //long restaurantContactNumber2 = 9876543211;
        //long restaurantContactNumber3 = 9876543212;

        string[,] menue = {
                                {"Item 1: " , " Idly"},
                                { "Item 2: ", "Pongal"},
                                {"Item 3: " ,"Coffee"},
                                { "Item 4: ","Tea"},
                                {"Item 5: " , "Milk"}

                           };


        string restaurantAddres = "#2th street , Newton - Newyork";

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("restaurantName: "+ restaurantName);

             for(int i =0; i<restaurantContactNumber1.Length;i++)
             {
                 Console.WriteLine("restaurantContactNumber: " + restaurantContactNumber1[i]);
                if (i == 2)
                {

                    restaurantContactNumber1[2] = 986543218;
                    Console.WriteLine("UpdatedrestaurantContactNumber: " + restaurantContactNumber1[2]);
                }

            }

            /* foreach (long contactNumbers in restaurantContactNumber1)
             {
                 Console.WriteLine("restaurantContactNumber: " + contactNumbers);

             } */

            /* foreach (string foodmenue in menue)
             {
                 Console.Write("restaurantfoodmenue: " + foodmenue);
                 Console.WriteLine();
             } */

            for (int i = 0; i < menue.Length; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    Console.Write(menue[i,j]);
                }
                Console.WriteLine();
            }


        }
    }
}
