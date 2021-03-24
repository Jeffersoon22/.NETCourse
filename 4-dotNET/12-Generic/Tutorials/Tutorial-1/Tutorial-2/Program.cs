using System;

namespace Tutorial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var batumiValidator = new TemperatureValidator(20);
                var tbilisiValidator = new TemperatureValidator(-1000);


                Console.WriteLine("Temperature in Batumi: " + batumiValidator.Temperature);
                Console.WriteLine("Temperature in Tbilisi: " + tbilisiValidator.Temperature);
            }
            catch (IncredibleTemperatureException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception was raised");
            }
            finally
            {
                Console.WriteLine("Its finnaly end");
            }
            }
        }
}

