using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public static class Extentions
    {
        public static bool isMail(this string str)
        {
            try
            {
                MailAddress mail = new MailAddress(str);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public static int Power(this int number, int pow)
        {
            int res = 1;
            for (int i = 0; i < pow; i++)
            {
                res *= number;
            }

            return res;
        }

        //public static bool Test(this Person person)
        //{
        //    return true;
        //}
    }
}
