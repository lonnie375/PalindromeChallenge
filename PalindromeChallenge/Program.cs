// See https://aka.ms/new-console-template for more information


//Make the code ignore capitalization and punctuation 
//Checks if the string is read the same backwards and frontward 
//Counts the length of the string 
//Type "Exit" to quit

/* 
 * Program reads input and determines if palindrome 
 *          Console.ReadLine(), LINQ => .Reverse().
 * Must ignore case and punctuation 
 *       toLower() and  
 * Function must be name IsPalindrome, returns two values: Boolean and integer 
 * Program runs until "exit" is typed 
 */

Console.WriteLine("Lets begin:");


bool runme; 

while (runme = true)
{
    string userInput = Console.ReadLine().ToLower();
    Console.WriteLine($"Palindrome: {IsPalindrome(userInput).Item1}, Length: {IsPalindrome(userInput).Item2}");

}


(bool, int) IsPalindrome(string userInput)
{

    bool response;
    int inputLength = userInput.Length;
    userInput = new string(userInput.Where(c => !char.IsPunctuation(c)).ToArray());
    userInput = new string(userInput.Where(c => !char.IsWhiteSpace(c)).ToArray());
    string inputReversed = new string(userInput.Reverse().ToArray());

    //char[] userInputcheck = userInput.ToCharArray();
    //char[] chars = inputReversed.ToCharArray();

    //Array.Reverse(chars);
    // string inputReverse = new string(chars);

    if (userInput.Equals(inputReversed))
    {
        response = true;
    }
    else
    {
        response = false;
    }

    return (response, inputLength);
}

