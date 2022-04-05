using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
     class Passport
    {
        int Serial;
        int Number;
        string Issued;
        DateTime IssuedDate;
        bool IsActive;

        public Passport(int serial, int number, string issued, DateTime issuedDate, bool isActive)
        {
            Serial = serial;
            Number = number;
            Issued = issued;
            IssuedDate = issuedDate;
            IsActive = isActive;
        }

        public void verifyLengthOfSerial(int serial)
        {

        }
        public void verifyLengthOfNumber(int number)
        {

        }
    }
}
