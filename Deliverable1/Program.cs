// See https://aka.ms/new-console-template for more information


//Current Stock Value
int currentSoda = 100;
int currentChips = 40;
int currentCandy = 60 ;

//Restock Value
int restockSoda = 40;
int restockChips = 20;
int restockCandy = 40;

Console.WriteLine("Welcome to the restocking tool.");

//Soda
Console.WriteLine("How many Sodas have been sold today? 100 in Stock: ");
string input2 = Console.ReadLine();
int numOfSoda = int.Parse(input2);

// Compare
if (numOfSoda <= currentSoda)
{
    currentSoda = currentSoda - numOfSoda;
    Console.WriteLine("There are " + currentSoda + " Sodas left");
}else 
{
    Console.WriteLine("That value is too high. Stock not adjusted");
}

//Chips
Console.WriteLine("How many Chips have been sold today? 40 in Stock: ");
string input3 = Console.ReadLine();
int numOfChips = int.Parse(input3);

// Compare
if (numOfChips <= currentChips)
{
    currentChips = currentChips - numOfChips;
    Console.WriteLine("There are " + currentChips + " Chips left");
} else
{
    Console.WriteLine("That value is too high. Stock not adjusted");
}

//Candy
Console.WriteLine("How many Candies have been sold today? 60 in Stock: ");
string input4 = Console.ReadLine();
int numOfCandy = int.Parse(input4);

// Compare
if (numOfCandy <= currentCandy )
{
    currentCandy = currentCandy - numOfCandy;
    Console.WriteLine("There are " + currentCandy + " Candy left");
} else
{
    Console.WriteLine("That value is too high. Stock not adjusted");
}

//Check what needs to be restocked
Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");
if (currentSoda <= restockSoda) {
    Console.WriteLine("Sodas need to be restocked");
}
if (currentChips <= restockChips) {
        
    Console.WriteLine("Chips need to be restocked");
}
if (currentCandy <= restockCandy) {
    Console.WriteLine("Candy need to be restocked");
}

Console.WriteLine("Goodbye!");