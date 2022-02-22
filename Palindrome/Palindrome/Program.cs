// See https://aka.ms/new-console-template for more information
using Palindrome;

Console.WriteLine("Hello, World!");

Console.WriteLine("Please Enter a Word or Phrase To Check");
string wordToCheck = Console.ReadLine();

Console.WriteLine("Should we consider only Alphabets. Please reply true or false");
var considerOnlyAlphabets = false;
bool.TryParse(Console.ReadLine(), out considerOnlyAlphabets);

var stringManipulator = new StringManipulators();
var checker = new PalindromeChecker(stringManipulator);
var result = checker.IsPalindrome(wordToCheck, considerOnlyAlphabets);

Console.WriteLine($"{wordToCheck} is Palindrome: {result}");
Console.ReadKey();