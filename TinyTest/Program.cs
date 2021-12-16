// See https://aka.ms/new-console-template for more information
using TinyTest;

Console.WriteLine("Tiny Test");

var ExampleObject = new ExampleClass(id : 451242, name: "Jon");
var ExampleDerivedObject = new ExampleDerivedClass(id: 255434, name: "Paul", description: "Description of Paul");

Console.WriteLine(ExampleObject.Everything());
Console.WriteLine(ExampleDerivedObject.Everything());

var query = new TinyQueries();
query.LINQQuery();

var serializer = new TinySerializer();
serializer.SerializeJSON(ExampleDerivedObject);

Console.ReadLine();