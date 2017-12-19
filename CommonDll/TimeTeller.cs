using System;

namespace CommonDll
{
    public class TimeTeller
    {
        public static string TellTime()
        {
            return DateTime.Now.ToString();
        }
    }
}
