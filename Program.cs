using Hometask5;


var myIcebox = new Icebox("IceCream", 20m);

//Console.WriteLine($"Icebox was created. Product: {myIcebox.SortOfIceCream}\t Capacity: {myIcebox.AmountofIceCream} kg\t Containing Amount: {myIcebox.RemainingIceCream} kg"); 
//Console.WriteLine($"Fullness of: {myIcebox.SortOfIceCream}'s bag is {myIcebox.FullnessofIceCream}%");

myIcebox.IceCreamforSale("BananaIceCream", 5m);
myIcebox.IceCreamforSale("StraberryIceCream", 5m);
myIcebox.IceCreamforSale("VanillaIceCream", 5m);
myIcebox.IceCreamforSale("ChocolateIceCream", 5m);

myIcebox.PrintBagsContents();
Console.WriteLine("\n");
Console.WriteLine($"Fullness of {myIcebox.SortOfIceCream}'s bag is {myIcebox.FullnessofIceCream:F1}%");
Console.WriteLine($"Containing Amount: {myIcebox.RemainingIceCream}kg");

try
{
    myIcebox.TakeIceCreamOut("StraberryIceCream", 5.25m);
    //myIcebox.TakeIceCreamOut("VanillaIceCream", 2.5m);
    //myIcebox.TakeIceCreamOut("ChocolateIceCream", 2.75m);
    Console.WriteLine("\n");
}
catch (Exception ex)
{
    Console.WriteLine($"The Icebox is empty");
    Console.WriteLine($"Error Message: {ex.Message}");
}
Console.WriteLine($"Fullness of {myIcebox.SortOfIceCream}'s bag is {myIcebox.FullnessofIceCream:F1}%");
Console.WriteLine($"Containing Amount: {myIcebox.RemainingIceCream}kg");