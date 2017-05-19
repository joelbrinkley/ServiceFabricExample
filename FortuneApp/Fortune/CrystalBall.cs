using System;
using System.Collections.Generic;
using System.Text;

namespace Fortune
{
    //generates random bits of information for the fortune teller so that he can generate a fortune
    public class CrystalBall : ICrystalBall
    {
        public int SeeTheFuture()
        {
            var random = new Random();
            int randomNumber = random.Next(1, 10);
            return randomNumber;
        }
    }
}
