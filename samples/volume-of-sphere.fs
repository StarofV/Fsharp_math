// Volume of sphere 
// HyperNovae

module Volume_Of_Sphere

open System

let Calculate (radius : float) = 
  4.0 / 3.0 * Math.PI * radius**3.0 // V = ⁴⁄₃πr³
printfn "Volume is: %g" (Calculate 25.0) // Please input floats. I.E, 5 would be 5.0