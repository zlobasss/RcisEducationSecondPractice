namespace PracticWork6
{
    public class WindInfo
    {
        public int Speed { get; set; }
        public int Deg { get; set; }

        public string DegToString()
        {
            if (Deg >= 120 && Deg <= 240)
            {
                if (Deg < 150)
                {
                    return "юго-восточный";
                }
                else if (Deg > 210)
                {
                    return "юго-западный";
                }

                return "южный";
            }
            if (Deg)
        }
    }
}