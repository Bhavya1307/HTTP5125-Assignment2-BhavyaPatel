using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        //<summary>
        //Counts number of times Martha can play slot machines.
        //</summary>
        //<param name="quaters">The number of quarters Martha has.</param>
        //<param name="machine1">Number of times the first machine been played since paying out</param>
        //<param name="machine2">Number of times the second machine been played since paying out</param>
        //<param name="machine3">Number of times the third machine been played since paying out</param>
        //<returns>The total number of times Martha played before going broke.</returns>
        //<example>
        //GET api/J3/SlotMachine/48/3/10/4 => Martha plays 66 times before going broke.
        //</example>
        //<example>
        //GET api/J3/SlotMachine/59/5/13/2 => Martha plays 77 times before going broke.
        //</example>
        //<example>
        //GET api/J3/SlotMachine/100/15/4/7 => Martha plays 232 times before going broke.
        //</example>

        [HttpGet]
        [Route("api/J3/SlotMachine/{quaters}/{machine1}/{machine2}/{machine3}")]

        public string SlotMachine(int quaters, int machine1, int machine2, int machine3)
        {
            int count = 0;

            while (quaters != 0)
            {
                quaters = quaters - 1;
                count++;
                machine1++;
                if (machine1 == 35)
                {
                    machine1 = 0;
                    quaters = quaters + 30;
                }
                if (quaters == 0)
                { 
                    break;
                }

                quaters = quaters - 1;
                count++;
                machine2++;
                if (machine2 == 100)
                {
                    machine2 = 0;
                    quaters = quaters + 60;
                }
                if (quaters == 0)
                {
                    break;
                }

                quaters = quaters - 1;
                count++;
                machine3++;
                if (machine3 == 10)
                {
                    machine3 = 0;
                    quaters = quaters + 9;
                }
                if (quaters == 0)
                {
                    break;
                }
            }

            string total = "Martha plays " + count + " times before going broke.";
            return total;
        }
    }
}
