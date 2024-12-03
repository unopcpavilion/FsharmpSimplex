open Google.OrTools.LinearSolver

let createSolver(isInt: bool) =
   let problemType = if isInt then Solver.OptimizationProblemType.CBC_MIXED_INTEGER_PROGRAMMING else Solver.OptimizationProblemType.GLOP_LINEAR_PROGRAMMING
   Solver.CreateSolver(problemType |> string)

let defineVariables(solver: Solver) =
   let x = solver.MakeIntVar(0.0, infinity, "x")
   let y = solver.MakeIntVar(0.0, infinity, "y")

   x, y

let addConstraints(solver: Solver, x: Variable, y: Variable) =
   // 3x - y >= 0
   let constraint1 = solver.MakeConstraint(0.0, infinity)
   constraint1.SetCoefficient(x, 3.0)
   constraint1.SetCoefficient(y, -1.0)

   // x - y <= 2
   let constraint2 = solver.MakeConstraint(-infinity, 2.0)
   constraint2.SetCoefficient(x, 1.0)
   constraint2.SetCoefficient(y, -1.0)

   // x + 2y <= 14
   let constraint3 = solver.MakeConstraint(-infinity, 14.0)
   constraint3.SetCoefficient(x, 2.0)
   constraint3.SetCoefficient(y, 1.0)

let defineObjective(solver: Solver, x: Variable, y: Variable) =
   let objective = solver.Objective()
   objective.SetCoefficient(x, 3.0)
   objective.SetCoefficient(y, 4.0)
   objective.SetMaximization()

   objective

let main() =
   let solver = createSolver(false)
   let x, y = defineVariables(solver)
   addConstraints(solver, x, y)
   let objective = defineObjective(solver, x, y)
   let resultStatus = solver.Solve()

   if resultStatus = Solver.ResultStatus.OPTIMAL then
       printfn "Solution found!"
       printfn $"Objective value = %0.1f{objective.Value()}"
       printfn $"x = %0.1f{x.SolutionValue()}"
       printfn $"y = %0.1f{y.SolutionValue()}"
   else
       printfn "No optimal solution found."


main()