using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PalindromeChecker
    {
        //public bool Check(string testString)
        //{
        //    return true;
        //}

        //public bool Check(string testString)
        //{
        //    if (testString.Length < 2)
        //        return true;
        //    return testString[0] == testString[1];
        //}

        public bool Check(string testString)
        {
            for (int i = 0, j = testString.Length - 1; i < j; i++, j--)
            {
                if (testString[i] != testString[j])
                    return false;
            }

            return true;
        }
    }
}
