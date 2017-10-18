using System;
using System.Collections.Generic;

namespace Sorting {
    /* Merge sorting algorithm */
    static class MergeSort {
        private static List<int> Merge(ref List<int> a, ref List<int> b) {
            /* Merge the two sorted lists */
            List<int> merged = new List<int>();
            while((a.Count > 0) && (b.Count > 0)) {
                /* We always compare the first two elements of the lists against each other.
                 * The smaller element gets added to the sorted list, and removed from its original list. */
                if (a[0] < b[0]) {
                    /* The element on list a is smaller than on b.
                     * We add it to the merged list and remove it from "a". */
                    merged.Add(a[0]);
                    a.RemoveAt(0);
                }
                else {
                    /* This time b is the smaller element. It goes first. */
                    merged.Add(b[0]);
                    b.RemoveAt(0);
                }
            }
            if (a.Count == 0) {
                /* a is empty. Add the rest of b */
                merged.AddRange(b);
            }
            else {
                /* b is empty. Add the rest of a */
                merged.AddRange(a);
            }
            /* Return the merged list */
            return merged;
        }

        public static List<int> Sort(List<int> elements) {
            /* Here we split the big list "elements" into two smaller lists
             * using recursion until the list only has one element in it.
             * A one-element list is sorted by default.
             * After we get a list with one element, we start merging upwards until
             * we get one big sorted list. */
            if (elements.Count > 1) {
                int cutoff = elements.Count / 2;
                // List.GetRange(int start, int amount); Get <amount> elements from <start>
                List<int> a = Sort(elements.GetRange(0, cutoff));
                List<int> b = Sort(elements.GetRange(cutoff, elements.Count - cutoff));
                return Merge(ref a, ref b);
            }
            else {
                /* Return a new one-element list */
                return new List<int>{ elements[0] };
            }
        }
        public static string Sort(string line) {
            /* Overloaded method for Sort().
             * Convert the string to a List<int> based on the Unicode values for each character,
             * then pass that to the List<int> Sort() method. */
            List<int> unicodeValues = new List<int>();
            foreach(char letter in line) {
                // Cast to int and add to the elements list
                unicodeValues.Add((int)letter);
            }
            // Call the "original" Sort() method
            List<int> sortedUnicodeValues = Sort(unicodeValues);

            // Create a new char array of sortedUnicodeValues.Count length
            char[] sortedChars = new char[sortedUnicodeValues.Count];
            
            for(int i = 0; i < sortedUnicodeValues.Count; i++) {
                // Cast all unicode values (ints) to char
                sortedChars[i] = (char)sortedUnicodeValues[i];
            }
            /* Convert the sortedChars char array to a single string */
            string sortedString = new string(sortedChars);
            return sortedString;
        }
    }

    /* Insertion sorting algorithm */
    static class InsertionSort {
        public static List<int> Sort(List<int> elements) {
            if (elements.Count < 2) {
                /* Less than 2 elements. Sorted by default */
                return elements;
            }
            /* Take each element on the list and
             * repeatedly compare it against all elements before it,
             * until the element being compared against it is larger than, or equals it. */
            int x, finalPosition;
            for(int i = 1; i < elements.Count; i++) {
                // i = 1 because we need to start at the second index.
                // It makes no sense to compare the element at index 0 against itself ;)
                int element = elements[i];
                finalPosition = i;
                for(x = i-1; x >= 0 && element < elements[x]; x--) {
                    /* Start comparing the element at index i against the first one before it (i-1).
                     * As long as x is larger than or equals 0, and the element at index i
                     * is smaller than the one at index x, we set the final insertion position to x's current position,
                     * and continue to loop backwards (x--) */
                    finalPosition = x;
                }
                /* After the nested loop, x is the final index on which to insert the element. */
                elements.RemoveAt(i);
                elements.Insert(finalPosition, element);
            }
            return elements;
        }
    }
}
