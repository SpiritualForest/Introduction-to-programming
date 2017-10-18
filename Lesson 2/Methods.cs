/* Examples of writing simple methods */

/* Methods (also known as functions when defined outside classes) give us
 * the ability to encapsulate code which can then be executed from different
 * areas of the program.
 *
 * Rather than writing the same code repeatedly in all the areas we need it,
 * we can encapsulate this code in one method, and then call (invoke) that method
 * whenever we need to use it.
 *
 * Another important thing that methods give us is the ability to abstract away irrelevant details.
 * We don't need to know how the method works on the inside in order to use it.
 * Nor do we need to even care about that, except when we wrote the method.
 *
 * WriteLine() is a method that belongs to the Console class, for example.
 * We don't need to know how WriteLine() itself was written, and what happens inside
 * of it when we call it. All that matters to us is that we can use it
 * to write a line of text to the console window.
 *
 * It's kind of like driving a car, or using a phone.
 * We don't need to know every single detail about the car's engine, or its wheels, if we want to drive it.
 * Those details have been abstracted away, and we're using a simpler interface to interact with the car.
 *
 * Likewise, we don't need to know everything about a telephone if we want to make a call.
 * All we need to know, or care about, is how to use the simplified interface.
 *
 * In C#, which is a statically typed language, each method must have a return type.
 * A "return type" refers to the type of data that the method outputs (or returns)
 * when it finishes running.
 *
 * A return type can be any type in existence, from the primitive and simple types of int, string, char, double,
 * to more complicated data types such as a generic List, or Dictionary.
 * To define a new data type, we need to create a class or data structure for it, 
 * that implements it, defines what data it holds, and what functions (methods) can be called upon it.
 *
 * For example, ConsoleKeyInfo is a data structure defined in the System namespace.
 * It's used to store data about a key that was pressed when the Console.ReadKey() method was called.
 *
 * When a method does not return any data, but only performs actions, its return type is void.
 * For example, WriteLine() is a method that doesn't return any data. It only performs an action.
 * Therefore, its return type is void, and it is defined as "public static void WriteLine() { }". */

namespace Examples {
    class Methods {

        /* These methods will return an integer (int type).
         * This means that their return type is int */
        public static int Add(int a, int b) {
            /* Adds the values of a and b, and returns the resulting integer */
            int result = a + b;
            return result;
        }
        public static int Subtract(int a, int b) {
            /* Subtracts the value of b from a, and returns the resulting integer */
            int result = a - b;
            return result;
        }

        /* These methods will return a string type value */
        public static string IntToString(int[] numbers) {
            /* Iterates over the numbers array,
             * and type-casts each integer into a UTF-16 character (char type).
             * Returns the resulting string */
            
            char[] letters = new char[numbers.Length];
            for(int i = 0; i < numbers.Length; i++) {
                /* n is an integer (whole number, for example 150).
                 * When we type-cast it to a char type (using (char)n),
                 * we get the Unicode character represeted by its number.
                 *
                 * Then we add it to the corresponding index on our char array */
                letters[i] = (char)numbers[i];
            }
            /* Construct a new string from the array of chars */
            string result = new string(letters);

            // Return the newly constructed string
            return result;
        }
        public static string Duplicate(string str) {
            /* Duplicate the given string str and return the result.
             * If str was "Hey", the result will be "HeyHey" */
            string result = str + str;
            return result;
        }
    }
}
