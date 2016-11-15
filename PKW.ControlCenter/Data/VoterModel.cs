using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PKW.ControlCenter.Data
{
    public class VoterModel
    {
                public VoterModel()
        {
            DistrictId = 0;
        }
                
        public int Id { get; set; }
        public string Name { get; set; }
        public int DistrictId { get; set; }
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
                //PESEL has 11 digits: abcdefghijk
                //k is a checksum control digit
                //(a+3b+7c+9d+e+3f+7g+9h+i+3j+k) % 10 should give 0
                //https://pl.wikipedia.org/wiki/PESEL#Metoda_r.C3.B3wnowa.C5.BCna
                
                //checksum
                long a = x % 10;//k digit
                x /= 10;
                i++;//increment the counter
                a += x % 10  *3;//add 3j
                x /= 10;
                i++;
                a += x % 10;//add i
                x /= 10;
                i++;
                a += x % 10 * 9;//add 9h
                x /= 10;
                i++;
                a += x % 10 * 7;//add 7g
                x /= 10;
                i++;
                a += x % 10 * 3;//add 3f
                x /= 10;
                i++;
                a += x % 10;//add e
                x /= 10;
                i++;
                a += x % 10 * 9;//add 9b
                x /= 10;
                i++;
                a += x % 10 * 7;//add 7c
                x /= 10;
                i++;
                a += x % 10 * 3;//add 3d
                x /= 10;
                i++;
                a += x % 10;//add a
                if (a % 10 != 0 )
                    throw new ArgumentException("Nieprawidlowy PESEL", "Ccode");
                _code = value;             
            }
        }
        private long _code=0;      
 
    }
}