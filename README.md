# Recipe App - Part 3
 
## Overview
The Recipe App has been significantly enhanced to provide a more user-friendly experience with a graphical user interface (GUI) built using Windows Presentation Foundation (WPF). Upon launching the application, users are greeted with a welcome window and a "Get Started" button to initiate their journey. They can enter an unlimited number of recipes, specifying the recipe name, number of ingredients, and steps. This information is dynamically stored in memory using generic collections.
 
The interface allows users to easily add ingredients, including details such as name, quantity, unit of measurement, calories, and food group, which are stored in a structured list. Steps for each recipe are also added and managed within the application, offering a streamlined and intuitive process for recipe creation. The GUI ensures smooth navigation and data input, enhancing overall usability.
 
Key features of the app include the ability to scale recipes by factors of 0.5, 2, or 3, adjusting ingredient quantities and units accordingly. For instance, doubling a recipe that originally calls for 8 tablespoons will automatically convert to 1 cup. Additionally, the app calculates the total calories for each recipe, providing informative messages based on the calorie count and alerting users if the total exceeds 300 calories. Users can also filter recipes by ingredient name, food group, or calorie limit, and create menus with multiple recipes.
 
 
## Table of Contents
- [Overview](#overview)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [New Features Implemented for Part 3](#new-features-implemented-for-part-3)
- [Learning Outcomes](#learning-outcomes)
- [Links to Repository](#links-to-repository)
 
## Prerequisites
- .NET SDK: Ensure you have the .NET SDK installed on your machine. [Download from .NET](https://dotnet.microsoft.com/download)
- C# IDE: Install a C# Integrated Development Environment (IDE) such as [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/).
 
## Installation
1. **Clone the repository**:
    ```sh
    git clone <repository_url>
    cd <repository_name>
    ```
2. **Open the project in Visual Studio**:
    - Navigate to the cloned directory and open the `.sln` file in Visual Studio.
3. **Build the project**:
    - In Visual Studio, go to `Build > Build Solution` to compile the project.
 
## Usage
1. **Get Started**:
    - Click the "Get Started" button on the welcome page.
2. **Add a Recipe**:
    - Enter the recipe name, the number of ingredients, and the number of steps.
3. **Input Ingredients**:
    - Provide the details for each ingredient, including name, quantity, unit of measurement, calories, and food group. Click the 'Add Ingredient' button after entering each ingredient.
4. **Input Steps**:
    - Enter the instructions for each step of the recipe. Click the 'Add Step' button after entering each step.
5. **Main Menu**:
    - The main menu displays all added recipes and provides options such as Add Recipe, Filter Recipes, View Recipe, and Exit.
6. **Select an Option**:
    - Choose one of the following options from the main menu:
        - **Add Recipe**: Add a new recipe by repeating steps 2 to 4.
        - **Filter Recipes**: Filter the list of recipes by ingredient name, food group, or maximum calorie count.
        - **View Recipe**: Select a recipe to view its details. Options include scaling the recipe by a factor, resetting it to its original state, deleting it from the list, or returning to the main menu.
        - **Exit**: Close the application.
 
## New Features Implemented for Part 3
- **Graphical User Interface (GUI)**: Transitioned from a command-line interface to a WPF-based GUI, enhancing usability and visual appeal.
- **Recipe Filtering**: Added functionality to filter recipes by ingredient, food group, or calorie count.
 
## Learning Outcomes
- **Extensible Application Markup Language (XAML)**: Gained proficiency in using XAML to design and implement GUIs in WPF.
- **Controls and Styles**: Implemented various controls (e.g., TextBox, Button, ComboBox) and styles to create a consistent and user-friendly interface.
- **Graphics Rendering**: Utilized graphics rendering services to display a pie chart representing the food group composition of selected recipes.
- **Feedback Implementation**: Incorporated feedback from Part 2 to refine and enhance the application, ensuring a polished and functional end product.
## Links to Repository
- [GitHub Repository Part 1](https://github.com/VCDN-2024/prog6221-part-1-ST10343093)
 
- [GitHub Repository Part 2](https://github.com/ST10343093/Progpart2.)
 
