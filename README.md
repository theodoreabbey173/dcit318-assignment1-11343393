# User Information
- Name: Theodore Gyaqueh Abbey
- Student ID: 11343393


# DCIT 318: Programming II - Assignment 1

This repository contains the solutions for the first assignment of the DCIT 318 course. The assignment involves creating three distinct C# console applications. Each task was committed separately as required.

## Prerequisites

To build and run these programs, you will need the following tools installed on your local machine:
* .NET SDK (9.0)
* A code editor or IDE (e.g., Visual Studio, VS Code)
* Git for version control, which is required to clone the repository.

## How to Run

1.  Clone the repository to your local machine using Git.
2.  Open your terminal or command prompt.
3.  Navigate into the directory of the specific program you want to run (e.g., `GradeCalculator`).
4.  Execute the following command:
    ```sh
    dotnet run
    ```
5.  The program will start and prompt you for the required input.

---

## Programming Tasks

### 1. Grade Calculator

This console application prompts a user to enter a numerical grade between 0 and 100. It then calculates and displays the corresponding letter grade based on the following scale:

* **A**: 90 and above 
* **B**: 80-89 
* **C**: 70-79 
* **D**: 60-69 
* **F**: Below 60 

### 2. Ticket Price Calculator

This application calculates the price of a movie ticket based on the user's age. The program prompts the user to enter their age and displays the ticket price accordingly.

The pricing structure is as follows:
* **Standard Price**: GHC10 
* **Discounted Price**: GHC7, applicable to:
    * Senior citizens (age 65 and above)
    * Children (age 12 and below) 

### 3. Triangle Type Identifier

This program asks the user to input the lengths of three sides of a triangle. Based on these lengths, the application determines and displays the type of the triangle.

The possible triangle types are:
* **Equilateral**: All three sides of the triangle are equal.
* **Isosceles**: Two sides of the triangle are equal.
* **Scalene**: No sides of the triangle are equal.
