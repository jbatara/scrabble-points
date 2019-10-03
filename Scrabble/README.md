| Behaviour | Input | Output |
|:---|:---:|:---:|
|App only recognizes alphebetical input |1| Invalid input|
|App requires words to be a minimum of two letters | "A" | Not a word |
|App assigns value of 1 to letters: A, E, I, O, U, L, N, R, S, T | "As" | 2 |
|App assigns value of 2 to letters: D, G | "Dog" | 5 |
|App assigns value of 3 to letters: B, C, M, P |"Boo"|5|
|App assigns value of 4 to letters: F, H, V, W, Y | "Yes" | 6 |
|App assigns value of 5 to letter: K | "Key" | 10 |
|App assigns value of 8 to letters: J, X |  "Jump" | 15 |
|App assigns value of 10 to letters: Q, Z | "Quiz" | 22|
|App returns scrabble score | "Quiz" | 22 |




```
Scrabble.Solution
|
|__Scrabble (console entry point code)
|   |_Models
|   |   |_Scrabble.cs (Main)
|   |_Scrabble.csproj
|
|_Scrabble.tests (tests go in here)
    |_ModelTests
    |   |_ScrabbleTests.cs (tests written in here)
    |_Scrabble.Tests.csproj (has a reference to the "main" folder in here)

```