namespace Lab11.Services
{
    public class CalcService : ICalcService
    {
        public int First { get; private set; }
        public int Second { get; private set; }

        public CalcService()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            (First, Second) = (rnd.Next() % 10, rnd.Next() % 10);
        }

        public int Sum()
        {
            return First + Second;
        }

        public int Sub()
        {
            return First - Second;
        }

        public int Mul()
        {
            return First * Second;
        }
        public int Div()
        {
            try
            {
                var divResult = First / Second;
                return divResult;
            }
            catch (DivideByZeroException)
            {
                return -1;
            }
        }
    }
}
