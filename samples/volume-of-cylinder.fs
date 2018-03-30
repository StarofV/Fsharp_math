// calculate the volume of a cylider
// By HyperNovae#5068

module volume_of_cylinder

open System

let Calculate radius hight : float = 
  Math.PI * hight * radius**2.0 // Formula: pi(r^2)*h
printfn "volume is: %g" (Calculate 25.0 50.0) // Please input floats. I.E, 5 would be 5.0
