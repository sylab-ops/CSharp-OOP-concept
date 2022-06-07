using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
   public abstract class Person 
   //abstract class to prevent external modification
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        public abstract float ComputeGradeAvg();
        public virtual string SendMessage(string message)
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Sent on{0:D at {0:t}", DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.AppendLine("");
            sb.AppendLine("Dear " + FirstName + ",");
            sb.AppendLine(message);
            return sb.ToString();

        }
    }
}
