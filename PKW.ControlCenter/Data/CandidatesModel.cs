using System;

namespace PKW.ControlCenter.Data
{
    public class CandidatesModel
    {
        public CandidatesModel()
        {
            ConstituencyId = 0;
        }

        public string Area { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int ConstituencyId { get; set; }
        public long  Code 
        { 
            get
            {
                return _code;
            }
            set
            {
                long i;
                //check if values is bigger than 99999999999
                if (value > 99999999999)
                {
                    throw new ArgumentException("PESEL zbyt dlugi", "Code");
                }
                //check if values is less than 10000000000
                if (value < 10000000000)
                {
                    throw new ArgumentException("PESEL zbyt krotki", "Code");
                }
                i = 0;
                long x = value;
                //abcdefghijk
                //a+3b+7c+9d+e+3f+7g+9h+i+3j+k
                long a = x % 10;
                x /= 10;
                i++;
                a += x % 10  *3;
                x /= 10;
                i++;
                a += x % 10;
                x /= 10;
                i++;
                a += x % 10 * 9;
                x /= 10;
                i++;
                a += x % 10 * 7;
                x /= 10;
                i++;
                a += x % 10 * 3;
                x /= 10;
                i++;
                a += x % 10;
                x /= 10;
                i++;
                a += x % 10 * 9;
                x /= 10;
                i++;
                a += x % 10 * 7;
                x /= 10;
                i++;
                a += x % 10 * 3;
                x /= 10;
                i++;
                a += x % 10;
                if (a % 10 != 0 )
                    throw new ArgumentException("Nieprawidlowy PESEL", "Ccode");
                _code = value;             
            }
        }
        private long _code=0;        
    }
}