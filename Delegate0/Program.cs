// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var p1 = new Person("Bruce Wyane", 32);
var p2 = new Person("Marilyn Monroe", 30);
var p3 = new Person("John Doe", 40);



//step 1
public delegate string GreetNewPerson(Person p);

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person (string name, int age)
    {
        Name = name;
        Age = age;
    }
}



//Design recipe
//1. Define the delegate type (i.e., the function signature)
//2. Create a delegate object (variable) of the delegate type OR create the delegate object as a Method parameter
//3. Implement your Plug-In function(s) with the same signature as the delegate type
//4. Assign the Plug-In functions to the delegate object using “=”, “+=”, or “-=” operators OR invoke the Method with the plug-in as an argument
//5. Invoke the delegate object as a function using the function signature using of delegate type

//Exercise:
//2. Create a delegate as a parameter in the constructor of Person in order to great the newly created person
//3. Create the Plug-In method to greet print-out a greetign message
//4. Modify the constructor to take the plug-in as a parmeter
//5. In the constructor invode the delegate

