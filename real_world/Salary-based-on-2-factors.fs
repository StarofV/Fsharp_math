// How much you make per year based on 2 factors
// By HyperNovae

open System

(*Class containing information*)
type factors(salary:float, monthly_bills:float) =
  member this.Salary = salary
  member this.Monthly_Bills = monthly_bills
let instance = new factors(100000.0, 5000.0) (*The factors. Change them to yours. (make sure they are float)*

(*Subtract Salary from (monthly bills*12)*)
let Subtract x y : float =
  x - y*12.0

let final_result = Subtract instance.Salary instance.Monthly_Bills // Pass stuff to "Subtract" function
Console.WriteLine("You make ${0} per year.", final_result) // Output the final_result
