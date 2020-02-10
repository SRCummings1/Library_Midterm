using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Terminal_Midterm
{
    class Methods
    {
        
        //
        //Access_Modifier - Static_Or_No - Return_Type - Method_Name  (Parameters)
        public            static         string       Greetings(string greeting, string name)     //Method Signature
        //Body of the Method
        {
            greeting = "Hello World";

            greeting = greeting + name;
            greeting += "name";
            string newString = greeting + " name";
            return greeting;
        
        }



    }
}
