using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
       
			string time = Console.ReadLine();
        string period = time.Substring(time.Length-2);
        time = time.Substring(0, time.Length-2);
        string hour = time.Substring(0,2);

        if (period == "PM" && hour != "12" ) 
            Console.WriteLine((Convert.ToInt32(hour)+12).ToString() + time.Substring(2));

        else if (period == "AM" && hour == "12") 
            Console.WriteLine((Convert.ToInt32(hour)-12).ToString()+'0' + time.Substring(2));

        else
            Console.WriteLine(time); 
    }
}
