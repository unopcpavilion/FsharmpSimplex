# Linear Programming Solver

This project demonstrates the use of Google OR-Tools for solving linear programming problems. The project includes helper functions for creating variables, constraints, and objectives, and solving optimization problems.

## Prerequisites

- .NET SDK
- Google OR-Tools

## Project Structure

- `SolverHelper.cs`: Contains helper functions for creating variables, constraints, and objectives.
- `App/Program.fs`: Main F# application that defines and solves a linear programming problem.
- `.git/info/exclude`: Git exclude file for ignoring user-specific settings.

## Getting Started

1. **Clone the repository:**

   ```sh
   git clone <repository-url>
   cd <repository-directory>
   ```

2. **Install dependencies:**

   Ensure you have the .NET SDK and Google OR-Tools installed.

3. **Build the project:**

   ```sh
   dotnet build
   ```

4. **Run the application:**

   ```sh
   dotnet run --project App
   ```

## Usage

The main application is located in `App/Program.fs`. It demonstrates the following steps:

1. **Create a solver:**

   ```fsharp
   let solver = createSolver(false)
   ```

2. **Define variables:**

   ```fsharp
   let x, y = defineVariables(solver)
   ```

3. **Add constraints:**

   ```fsharp
   addConstraints(solver, x, y)
   ```

4. **Define the objective:**

   ```fsharp
   let objective = defineObjective(solver, x, y)
   ```

5. **Solve the problem:**

   ```fsharp
   let resultStatus = solveProblem(solver)
   ```

6. **Output the results:**

   ```fsharp
   if resultStatus = Solver.ResultStatus.OPTIMAL then
       printfn "Solution found!"
       printfn $"Objective value = %0.1f{objective.Value()}"
       printfn $"x = %0.1f{x.SolutionValue()}"
       printfn $"y = %0.1f{y.SolutionValue()}"
   else
       printfn "No optimal solution found."
   ```

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
