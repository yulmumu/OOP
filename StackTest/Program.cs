using System;
using System.Collections.Generic;

public class Example
{
    public static void Main(string[] args)
    {
        LinkedList<String> countries = new LinkedList<String>();
        countries.AddLast("India");
        countries.AddLast("Mexico");
        countries.AddLast("Japan");
        countries.AddLast("Nepal");
        countries.AddLast("Korea");

        LinkedListNode<String> node = countries.Find("Nepal");
        countries.AddBefore(node, "Australia");
        countries.AddAfter(node, "Canada");
 
        foreach (var country in countries)
        {
            Console.WriteLine(country);
        }
        
        Console.WriteLine("----------");
        countries.Remove(countries.First);
        foreach (var country in countries)
        {
            Console.WriteLine(country);
        }
        
        Console.WriteLine("----------");
        countries.Remove("Australia");
        foreach (var country in countries)
        {
            Console.WriteLine(country);
        }
    }
}