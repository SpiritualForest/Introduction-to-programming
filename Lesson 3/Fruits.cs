using System.Collections.Generic;
using System.Collections.ObjectModel;
using Edibles;

/* We can define namespaces over multiple files.
 * Each namespace can also contain sub-namespaces.
 * In this case, we're extending the namespace called Edibles,
 * which is defined also in the Edible.cs file.
 * The Edible.cs file will contain the Edible class definition.
 * 
 * In here we define a sub-namespace of Edibles, called Fruits.
 * The Fruits namespace contains the Banana and Watermelon class definitions.
 * The Banana and Watermelon classes inherit from the Edible class. */

// Top-most namespace Edibles
namespace Edibles {

    // Sub-namespace Fruits
    namespace Fruits {

        // Definition for a Banana type object.
        // The Banana class inherits from the Edible class.
        // This means, in layman's terms, that a Banana is an Edible object.
        class Banana : Edible {
            // Constructor
            public Banana(int weight) {
                // Set color and weight
                color = "Yellow";
                this.weight = weight;
               
                // Set the nutritional values for a banana
                // based on the values per 100g
                calories = 105 * (weight / 100);
                protein = 1 * (weight / 100);
                fats = 0;
                carbohydrates = 23 * (weight / 100);
                iron = 0.3 * (weight / 100); // mg
                potassium = 358 * (weight / 100); // mg
                sodium = 1 * (weight / 100); // mg
                calcium = 5 * (weight / 100); // mg
                magnesium = 27 * (weight / 100); // mg

                // Now the vitamins dictionary
                Dictionary<string, double> vitamins = new Dictionary<string, double>() {
                    { "A", (64 * (weight / 100)) * 0.3 }, // mcg
                    { "B-6", 0.4 * (weight / 100) }, // mg
                    { "B-12", 0 }, // mcg
                    { "C", 8.7 * (weight / 100) }, // mg
                    { "D", 0 } // IU
                };

                // Now we need to assign this dictionary to a ReadOnlyDictionary,
                // because we don't want its values to be mutable.
                this.vitamins = new ReadOnlyDictionary<string, double>(vitamins);
            }
        } // End of Banana class

        class Watermelon : Edible {
            // Constructor
            public Watermelon(int weight) {
                // Color and weight
                color = "Green";
                this.weight = weight;

                // Nutritional values per 100g
                calories = 30 * (weight / 100);
                protein = 0.6 * (weight / 100); // g
                fats = 0.2 * (weight / 100); // g
                carbohydrates = 8 * (weight / 100); // g;
                sodium = 1 * (weight / 100); // mg
                potassium = 112 * (weight / 100); // mg
                iron = 0.2 * (weight / 100); // mg
                magnesium = 10 * (weight / 100); // mg
                calcium = 7 * (weight / 100); // mg

                // Vitamins
                Dictionary<string, double> vitamins = new Dictionary<string, double>() {
                    { "A", (569 * (weight / 100)) * 0.3 }, // mcg
                    { "B-6", 0 },
                    { "B-12", 0 },
                    { "C", 8.1 * (weight / 100) },
                    { "D", 0 }
                };

                this.vitamins = new ReadOnlyDictionary<string, double>(vitamins);
            }
        } // End of Watermelon class
    } // End of Fruits namespace
} // End of Edibles namespace
