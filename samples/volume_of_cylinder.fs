// calculate the volume of a cylider
// By HyperNovae#5068

module volume_of_cylinder

open System

let Calculate radius hight : float = 
  let pi = 3.14159
  radius * radius * pi * hight // Formula "pi(r^2)*h"
printfn "volume is: %g" (Calculate 25 50) // Please input floats. I.E, 5 would be 5.0.
