using System.Text;



void PrintHello(string message)
{
    var finalmessage = "Hello," + " " + message;
    Console.WriteLine(finalmessage);
}

string GetName()
{
//     string firstname; // Anonymous variable until a value is assigned
//     // Console.WriteLine(firstname);
//     // var firstname = "shon";
//     firstname = "shon";
//     firstname = "chase";

//     string lastname = "stewman";

//     string fullname = firstname + " " + lastname; // Expression that combines the first name, an empty space, and a last name
//     return fullname;
    Console.WriteLine("what is your name");
    var name = Console.ReadLine();
    return name;
}

string fullname = GetName();
PrintHello(fullname);
