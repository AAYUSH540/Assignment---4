using System;
public class Person {
    private string _firstName;
    private string _lastName;
    public Person(string first, string last) {
        _firstName = first;
        _lastName = last;
    }
    public string Name => $"{_firstName} {_lastName}";
}
public class Example {
    public static void Main() {
        Console.WriteLine("EXPRESSION BODY DEFINITIONS");
        var person = new Person("Aayush", "Fadia");
        Console.WriteLine($"NAME : {person.Name} , TIME : {DateTime.Now.ToString("hh: mm: ss tt ")}");
    }
}