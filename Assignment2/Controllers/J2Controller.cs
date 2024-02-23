using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {

        //<summary>
        //Calculates the total number of ways to get a sum of 10 by rolling two dice.
        //</summary>
        //<param name="m">Value for the first dice</param>
        //<param name="n">Value for the second dice</param>
        //<returns>The total number of ways to get the sum 10.</returns>
        //<example>
        //GET api/J2/DiceGame/6/8 => There are 5 total ways to get the sum 10.
        //</example>
        //<example>
        //GET api/J2/DiceGame/5/5 => There are 1 total ways to get the sum 10.
        //</example>
        //<example>
        //GET api/J2/DiceGame/3/3 => There are 0 total ways to get the sum 10.
        //</example>

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int count = 0;

            for(int i = 1; i <= m; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if(i + j == 10)
                    {
                        count++;
                    }
                }
            }

            string totalWays = "There are " + count + " total ways to get the sum 10.";
            return totalWays;
        }
    }
}
