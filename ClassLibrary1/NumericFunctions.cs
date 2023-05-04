namespace CommonFunctions

{
    public class NumericFunctions
    {
        public int Add(params int[] arr)
        {
            return arr.Sum();
        }

        public int Subtract(int? val1,int? val2)
        {
            val1 = val1 ?? 10;//if null then assign 10
            val2 = val2 ?? 10;
            return Math.Abs(val1.Value - val2.Value);
        }

        public int Multiply(int val1,int val2)
        {
            return val1 * val2; 
        }

        public int Divide(int val1,int val2)
        {
            return (val1 / val2);
        }

        public int MaxNum(params int[] arr) {
            return arr.Max();
        }

        public int MinNum(params int[] arr)
        {
            return arr.Min();
        }

        public bool IsEven(int num)
        {
            return num%2==0? true: false;
        }

        public bool IsOdd(int num)
        {
            return num % 2 == 0 ? false : true;
        }

        public bool IsPrime(int num)
        {
            for(int i = 2; i * i <= num; i++)
            {
                if(num%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}