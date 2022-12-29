using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dec_Gagan_CSharp_Learning.ControlFlow
{
    [TestClass]
    public class restoFoods
    {
        [TestMethod]
        public void OrderFood()
        {
            Console.WriteLine("Enetr the food Item to order : ");
            string orderFood = Console.ReadLine();
            Console.ReadKey();

            switch (orderFood)
            {
                case "Kabab":
                    Console.WriteLine("Ordered Item Found and the price of "+orderFood + " : is 100");
                    break;

                case "Biriyani":
                    Console.WriteLine("Ordered Item Found and the price of " + orderFood + " : is 100");
                    break;

                case "Pizza":
                    Console.WriteLine("Ordered Item Found and the price of " + orderFood + " : is 100");
                    break;

                case "Juice":
                    Console.WriteLine("Ordered Item Found and the price of " + orderFood + " : is 100");
                    break;

                default:Console.WriteLine("Ordered Item Not Found");
                    break;

            }

        }

       
    }
}
