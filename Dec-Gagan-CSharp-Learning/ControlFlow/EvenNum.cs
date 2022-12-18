using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dec_Gagan_CSharp_Learning.ControlFlow
{
    [TestClass]
    public class EvenNum
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("**********Using while*************");

            int num = 2;
            do
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("EvenNum is: " + num);
                }
                num++;
            }
            while (num <= 10);

            Console.WriteLine("***************r*************");

        }



        [TestMethod]
        public void TestMethod2() 
        {
            Console.WriteLine("**********Using for*************");

            for (int i =0; i<=10;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("EvenNum is: " + i);
                }

            }
            Console.WriteLine("***************r*************");
        }
        [TestMethod]
        public void TestMethod3() 
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {

                    if (i <= 6)
                    {
                        //break;
                        continue;
                    }
                    Console.WriteLine("EvenNum is: " + i);

                }

            }


        }
    }
}
