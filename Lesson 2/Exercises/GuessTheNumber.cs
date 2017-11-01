/* Write a small program that asks the user to enter a number.
 * If the number is lower than the randomly generated number, say it's lower.
 * If it's higher, say it's higher.
 * If the number that the user enters is equal, the game ends. */

// You will practice loops, taking input, displaying output, and if statements.

using System;

class GuessTheNumber {
    static int GetRandomNumber(int n) {
        /* Retrieves a random number between 1 and n */
        Random rng = new Random();
        int number = rng.Next(1, n);
        return number;
    }

    static void Main(string[] args) {
        int number = GetRandomNumber();
        bool canLoop = true;
        while(canLoop) {
            /* Hints:
             * use Console.ReadLine(),
             * then int.Parse() on the string returned by ReadLine().
             * Use if statements.
             * Set canLoop to false when you want to end the loop. */
        }
    }
}
