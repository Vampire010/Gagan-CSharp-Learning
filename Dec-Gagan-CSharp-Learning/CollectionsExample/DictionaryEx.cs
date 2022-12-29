using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Dec_Gagan_CSharp_Learning.CollectionsExample
{
    [TestClass]
    public class DictionaryEx
    {
        [TestMethod]
        public void TestMethod1()
        {
            IDictionary<int, string> CountryDetails= new Dictionary<int, string>();
            CountryDetails.Add(91, "India");
            CountryDetails.Add(61, "Austrila");
            CountryDetails.Add(32, "Belgium");
            CountryDetails.Add(975, "Bhutan");
            CountryDetails.Add(55, "Brazil");

            CountryDetails[1] = "Canada";
            CountryDetails.Remove(1);
            foreach (KeyValuePair<int,string> cdetails in CountryDetails)
            {
                Console.WriteLine(cdetails);
            }

        }
    }
}
