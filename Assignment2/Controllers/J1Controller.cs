using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {

        //<summary>
        //Calculates the total calorie count based on the choices of burger, drink, side, and dessert.
        //</summary>
        //<param name="burger">The choice value of burger</param>
        //<param name="drink">The choice value of drink</param>
        //<param name="side">The choice value of side</param>
        //<param name="dessert">The choice value of dessert</param>
        //<returns>The total calorie count of burger, drink, side and dessert</returns>
        //<example>
        //GET api/J1/Menu/1/2/3/4 => Your total calorie count is 691
        //</example>
        //<example>
        //GET api/J1/Menu/4/4/4/4 => Your total calorie count is 0
        //</example>
        //<example>
        //GET api/J1/Menu/4/3/2/1 => Your total calorie count is 342
        //</example>

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int calories = 0;

            //For burger
            if(burger == 1)
            {
                calories = 461;
            }
            else if(burger == 2)
            {
                calories = 431;
            }
            else if(burger == 3)
            {
                calories = 420;
            }
            else
            {
                calories = 0;
            }


            //For drink
            if (drink == 1)
            {
                calories = calories + 130;
            }
            else if (drink == 2)
            {
                calories = calories + 160;
            }
            else if (drink == 3)
            {
                calories = calories + 118;
            }
            else
            {
                calories = calories + 0;
            }


            //For side
            if (side == 1)
            {
                calories = calories + 100;
            }
            else if (side == 2)
            {
                calories = calories + 57;
            }
            else if (side == 3)
            {
                calories = calories + 70;
            }
            else
            {
                calories = calories + 0;
            }


            //For dessert
            if (dessert == 1)
            {
                calories = calories + 167;
            }
            else if (dessert == 2)
            {
                calories = calories + 266;
            }
            else if (dessert == 3)
            {
                calories = calories + 75;
            }
            else
            {
                calories = calories + 0;
            }


            string total = "Your total calorie count is " + calories;

            return total;
        }
    }
}
