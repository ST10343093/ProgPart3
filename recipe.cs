using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPart3
{//namespace begin
    public class Recipe
    {//recipe class recipe

        //Varaible Declaration within recipe class
        public string Name { get; set; }
        public int NumIngredients { get; set; }
        public int NumSteps { get; set; }
        //Generic Collections for List anf Step
        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Steps { get; set; }

        //constructor without parameters
        public Recipe()
        {
            //instantiate ingrient and step class
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();
        }
        //constructor with parameters for recipe details
        //this will basically get the instance of a recipe details used
        public Recipe(string name, int numIngredients, int numSteps)
        {
            Name = name;
            NumIngredients = numIngredients;
            NumSteps = numSteps;
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();
        }

        //Add ingredient to ingredient list 
        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        //Add step to step list 
        public void AddStep(Step step)
        {
            Steps.Add(step);
        }
        
        //method to change the ingreientin ingredient list
        public void SetIngredients(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }

        //method to change the step in step lsit
        public void SetSteps(List<Step> steps)
        {
            Steps = steps;
        }

        public double CalculateTotalCalories()
        {
            double totalCalories = 0;
            foreach (var ingredient in Ingredients)
            {
                totalCalories += ingredient.calories;
            }
            return totalCalories;
        }

        //method to alter the recipe ingredients in the recipe list taking a scaling factor as a parameter
        public void ScaleRecipe(double scalingfactor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= scalingfactor;
            }
        }

        //method to reset the recipe class
        public void ResetRecipe()
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity = 0;
            }
            Steps.Clear();
        }

        //method to DisplayRecipes
        public string DisplayRecipe()
        {
            string recipeDetails = $"Recipe: {Name}\n";
            recipeDetails += "Ingredients:\n";
            foreach (var ingredient in Ingredients)
            {
                recipeDetails += $"- {ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} ({ingredient.calories} calories)\n";
            }
            recipeDetails += "Steps:\n";
            for (int i = 0; i < Steps.Count; i++)
            {
                recipeDetails += $"{i + 1}. {Steps[i].Description}\n";
            }
            recipeDetails += $"Total Calories: {CalculateTotalCalories()}\n";
            return recipeDetails;
        }
    }//recipe class end
}//namespace end
