using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Cream_Parlor
{
    internal class CustomizeIceCream
    {
        private object additionalToppings;
        private object toppings;
        private object additionalFlavors;
        public string Flavor { get; set; }
        public string[] AdditionalFlavors { get; set; }
        public string[] Toppings { get; set; }
        public string[] AdditionalToppings { get; set; }
    }
}
