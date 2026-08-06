public static class LineUp
{
    public static string Format(string name, int number)
    {
        int lastTwoDigits = number % 100;
        int lastDigit = number % 10;

        string suffix = (lastTwoDigits) switch
        {
            11 or 12 or 13 => "th", 
            _ => lastDigit switch  // '_' built in method for 'anything else'
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            }
        }; // needed for switch case since it deciding the variable.
        return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";
    }
}
