using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dec_Gagan_CSharp_Learning.ControlFlow
{
    [TestClass]
    public class Outing
    {

        string condition = "sunny";
        double temp = 45;
        [TestMethod]
        public void TestMethod1()
        {
            if(condition== "sunny")
            {
                if (temp <= 35)
                {
                    Console.WriteLine("Go outside and play");
                }
                else
                {
                    Console.WriteLine("Heat Wave - Stay Home");
                }
            }
            else if (condition == "rainy")
            {
                Console.WriteLine("Stay Home");
            }
            else if (condition == "cloudy")
            {
                Console.WriteLine("Take Umbrella/RainCoat");
            }
            else 
            {
                Console.WriteLine("Invalid Condition");
            }

        }
    }
}
