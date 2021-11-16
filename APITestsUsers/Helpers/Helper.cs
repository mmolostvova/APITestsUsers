using System;
using System.Collections.Generic;

namespace APITestsUsers
{
    public static class Helper
    {
        public static string MakeUniqueString()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            return date.ToString("ddMMyyyyhhmmss");            
        }

        public static string MakeEmail()
        {            
            return MakeUniqueString() + "@vova.com";
        }

        public static string MakeName()
        {
            return "name" + MakeUniqueString();
        }

        public static string MakePass()
        {
            return "1234567890";
        }

        public static int[] MakeTasks()
        {
            int[] tasks = new int[7] { 1, 1, 2, 3, 5, 8, 13 };
            return tasks;
        }
    }
}
