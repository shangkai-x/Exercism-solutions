public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int SquareOfSum = ((max * (max + 1)) / 2 );
        return SquareOfSum * SquareOfSum;
            
    }

    public static int CalculateSumOfSquares(int max)
    {
        int SumOfSquares = (max * (max + 1) * ((2 * max) + 1 )) / 6;
        return SumOfSquares;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}