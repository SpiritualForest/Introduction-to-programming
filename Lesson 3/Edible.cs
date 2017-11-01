using System.Collections.Generic;
using System.Collections.ObjectModel;

/* Here we define a namespace called Edibles, 
 * which contains the Edible class.
 * 
 * All sub-classes of Edible (for example Banana in Fruits.cs)
 * are essentially Edible objects, with their own minor unique attributes. */

// Top-most Edibles namespace
namespace Edibles {
    
    // Top-most Edible class
    class Edible {
        // These fields refer to the nutritional values of the edible object
        // Their access level is "protected" which means
        // that they're accessible also to classes derived from "Edible".
        protected int weight; // weight in grams
        protected double calories;
        protected double protein;
        protected double carbohydrates;
        protected double fats;
        protected double iron;
        protected double potassium;
        protected double sodium;
        protected double calcium;
        protected double magnesium;
        protected ReadOnlyDictionary<string, double> vitamins; // "C": 100
        protected string color;
        
        // Properties
        public int Weight {
            get { return weight; }
        }
        public double Calories {
            get { return calories; }
        }
        public double Protein {
            get { return protein; }
        }
        public double Carbohydrates {
            get { return carbohydrates; }
        }
        public double Fats {
            get { return fats; }
        }
        public double Iron {
            get { return iron; }
        }
        public double Potassium {
            get { return potassium; }
        }
        public double Sodium {
            get { return sodium; }
        }
        public double Calcium {
            get { return calcium; }
        }
        public double Magnesium {
            get { return magnesium; }
        }
        public ReadOnlyDictionary<string, double> Vitamins {
            get { return vitamins; }
        }
        public string Color {
            get { return color; }
        }
    }
}

