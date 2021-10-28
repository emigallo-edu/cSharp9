using System;
using cSharp9.Records;

namespace cSharp9
{
    public class Record
    {
        public Record()
        {
            var p1 = new MotorCycle() { Color = "Rojo", Seats = 2, Sidecar = true };
            var p2 = new MotorCycle() { Color = "Rojo", Seats = 2, Sidecar = true };
            //Console.WriteLine(JsonConvert.SerializeObject(p1));


            //Console.WriteLine(new PositionalRecord("", ""));
            //Console.WriteLine(p1 == p2);


            var c1 = new OtherClass();
            var c2 = new OtherClass();
            Console.WriteLine(c1 == c2);
        }

        public record Car : Vehicle
        {
            public string EngineType { get; set; }
        }

        public record MotorCycle : Vehicle
        {
            public Boolean Sidecar { get; set; }
        }


        // Al ser posicional, no es mutable
        public record PositionalRecord(string var1, string var2) : Vehicle;
    }

    public class OtherClass
    {

    }
}