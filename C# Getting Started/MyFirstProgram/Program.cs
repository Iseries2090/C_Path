using MyUtilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstProgram // Note: actual namespace depends on the project name.
{

    public class Program
    {

        public static void Main(string[] args)
        {
            WeatherUtilities.Report("Bologna", 23, 65); //~73F
        }
    }
}