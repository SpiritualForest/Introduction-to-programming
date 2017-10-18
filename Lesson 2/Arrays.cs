using System;

/* In computer science, an array data structure, or simply an array, 
 * is a data structure consisting of a collection of elements (values or variables),
 * each identified by at least one array index or key.
 *
 * Arrays store groups of objects of a certain type,
 * and are useful in case we need a collection of data.
 * For example, if we wanted to store all the years in which
 * a person attended school, we could use an array:
 *
 * int elementary[] = new int[]{ 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997 };
 * int highschool[] = new int[]{ 1998, 1999, 2000, 2001 };
 *
 * We can then display all those years by iterating over the array,
 * rather than having for example a string object consisting of something like
 * string years = "1991;1992;1993";, which would be cumbersome and inefficient.
 *
 * The data in an array is retrieved via an index number.
 * The first index is 0, which refers to the starting point of an array.
 * This is a source of confusion for beginners, because humans are used
 * to counting from 1, not from 0.
 * The 0-index refers to the start point of the array, and each subsequent
 * index refers to the number of STEPS from the beginning of the array.
 * So index 1, which stores the second element, is positioned one step
 * away from the beginning.
 * Index 2 is 2 steps, 3 is 3 steps from 0, and so forth.
 *
 * Arrays are fixed in size, meaning that once an array has been created in memory,
 * it cannot be resized. If we want a bigger array, we'll have to create a new, bigger one.
 * The size of the array is determined either by the amount of items it was initialized with,
 * or by a size specified by the programmer.
 * 
 * Attempting to assign a value at an index whose number is larger than
 * the size of the array-1 will result in an index out of bounds error.
 * So if the size of the array is 5, trying to assign a value at
 * array[5] will actually result in an error, because the last index is 4, not 5.
 * Trying to assign a value anywhere after array[4] will result in an error.
 * We can get the number of addresses (indexes) in the array using its Length property:
 * myArray.Length; */

namespace Examples {
    static class Arrays {
        public static void ArrayExamples {
            // This is an array of integers. Its elements are the numbers 1 - 10.
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Array size is 10
            int[] elements = new int[10]; // Array size is also 10, but the array contains no items yet
            elements[0] = 100; // Assigning a value to the first address of the array.
            elements[9] = 1000; // Assigning a value to the last address.

            // We can also modify the contents of an existing array
            numbers[0] = 1234; // numbers is now { 1234, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
        
            // And now an array of strings
            string[] students = new string[] { "John Doe", "Joe Sixpack", "Laura FinnishGirl" }; // Array size is 3
            students[1] = "Good Student Guy"; // Modifying the value at the second address
            // Students is now { "John Doe", "Good Student Guy", "Laura FinnishGirl" }
            students[3] = "Someone Special"; // Error, the last index of "students" is 2, not 3.
        }
    }
    
    /* Now we can talk about generic lists.
     * From MSDN, about Generics:
     * Generics were added to version 2.0 of the C# language and the common language runtime (CLR). 
     * Generics introduce to the .NET Framework the concept of type parameters, 
     * which make it possible to design classes and methods that defer the specification of one or more types 
     * until the class or method is declared and instantiated by client code.
     *
     * A generic list is a collection (found in System.Collections.Generic),
     * which allows us to create lists of any data type.
     * For example, we can create a list of int, list of string, list of double, and so forth.
     * We can even create a list of arrays, list of lists, etc. But we won't get into those here.
     *
     * Lists are essentially like the primitive arrays we saw earlier, except they are dynamically sized.
     * That means that lists are essentially unlimited (limited only by how much memory the computer has),
     * and we don't need to manually resize them or recreate them if we need more space.
     * The CLR (Common Language Runtime) will do all this work for us.
     * Lists can also be made Read-Only, something arrays cannot be.
     *
     * This makes lists the better choice for the vast majority of applications,
     * as we might not know immediately how many items we need to store in our collection.
     * 
     * Lists are constructed and initialized as:
     * List<T> myList = new List<T> { items, defined, here };
     * List<int> listOfNumbers = new List<int> { 1, 2, 3, 4 };
     * To add items to the end of the list, we use the Add() method:
     * listOfNumbers.Add(5);
     * We can also use index based value modification, like in primitive arrays,
     * but only if that index already exists in the list.
     * Remember that since lists are dynamically sized, if we initialize an empty list,
     * it will contain no elements, and therefore we will not be able to do something theList[0] = "value";
     * since that will go out of bounds. The index doesn't exist yet.
     * So, we'd need to do theList.Add("value") (if it's a list of strings), and then we can do
     * theList[0] = "new value";
     *
     * Lists are considered a bit slower than primitive arrays,
     * but this difference in performance is negligible, and should not affect one's decision
     * about which type of collection to use. When in doubt, use lists.
     *
     * We can get the count of elements in the list via the Count property:
     * theList.Count; */

    static class GenericLists {
        public static void GenericListExamples {
            /* Create a new list of int */
            List<int> numbers = new List<int>();
            /* Add the number 75 to the list */
            numbers.Add(75); // numbers[0] is now 75
        }
    } // End of class
} // End of namespace
