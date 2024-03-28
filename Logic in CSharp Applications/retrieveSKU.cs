//Clothing article SKU retriever that lets users specify by type, color, and size.
    //Includes UI to help users understand how the input string works.
    
Console.WriteLine("Hello.\nPlease enter a SKU Value in the following format: \n<product #>-<2-letter color code>-<size code> (Example: \"01-MN-L\")\nOtherwise, enter \'T\', \'C\', or \'S\' to view the available types, colors, or sizes of clothing available or \'A\' for all information.");
string sku = Console.ReadLine().ToUpper();
bool flag = false;
if (!sku.Contains('-'))
{
    flag=true;
    switch (sku)
    {
        case "T":
            Console.WriteLine("\'01\'\t= Sweat Shirt\n\'02\'\t= T-Shirt\n\'03\'\t= Sweat Pants\nOther\t= Other\n");
            break;
        case "C":
            Console.WriteLine("\'BL\'\t= Black\n\'MN\'\t= Maroon\nOther\t= White\n");
            break;
        case "S":
            Console.WriteLine("\'S\'\t= Small\n\'M\'\t= Medium\n\'L\'\t= Large\nOther\t= Default\n");
            break;
        case "A":
            Console.WriteLine("Types:\n\'01\'\t= Sweat Shirt\n\'02\'\t= T-Shirt\n\'03\'\t= Sweat Pants\nOther\t= Other\n");
            Console.WriteLine("Colors:\n\'BL\'\t= Black\n\'MN\'\t= Maroon\nOther\t= White\n");
            Console.WriteLine("Sizes:\n\'S\'\t= Small\n\'M\'\t= Medium\n\'L\'\t= Large\nOther\t= Default");
            break;
        default:
            Console.WriteLine("\nSorry, there was an error handling your request. Please make sure to use the specified format for input.");
            break;
    }
}

//If user uses proper SKU format
if (!flag)
{
    string[] product = sku.Split('-');
    string type = "";
    string color = "";
    string size = "";

    switch (product[0])
    {
        case "01":
            type = "Sweat shirt";
            break;
        case "02":
            type = "T-Shirt";
            break;
        case "03":
            type = "Sweat pants";
            break;
        default:
            type = "Other";
            break;
    }
    switch (product[1])
    {
        case "BL":
            color = "Black";
            break;
        case "MN":
            color = "Maroon";
            break;
        default:
            color = "White";
            break;
    }
    switch (product[2])
    {
        case "S":
            size = "Small";
            break;
        case "M":
            size = "Medium";
            break;
        case "L":
            size = "Large";
            break;
        default:
            size = "One Size Fits All";
            break;
    }
    Console.WriteLine($"\nProduct: {size} {color} {type}");
}
