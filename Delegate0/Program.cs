// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var p1 = new Person("Bruce Wyane", 32 /* Exercise 4 */);
var p2 = new Person("Marilyn Monroe", 30 /* Exercise 4 */);
var p3 = new Person("John Doe", 40 /* Exercise 4 */);



//Exercise 1
public delegate string GreetNewPerson(Person p);

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person (string name, int age /* Exercise 2 */)
    {
        Name = name;
        Age = age;

        /* Exercise 5 */
    }
}

/* Exercise 3 */


//Design recipe
//1. Define the delegate type (i.e., the function signature)
//2. Create a delegate object (variable) of the delegate type OR create the delegate object as a Method parameter
//3. Implement your Plug-In function(s) with the same signature as the delegate type
//4. Assign the Plug-In functions to the delegate object using “=”, “+=”, or “-=” operators OR invoke the Method with the plug-in as an argument
//5. Invoke the delegate object as a function using the function signature using of delegate type

//Exercise:
// Create a method that as a delegate to the Person class constructor, prints out a greeting to a newly Person 
//1. Done, see above
//2. Create a delegate as a parameter in the constructor of Person in order to great the newly created person
//3. Create the Plug-In method to greet print-out a greetign message
//4. Modify the new Person() to take the plug-in as an argument
//5. In the constructor invoke the delegate

