using System;
namespace Events
{
    public class Car
    {

        string _make; //Backing Field to property Make
        public string Make { get => _make; set => _make = value; } //Expression body

        public string Model { get; set; } //
        public int Year { get; set; }

        public string Comment => Make switch  // Expression body + Switch expression
        {
            "Volvo" when Year >= 2021 => "...a brand new Volvo",   
            "BMW" when Year >= 2019 => "...a better used BMW",
            _ => ""
        };

        // Override ToString()
        public override string ToString() => $"Make:{Make} Model:{Model} Year:{Year} {Comment}"; //Expression body


        public event EventHandler<Car> CreatedEvent; //Broadcaster event
    }
}

