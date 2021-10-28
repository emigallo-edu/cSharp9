using System;
using cSharp9.Records;
using Newtonsoft.Json;

namespace cSharp9
{
    public class WithExpressions
    {
        public WithExpressions()
        {
            var vehicle = new Vehicle { Color = "Azul", Seats = 4 };
            var otherVehicle = vehicle with { Color = "Amarillo" };

            Console.WriteLine(JsonConvert.SerializeObject(vehicle));
            Console.WriteLine(JsonConvert.SerializeObject(otherVehicle));

            Console.WriteLine(ReferenceEquals(vehicle, otherVehicle));
        }
    }
}