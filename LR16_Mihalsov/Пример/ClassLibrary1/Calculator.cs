namespace ClassLibrary1
{
    ///  
    /// Математический класс 
    public class Calculator
    {
        ///  
        /// Метод возвращает сумму двух целых чисел 
        ///  
        public static int Summ(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        ///  
        /// Метод возвращает разность двух целых чисел 
        ///  
        /// /// ///  
        public static int Division(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        ///  
        /// Метод возвращает произведение двух чисел 
        ///  
        public static long Multiply(long x, long y)
        {
            return (x * y);
        }
        ///  
        /// Метод возвращает деление двух чисел 
        ///  
        public static int Residual(int firstNumber, int secondNumber)
        {
            return (firstNumber / secondNumber);
        }
    }
}
