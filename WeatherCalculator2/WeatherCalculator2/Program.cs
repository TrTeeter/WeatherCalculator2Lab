using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Calculator 2");

            int temp;
            int windSpeed;
            double windChill;
            int rh;
            double hi;
            string input = "";

            // Get the temperature from the user
            Console.WriteLine("Enter the Temperature");

            input = Console.ReadLine();

            temp = int.Parse(input);


            if (temp < 50)
            { 
                Console.WriteLine("Enter the wind speed");

                input = Console.ReadLine();

                windSpeed = int.Parse(input);

                // Calculate the wind chill

                windChill = 35.74 + (0.6125 * temp) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temp * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("The wind chill is " + windChill);
            }
            else
            {
                Console.WriteLine("Enter the Relative Humidity");

                input = Console.ReadLine();

                rh = int.Parse(input);

                hi = .5 * (temp + 61 + ((temp - 68) * 1.2) + (rh * .094));

                Console.WriteLine("The Heat Index is " + hi);
            }



        }

    }
}
