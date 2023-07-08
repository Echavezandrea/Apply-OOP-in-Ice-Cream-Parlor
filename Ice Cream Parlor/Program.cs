using System;
using System.IO;

class IceCreamParlor
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
        Toppings = new string[0];
        AdditionalFlavors = new string[0];
    }

    public void CustomizeIceCream()
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"  Flavor                :  {Flavor}");
        Console.WriteLine($"  Additional Flavors    :  {additionalFlavors}");
        Console.WriteLine($"  Toppings              :  {toppings}");
        Console.WriteLine($"  Additional Toppings   :  {additionalToppings}");
        Console.WriteLine("***************************************************************************");

    }

    class Program
    {
        static void Main()
        {
            string code = "1";

            //INTRO
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                ICE CREAM PARLOR MENU GENERATOR                            ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Press 1 - Mystery Ice Cream");
            Console.WriteLine("Press 2 - Customize Ice Cream");
            Console.WriteLine("___________________________________________________________________________");
            Console.Write("Enter your choice: ");

            string userInput = Console.ReadLine();


            while (userInput != "0")
            {
                string result = userInput == code ? "correct" : "error";

                if (result == "correct")
                {
                    //MYSTERY ICE CREAM OPTION LAYOUT
                    Console.WriteLine("                                                                           ");
                    Console.WriteLine("                                                                           ");
                    Console.WriteLine("___________________________________________________________________________");
                    Console.WriteLine("                           MYSTERY ICE CREAM                               ");
                    Console.WriteLine("___________________________________________________________________________");
                    Console.WriteLine(" Enter 1 : Mystery Ice Cream ?                                     ");
                    Console.WriteLine(" Enter 2 : Mystery Ice Cream ?                                     ");
                    Console.WriteLine(" Enter 3 : Mystery Ice Cream ?                                     ");
                    Console.WriteLine(" Enter 4 : Mystery Ice Cream ?                                     ");
                    Console.WriteLine(" Enter 5 : Mystery Ice Cream ?                                     ");
                    Console.WriteLine("                                                                           ");
                    Console.WriteLine("                                                                           ");
                    Console.WriteLine("                                                           Press 2 - Menu  ");
                    Console.WriteLine("___________________________________________________________________________");
                    Console.Write("Mystery Ice Cream #: ");
                    userInput = Console.ReadLine();



                    // LIST OF CHOICES TO MYSTERY ICE CREAM
                    switch (userInput)
                    {
                        case "1":
                            MysteryIceCream("*  YOUR MYSTERY ICE CREAM IS: SNICKER SUNDAE                              *", "*  Chocolate Ice Cream, Hot fudge, Caramel, Spanish peanuts               *", "*  topped with whipped cream and cherry                                   *", "*                                                                         *");
                            break;
                        case "2":
                            MysteryIceCream("*  YOUR MYSTERY ICE CREAM IS: TRIPPLE BERRY MARBLE                        *", "*  Three layers of Vanilla ice cream, Strawberry, blueberry               *", "*  raspberries and topped with whipped cream and cherry                   *", "*                                                                         *");
                            break;
                        case "3":
                            MysteryIceCream("*  YOUR MYSTERY ICE CREAM IS: COOKIE MONSTER SUNDAE                       *", "*  Two scoops each of Cookie Dough and Cookies 'N Cream ice cream         *", "*  topped with hot fudge, cookie dough bites, crushed Oreo, chocolate     *", "*  syrup, whipped cream, sprinkles, and a chocolate chip cookie           *");
                            break;
                        case "4":
                            MysteryIceCream("*  YOUR MYSTERY ICE CREAM IS: PEANUT BUTTER CUP                           *", "*  Chocolate ice cream covered in a creamy peanut butter sauce, hot fudge,*", "*  peanut butter cups topped with whipped cream and cherry                *", "*                                                                         *");
                            break;
                        case "5":
                            MysteryIceCream("*  YOUR MYSTERY ICE CREAM IS: RASPBERRY FUDGE TORTE                       *", "*  Raspberry Fudge Torte ice cream with hot fudge                         *", "*  raspberries topped with whipped cream and cherry                       *", "*                                                                         *");
                            break;
                    }
                }
                else
                {
                    IceCreamParlor iceCream = new IceCreamParlor();

                    // LIST OF CHOICES 
                    string[] flavors = { "Chocolate", "Strawberry", "Vanilla", "Mint Chip", "Cookie Dough" };
                    string[] additionalFlavors = { "---", "+ Caramel Swirl", "+ Cookie Dough", "+ Peanut Butter Cups", "+ Mocha", "+ Black Forest" };
                    string[] toppings = { "Sprinkles", "Chocolate Sauce", "Whipped Cream", "Cherries", "Oreo Crumbs", "Choco roll" };
                    string[] additionalToppings = { "---", "+ Sprinkles", "+ Chocolate Sauce", "+ Whipped Cream", "+ Cherries", "+ Oreo Crumbs", "+ Choco roll" };



                    // CUSTOMIZE ICRE CREAM LAYOUT
                    Console.WriteLine("");
                    Console.WriteLine("\n___________________________________________________________________________");
                    Console.WriteLine("                       CUSTOMIZE YOUR ICE CREAM                            ");
                    Console.WriteLine("___________________________________________________________________________");



                    //FLAVOR
                    Console.WriteLine("Flavor:                                                             ");
                    Console.WriteLine("___________________________________________________________________________");
                    for (int i = 0; i < flavors.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {flavors[i]}");
                    }
                    Console.WriteLine("___________________________________________________________________________");
                    Console.Write("Enter your choice: ");

                    int flavorChoice = int.Parse(Console.ReadLine()) - 1;
                    iceCream.Flavor = flavors[flavorChoice];



                    //ADDITIONAL FLAVOR
                    Console.WriteLine("\n Additional Flavors:");
                    Console.WriteLine("___________________________________________________________________________");
                    for (int i = 0; i < additionalFlavors.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {additionalFlavors[i]}");
                    }
                    Console.WriteLine("___________________________________________________________________________");
                    Console.Write("Enter your choice: ");

                    int additionalFlavorsInput = int.Parse(s: Console.ReadLine()) - 1;
                    string[] additionalFlavorsArray = additionalFlavors[additionalFlavorsInput].Split(',');
                    iceCream = additionalFlavor(iceCream, additionalFlavors, additionalFlavorsInput);



                    //TOPPINGS
                    Console.WriteLine("\n Toppings:");
                    Console.WriteLine("___________________________________________________________________________");
                    for (int i = 0; i < toppings.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {toppings[i]}");
                    }
                    Console.WriteLine("___________________________________________________________________________");
                    Console.Write("Enter your choice: ");

                    int toppingsInput = int.Parse(Console.ReadLine()) - 1;
                    string[] toppingsArray = toppings[toppingsInput].Split(',');
                    iceCream = Topping(iceCream, toppings, toppingsInput);



                    //ADDITIONAL TOPPINGS
                    Console.WriteLine("\n Additional Toppings:");
                    Console.WriteLine("___________________________________________________________________________");
                    for (int i = 0; i < additionalToppings.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {additionalToppings[i]}");
                    }
                    Console.WriteLine("___________________________________________________________________________");
                    Console.Write("Enter your choice: ");

                    int additionalToppingsInput = int.Parse(Console.ReadLine()) - 1;
                    string[] additionalToppingsArray = additionalToppings[additionalToppingsInput].Split(',');
                    iceCream = additionalTopping(iceCream, additionalToppings, additionalToppingsInput);



                    // CUSTOMIZE LAYOUT RESULT
                    Console.WriteLine("");
                    Console.WriteLine("\n***************************************************************************");
                    Console.WriteLine("*                 Customize Ice Cream Details:                            *");
                    iceCream.CustomizeIceCream();
                    Console.WriteLine("*                     ENJOY YOUR ICE CREAM                                *");
                    Console.WriteLine("***************************************************************************");

                }


                //OPTION
                Console.WriteLine("\n                                                                           ");
                Console.WriteLine("\n- - - - - - - - - - - - - - - - - - -  - - - - - - - - - - - - - - - - - - ");
                Console.WriteLine("___________________________________________________________________________");
                Console.WriteLine("                ICE CREAM PARLOR MENU GENERATOR                            ");
                Console.WriteLine("___________________________________________________________________________");
                Console.WriteLine("Press 1 - Mystery Ice Cream                                                ");
                Console.WriteLine("Press 2 - Customize Ice Cream                                              ");
                Console.WriteLine("                                                           Press 0 to exit ");
                Console.WriteLine("___________________________________________________________________________");
                Console.Write("Enter your choice: ");
                userInput = Console.ReadLine();
            }


            //OUTRO
            Console.WriteLine("");
            Console.WriteLine("Thank you for trusting and visiting my Ice Cream Parlor Menu Generator");
            Console.WriteLine("Enjoy your Ice Cream!");
            Console.WriteLine("~ Andrea A. Echavez |BSCPE 1-1 ");
        }


        // METHODS TO CUSTOMIZE ICE CREAM

        private static IceCreamParlor additionalTopping(IceCreamParlor iceCream, string[] additionalToppings, int additionalToppingsInput)
        {
            iceCream = NewMethod3(iceCream, additionalToppings, additionalToppingsInput);
            return iceCream;
        }

        private static IceCreamParlor NewMethod3(IceCreamParlor iceCream, string[] additionalToppings, int additionalToppingsInput)
        {
            iceCream.additionalToppings = additionalToppings[additionalToppingsInput];
            return iceCream;
        }

        private static IceCreamParlor Topping(IceCreamParlor iceCream, string[] toppings, int toppingsInput)
        {
            iceCream = NewMethod2(iceCream, toppings, toppingsInput);
            return iceCream;
        }

        private static IceCreamParlor NewMethod2(IceCreamParlor iceCream, string[] toppings, int toppingsInput)
        {
            iceCream.toppings = toppings[toppingsInput];
            return iceCream;
        }

        private static IceCreamParlor additionalFlavor(IceCreamParlor iceCream, string[] additionalFlavors, int additionalFlavorsInput)
        {
            iceCream = NewMethod1(iceCream, additionalFlavors, additionalFlavorsInput);
            return iceCream;
        }

        private static IceCreamParlor NewMethod1(IceCreamParlor iceCream, string[] additionalFlavors, int additionalFlavorsInput)
        {
            iceCream.additionalFlavors = additionalFlavors[additionalFlavorsInput];
            return iceCream;
        }



        // METHODS TO MYSTERY ICE CREAM
        static void MysteryIceCream(string name, string description1, string description2, string description3)
        {
            Console.WriteLine("                                                                           ");
            Console.WriteLine("                                                                           ");
            Console.WriteLine("                                                                           ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(name);
            Console.WriteLine("*_________________________________________________________________________*");
            Console.WriteLine(description1);
            Console.WriteLine(description2);
            Console.WriteLine(description3);
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                                                                           ");
            Console.WriteLine("                                                                           ");
            Console.WriteLine("                                                                           ");

        }
    }
}


