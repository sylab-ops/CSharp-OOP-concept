using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
   public class School
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string SchoolAddress { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        private string _twitterAddress;

        public string TwitterAddress
        {
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("The twitter new address must begin with @");
                }
            } 
        }

        public School()
            // shortcut to generate constructor using C# magical format i.e by typing.. ctor tab tab key ....>twice
        {
            Name = "Untitled School";
            PhoneNumber = "555-12018";

        }

        public School(string SchoolName,string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;

        }

        public static float AverageThreeScores(float a, float b, float c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public static double  AverageThreeScores(double a, double b, double c) => (a + b + c) / 3;  //Example of fucntion body express and static method

        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        //Override ToString 
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(this.PhoneNumber);
            sb.Append(this.SchoolAddress);
            sb.AppendLine(",");
            sb.Append(this.City);
            sb.AppendLine(",");
            sb.Append(this.Zip);
            sb.AppendLine(",");
            sb.AppendLine(this.State);

            return sb.ToString();
        }
    }
}
