using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Dec_Gagan_CSharp_Learning.CollectionsExample
{
    [TestClass]
    public class HashTableEx
    {
        [TestMethod]
        public void TestMethod1()
        {
            Hashtable CountryDetails = new Hashtable();
            CountryDetails.Add(91, "India");
            CountryDetails.Add(61, "Austrila");
            CountryDetails.Add(32, "Belgium");
            CountryDetails.Add(975, "Bhutan");
            CountryDetails.Add(55, "Brazil");


            CountryDetails[1] = "Canada";
            CountryDetails.Remove(1);
            foreach (DictionaryEntry cdetails in CountryDetails)
            {
                Console.WriteLine("Key : {0} , Value : {1}" ,cdetails.Key , cdetails.Value);
            }
        }
    }
}
