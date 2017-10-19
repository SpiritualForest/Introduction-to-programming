/* Here we have examples of various types of loops */

/* Loops are an integral part of computer programming,
 * allowing programs to execute a given block of code repeatedly,
 * without the programmer having to manually execute the code each time.
 *
 * For example, to write 3 lines to the console using Console.WriteLine(), we could do:
 * Console.WriteLine(1);
 * Console.WriteLine(2);
 * Console.WriteLine(3);
 *
 * For only 3 lines, this isn't so bad. But what if we wanted to write 100, or 1000 lines?
 * Using a simple for-loop (describe below), we could instruct the computer to
 * write 1000 lines to the console window, with us only having to write that instruction once:
 *
 * for(int i = 0; i < 1000; i++) {
 *    Console.WriteLine(i);
 * }
 *
 * This will call the Console.WriteLine() method 1000 times,
 * until the value of "i" (our counter) is no longer less than 1000. */

using System;

namespace Examples {
    static class WhileLoop {
        /* While loop: a while loop is a control flow statement that allows code to be executed repeatedly based on a given Boolean condition. 
         * The while loop can be thought of as a repeating if statement.
         * 
         * On each repetition of the loop (known as an iteration), the loop condition (the one inside the parentheses) is evaluated. 
         * If the evaluation results in a true value, the body of the loop (the code inside the loop’s block) is executed once. 
         *
         * When the body of the loop finishes its execution, the loop's condition is evaluated again, 
         * and if the result is a true value, the loop body is executed again, and so forth. 
         * This is done repeatedly until either the loop’s condition evaluates to false, or the loop is manually terminated via a break or return statement.
         *
         * While loops are commonly used when some piece of code needs to be executed repeatedly, based on certain conditions. */
        public static void Count(int n) {
            /* Count from 1 to n */
            int i = 1;
            
            Console.WriteLine("Starting the while loop...");
            /* As long as the value of the variable i is less than
             * or equals that of the variable n, the loop continues */
            while(i <= n) {

                /* We display the value of i, and also increase it by 1, 
                 * on each repetition (iteration) of the loop. */
                Console.WriteLine("Current iteration: {0}", i);
                i = i + 1;
            }

            /* Everything that takes place here, is happening AFTER the loop has already ended. */
            Console.WriteLine("The while loop ended.");
        }

        public static void Reverse(string line) {
            /* Reverses the given string and displays the result */
            int i = line.Length - 1; // Start at the final index
            char[] reversed = new char[line.Length];
            int counter = 0;
            while(i >= 0) {
                reversed[counter] = line[i];
                counter = counter + 1;
                i = i - 1;
            }
            // Display the reversed string
            Console.WriteLine(new string(reversed));
        }

        public static void Fibonacci(int limit) {
            /* Displays the Fibonacci sequence up to <limit> */
            int a = 0, b = 1;
            int result = 0;
            Console.WriteLine("The Fibonacci sequence up to {0}:", limit);
            while(result < limit) {
                result = a + b;
                a = b;
                b = result;
                Console.Write("{0}, ", result);
            }
            Console.WriteLine();
        }
    
        public static void Collatz(int n) {
            /* Displays the Collatz sequence starting at <n> */
            Console.WriteLine("The Collatz sequence starting at {0}:", n);
            while(n > 1) {
                if (n % 2 == 0) {
                    /* n is even. Divide it by two */
                    n = n / 2;
                }
                else {
                    /* n is odd. Multiply it by 3 and add 1 */
                    n = (n*3)+1;
                }
                /* Show n's current value */
                Console.Write("{0}, ", n);
            }
            Console.WriteLine();
        }
    }

    static class DoWhileLoop {
        /* Do while loop: a do-while loop works just like the while loop, except it starts in reverse. 
         * In a do-while loop, the loop body is executed first, and only then the condition is checked. 
         * This means that a do-while loop’s body is guaranteed to be executed at least once, 
         * whereas a regular while loop’s body might not be executed at all, if the loop condition evaluated to false. 
         * After the first execution of the loop body, the do-while loop works just like the regular while loop. 
         * If its condition is evaluated to false, the loop ends. */
        public static void Count(int n) {
            /* Count from 1 to n using a do-while loop */
            int i = 1;
            Console.WriteLine("Starting the do-while loop...");
            do {
                Console.WriteLine("Current iteration: {0}", i);
                i = i + 1;
            }
            while(i <= n);
            // Here the loop ends.
            Console.WriteLine("The do-while loop ended.");
        }
    }
    
    static class ForLoop {
        /* For loop: a for-loop (or simply for loop) is a control flow statement 
         * for specifying iteration, which allows code to be executed repeatedly.
         *
         * The for loop is different from the while loop as it often has an explicit loop counter.
         * Therefore, the for loop, unlike the while loop, 
         * is commonly used to repeatedly execute code which operates on a set of indexed data, 
         * such an as array or a list.
         *
         * For-loops can also be used as a generalization of the while loop.
         * That is, they can achieve the same thing as a while loop, using less lines of code.
         * However, readability will almost always be sacrificed in that case, 
         * so this practice is not recommended (see: Fibonacci() method). */

        public static void Count(int n) {
            /* Count from 1 to n using the shorter for-loop version */
            for(int i = 1; i <= n; i++) {
                Console.WriteLine(i);
            }
            Console.WriteLine("For-loop ended.");
        }

        public static void Fibonacci(int limit) {
            /* Displays the Fibonacci sequence up to <limit>, using a for loop */
            Console.WriteLine("The Fibonacci sequence up to {0}:", limit);
            
            // Very unreadable. Demonstration purposes only. Do not write this kind of code for real.
            for(int a = 0, b = 1, result = 0; result < limit; result = a+b, a = b, b = result) {
                Console.Write("{0}, ", result);
            }
            Console.WriteLine();
        }
    }

    static class ForeachLoop {
        /* Foreach loop: a foreach is a for-loop that operates on any iterable data structure.
         * Examples of iterable data structures include primitive arrays, generic lists, dictionaries, BitArrays, and so forth.
         *
         * The foreach loop repeatedly executes the loop body for each element in the iterable collection, 
         * and thus gets its name, “for each” loop. */
        public static void ShowLetters(string line) {
            /* Display each letter from the given line string using a foreach loop */
            foreach(char letter in line) {
                Console.WriteLine(letter);
            }
            Console.WriteLine("Foreach loop ended.");
        }
    }
}
