using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 /*
 Student Number: ST10343093
 Full Name: Arshad Bhula
 */

/*
=============Code Attribution====================
Author: Fatima Shaik 
Website: https://github.com/fb-shaik/PROG6221-Group1-2024/tree/main/Generics_Library_App
Date of Access: 25 June 2024 
Author: Fatima Shaik 
Website: https://github.com/fb-shaik/PROG6221-Group1-2024/tree/main/Collection_Generics_LU3
Date of Access: 25 June 2024 
=============Code Attribution====================
*/

namespace ProgPart3
{//namespace begin
    public class Ingredient
    {//Ingredient Class Begin
        //attribute variable declaration - with getter and setter methods 
        public string Name { get; set; }
        public double Quantity { get; set; }
        //public string Unit { get; set; }
        public double OriginalQuantity { get; set; } //variable to hold orginal value for Quanity used in reset method
        public UnitOfMeasurement OriginalUnit { get; set; } //variable to hold orginal Unit of measurement used in reset method
        public UnitOfMeasurement Unit { get; set; } //enum for unit of measurement

        public FoodGroup FoodGroup { get; set; } //enum for food group
        public double calories { get; set; } //variable to hold the  calories for each ingredient
        public double originalCalories { get; set; }//variable to hold the the orginal quanity used when calling the reset recipe method

        //constructor method without parameters
        public Ingredient()
        {
        }

        //constructor Method with parameters for ingredient details
        public Ingredient(string name, double quantity, UnitOfMeasurement unit, FoodGroup foodGroup, double calories)
        {//constructor begin
            Name = name;
            Quantity = quantity;
            Unit = unit;
            OriginalQuantity = quantity;
            OriginalUnit = unit; //needs to be stored in an integer
            FoodGroup = foodGroup;
            this.calories = calories;
            originalCalories = calories;
        }//constructor end

        //method to alter the Quantity to return to its orginal state
        public void ResetQuantity()
        {
            Quantity = OriginalQuantity;
        }
        //method to alter the Unit to return to its orginal state
        public void ResetUnit()
        {
            Unit = OriginalUnit;
        }

        //method to calulate the scaled calories (change the calories using the scaling factor as a var)
        public void CalculateScaledCalories(double scaledfactor)
        {
            // Assuming CaloriesPerUnit is the number of calories per unit of the ingredient
            calories = scaledfactor * calories;
        }

        //method to alter the calories to return to its orginal state
        public void ResetCalories()
        {
            this.calories = originalCalories;
        }

        //method to display the recipe ingredients
        public void display()
        { Console.WriteLine($"{Quantity} {Unit} of {Name}\nFood Group: {FoodGroup}\n{calories} calories\n"); }
        // as well as number of calories and food group
        // string interpolation used in display

    }//Ingredient Class end
}//namespace end
