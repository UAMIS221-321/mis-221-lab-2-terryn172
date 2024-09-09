const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.1;
double tipAmount = 0;
double orderCost = 0;

System.Console.WriteLine("Hello and welcome to my sandwhich shop!");

System.Console.WriteLine("How many sandwhiches do you want?");
double numberOfSandwiches = double.Parse(Console.ReadLine());

System.Console.WriteLine("How many toppings do you want?");
double numberOfToppings = double.Parse(Console.ReadLine());

System.Console.WriteLine("Would you like to add a tip? Please enter number as a decimal?");
tipAmount = double.Parse(Console.ReadLine());

double totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
double totalToppingCost = COST_OF_TOPPING * numberOfToppings;
double baseCost = totalSandwichCost + totalToppingCost;

orderCost = tipAmount + baseCost * (1 - DISCOUNT_AMOUNT);
System.Console.WriteLine($"Your total after the 10% discount is {orderCost} thank you for your busniess!");

