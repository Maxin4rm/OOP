namespace Hierarchy
{

    using System.Drawing;

    abstract class Transport
    {
        protected string model;
        protected Person driver;
        protected int maxSpeed;
    }

    abstract class Train : Transport
    {
        protected int amountOfWagons;
        protected int tractionForce;
        protected int brakingDistance;
    }

    class PassengerTrain : Train
    {
        public enum DistanceType{ Suburban, Local, LongDistance };
        private DistanceType distanceType;
        private int maxCapacity;
    }

    class FreightTrain : Train
    {
        private int maxWeight;
        public enum WagonType { Tank, Hopper, Boxcar, GondolaCar };
        private WagonType wagonType;
    }

    abstract class Car : Transport
    {
        protected int horsePower;
        protected int numberOfWheels;
        protected int torgue;
        private Color color;
    }

    class PassengerCar : Car
    {
        public enum BodyShape { Hatchback, Pickup, Limousine, Coupe, Sedan, Minivan };
        private BodyShape bodyShape;
        private int numberOfSeats;
    }

    class Truck : Car
    {
        private int maxWeight;
        private bool hasTrailer;
    }

    class Bus : Car
    {
        private int maxCapacity;
        protected bool hasAirConditioning;
        public enum Type { Passenger, Special };
        private Type type;
    }

    class Person
    {
        private string firstname;
        private string lastname;
        public enum Sex { Male, Female };
        private Sex sex;
        private int age;
    }

}
