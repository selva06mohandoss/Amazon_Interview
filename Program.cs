using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
namespace CSharp.DSA.PackingAlgorithm
{
 public class KnapSackAlgorithm
 {
    static void Main(string[] args)
    {

        int[] size_array = { 1, 3, 5,4};
        int target_box_size = 7;
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        bool isPair = GetMatchedPairedItemSize(size_array, target_box_size);
        Console.WriteLine("IsMatchedPair {0}", isPair);
        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        Console.WriteLine(ts);
        Console.ReadLine();
    }

    public static bool GetMatchedPairedItemSize(int[] size_array, int target_box_size)
    {
       //Created  temporary array to hold the  difference between item and Size Array 
        Hashtable ht = new Hashtable();       
        bool isPair = false;
        for (int i = 0; i < size_array.Length; i++)
        {
            if (size_array[i] > target_box_size)
            {
                continue;
            }
            //If temporary Array contains item  then  matched pair item is identified 
            if (ht.Contains(size_array[i]))
            {
                isPair = true;
            }
            else
            {

                ht[target_box_size - size_array[i]] = i;
                isPair = false;
            }
        }

        return isPair;
    }  

     }



 [TestClass]
 public class PackageAlgorithmUnitTest
 {
     [TestMethod]
     public void GetMatchedPairedItemTestMethod()
     {
           int[] size_array = { 1, 3, 5,4};
            int target_box_size = 7;
            bool isPair = KnapSackAlgorithm.GetMatchedPairedItemSize(size_array, target_box_size);
            Assert.IsTrue(isPair);
             
     }
 }




}



   

