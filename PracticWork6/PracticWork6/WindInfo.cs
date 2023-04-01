namespace PracticWork6
{
    public class WindInfo
    {
        public double Speed { get; set; }
        public int Deg { get; set; }

        public string DegToString()
        {
            if (Deg >= 120 && Deg <= 240)
            {
                if (Deg < 150)
                {
                    return "Юго-восток";
                }
                else if (Deg > 210)
                {
                    return "Юго-Запад";
                }
                return "Юг";
            }

            if (Deg <= 60 && Deg >= 300)
            {
                if (Deg > 30)
                {
                    return "Северо-восток";
                }
                if (Deg < 330)
                {
                    return "Северо-запад";
                }
                return "Север";
            }

            if (Deg < 120 && Deg > 60)
            {
                return "Восток";
            }

            return "Запад";
        }
    }
}