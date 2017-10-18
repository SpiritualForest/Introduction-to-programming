/* Simple example of if statements */

/* Conditionals, or if statement, allow us to execute code
 * based on whether a given condition is true.
 *
 * For example, if we want to create a list of even numbers
 * (those that are divisible by 2), we can use an if statement such as:
 * if (number % 2 == 0) { numbers.Add(number); }
 *
 * If the operation "number % 2" results in 0, it means that "number"
 * is evenly divisible by 2. As in, divisible without a remainder. */

using System;

namespace Examples {
    class Conditionals {
        
        public static void LessThanThirty(int n) {
            /* Will output "n is less than thirty"
             * to the console if n's value is less than 30 */
            if (n < 30) {
                Console.WriteLine("{0} is less than 30.", n);
            }
        }

        public static void StringIsHello(string line) {
            /* Will output "Hello to you!" if the given string,
             * (parameter "line") is the word "hello" written in any lettering case. */
            
            /* ToLower() is a string method (operates on string objects)
             * which converts every alphabet letter on the string to its lowercase counterpart.
             * For example "A" becomes "a", "B" becomes "b", and so forth.
             * This is useful because we want to detect whether the user entered the word
             * "hello" in any possible case. So if the parameter is "heLLo", it will still work,
             * even though we didn't check explicitly for "heLLo". */

            if (line.ToLower() == "hello") {
                Console.WriteLine("Hello to you!");
            }
        }

        public static void GetInput(string terminator) {
            /* Repeatedly prompts the user to enter input,
             * until the input equals to the data passed
             * by the "terminator" string parameter.
             *
             * So if the terminator string is "exit", the user
             * will be asked to enter input repeatedly, until they type "exit". */
            bool canLoop = true;
            while (canLoop) {
                // Promot the user to enter input
                Console.WriteLine("Enter a line of text, or type \"{0}\" exit:");
                // Read the input and store it in the string variable called line
                string line = Console.ReadLine();

                // Check if the input is the same as the terminator using the
                // comparison operator (==)
                if (line.ToLower() == terminator.ToLower()) {
                    // Set the "canLoop" variable to false, so that on the next evaluation, the loop will end.
                    canLoop = false;
                }
                // Display the input onto the screen as output.
                Console.WriteLine("You wrote: {0}", line);
            }
        }

        public static void OddEven(int n) {
            /* Shows whether each number is odd or even, up to n */
            for(int i = 1; i <= n; i++) {
                if (i % 2 == 0) {
                    // This number is even. It is evenly divisible by 2
                    Console.WriteLine("{0} is even.", i);
                }
                else {
                    Console.WriteLine("{0} is odd.", i);
                }
            }
        }

        public static void Compare(int a, int b) {
            /* Compares the numbers a and b.
             * Tells us whether one is larger than the other,
             * or if they're exactly equal.
             *
             * The six most basic comparison operators are:
             * a == b, to check if a is equal to b.
             * a != b, to check if a is NOT equal to b.
             * a > b, to check if a is larger than b.
             * a < b, to check if a is smaller than b.
             * a >= b, to check if a is larger than, or equals, b.
             * a <= b, to check if a is smaller than, or equals, b. */

            // Here we will only use ==, >, and <
            if (a == b) {
                Console.WriteLine("{0} and {1} are exactly equal.", a, b);
            }
            else if (a > b) {
                /* if the equality comparison evaluated to false,
                 * this condition will be checked next. */
                Console.WriteLine("{0} is larger than {1}.", a, b);
            }
            else {
                /* If both previous conditions evaluated to false,
                 * this line of code will be executed. */
                Console.WriteLine("{0} is smaller than {1}.", a, b);
            }
        }

        public static int Largest(int a, int b) {
            /* Returns the larger integer between a and b */
            if (a > b) {
                return a;
            }
            else {
                return b;
            }
        }

        public static int Smallest(int a, int b) {
            /* Returns the smaller integer between a and b */
            if (a < b) {
                return a;
            }
            else {
                return b;
            }
        }
    } // End of class
} // End of namespace
