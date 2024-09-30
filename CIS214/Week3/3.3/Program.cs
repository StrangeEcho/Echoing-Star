/*****
* name: Ruben Thomas
* date: 5.23.2024
* assignment: CIS214 Week 3 GP - Arrays and Lists
*

* Main application (program) class.
* In this application we will demonstate the creation and use of 
* arrays and lists for holding lists of items. The special for loop is also
* introduiced as a looping mechanism useful when working wiuth arrays
* and lists; commonly called a "for-each" loop. Note that for-each loops
* are only used with collections of things, like arrays and lists
*/ 

using System.Collections.Generic;
using System;
public class App {
    static void  Main(string[] args) {
        Console.WriteLine("\nRuben Thomas - Week 3 GP - Arrays and Lists");

        int[] intArr = new int[10];

        Console.WriteLine("Index\tValue");

        for (int i = 0; i< intArr.Length; i++) {
            Console.WriteLine("{0}\t{1}", i, intArr[i]);
        }
        List<int> intList = new List<int>();

        Console.WriteLine("\nLength of Lists: {0}", intList.Count);

        string[] animalsArr = {"Dog", "Cat", "Goldfish", "Parrot", "Sloth"};

        Console.WriteLine("\nArray Length: {0}", animalsArr.Length);

        foreach(string s in animalsArr){ 
            Console.WriteLine(s);
        }
        List<string> animalsList = new List<string>() {"Dog", "Cat", "Goldfish", "Parrot", "Sloth"};

        Console.WriteLine("\nList Length: {0}", animalsList.Count);

        animalsList.Add("Elephant");
        animalsList.Add("Lion");

        Console.WriteLine("\nLists Length after adding elements: {0}", animalsList.Count);

        foreach (string s in animalsList) {
            Console.WriteLine(s);
        }
    }
}