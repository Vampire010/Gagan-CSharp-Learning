using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dec_Gagan_CSharp_Learning.ControlFlow
{
    [TestClass]
    public class student
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] marks = {26,25,40,41 };
            int sum = 0;
            int totalSubjects = 0;
            Console.WriteLine("Total Number Subjects:" + 4);

            try
            {
                for (int i = 0; i < marks.Length; i++)
                {
                    sum = sum + marks[i];
                }
                double avgmarks = sum / totalSubjects;
                Console.WriteLine("Avg Marks of Student: " + avgmarks);
                Console.WriteLine("Marks Obtaind in subject Maths " + marks[2]);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("ArithmeticException Occured");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException Occured");
            }
            finally
            {

                Console.WriteLine("For More information Contact Adminstartion Office");
            
            }
            hacker();

        }

        public void hacker()
        {
            throw new FieldAccessException("You're system is hacked.....$$$$$$$$$$$$$$$$$$$");
            
        }
    }
}
