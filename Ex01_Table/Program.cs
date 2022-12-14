using Ex01_Table;

Table[] tableArr = new Table[10];


for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("Enter the width of the table");
        int tableWidth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the height of the table:");
        int tableHeight = Convert.ToInt32(Console.ReadLine());
        if ((tableWidth > 50 && tableWidth < 200) && (tableHeight > 50 && tableHeight < 200))
        {
            Table newTable = new Table(tableWidth, tableHeight);
            tableArr[i] = newTable;  
        }
        else
        {
            throw new ArgumentOutOfRangeException("The dimensions are out of range.");
        }
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine($"{ex.Message}");
        break; 
    }
}

for (int i = 0; i < tableArr.Length; i++)
{
    if (tableArr[i] == null)
    {
        Console.WriteLine("You did not input the correct format. This script will now terminate.");
        break;
    } else
    {
        tableArr[i].showData();
    }
}

Table[] mixedArr = new Table[10];
for (int i = 0; i < 5; i++)
{
    try
    {
        Console.WriteLine("Enter the width of the table");
        int tableWidth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the height of the table:");
        int tableHeight = Convert.ToInt32(Console.ReadLine());
        if ((tableWidth > 50 && tableWidth < 200) && (tableHeight > 50 && tableHeight < 200))
        {
            Table newTable = new Table(tableWidth, tableHeight);
            mixedArr[i] = newTable;
        }
        else
        {
            throw new ArgumentOutOfRangeException("The dimensions are out of range.");
        }
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine($"{ex.Message}");
        break;
    }
}

for (int i = 5; i < 10; i++)
{
    try
    {
        Console.WriteLine("Enter the width of the coffee table");
        int coffeeTableWidth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the height of the coffee table:");
        int coffeeTableHeight = Convert.ToInt32(Console.ReadLine());
        if ((coffeeTableWidth > 40 && coffeeTableWidth < 120) && (coffeeTableHeight > 40 && coffeeTableHeight < 120))
        {
            Table newTable = new CoffeeTable(coffeeTableWidth, coffeeTableHeight);
            mixedArr[i] = newTable;
        }
        else
        {
            throw new ArgumentOutOfRangeException("The dimensions are out of range.");
        }
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine($"{ex.Message}");
        break;
    }
}


for (int i = 0; i < 5; i++)
{
    if (mixedArr[i] == null)
    {
        Console.WriteLine("You did not input the correct format. This script will now terminate.");
        break;
    }
    else
    {
        mixedArr[i].showData();
    }
}

for (int i = 5; i < 10; i++)
{
    if (mixedArr[i] == null)
    {
        Console.WriteLine("You did not input the correct format. This script will now terminate.");
        break;
    }
    else
    {
        ((CoffeeTable)mixedArr[i]).showData();
    }
}



