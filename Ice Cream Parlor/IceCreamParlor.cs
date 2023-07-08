using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ice_Cream_Parlor
{
    internal class IceCreamParlor
    {
        private object additionalToppings;
        private object toppings;
        private object additionalFlavors;
        public string Flavor { get; set; }
        public string[] AdditionalFlavors { get; set; }
        public string[] Toppings { get; set; }
        public string[] AdditionalToppings { get; set; }

        public IceCreamParlor()
        {
            Flavor = string.Empty;
            Toppings = new string[0];
            AdditionalFlavors = new string[0];
        }

        public void CustomizeIceCream()
        {

        }

        public string Name { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }

        public void MysteryIceCream(string name, string description1, string description2, string description3)
        {

        }

        public void Main()
        {
            string code = "1";

            string userInput = GetUserInput();

            while (userInput != "0")
            {
                string result = userInput == code ? "correct" : "error";

                if (result == "correct")
                {

                }
                else
                {
                    IceCreamParlor iceCream = new IceCreamParlor();
                    iceCream.CustomizeIceCream();
                }

                userInput = GetUserInput();
            }

            static string GetUserInput()
            {
                return Console.ReadLine();
            }
        }
    }
}




    


