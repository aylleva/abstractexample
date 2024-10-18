namespace abstracttask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle("BMW", "X7", "black", 20, 4000, "2 wheel");
            Car car = new Car("Porshe", "911 Targa", "Cherry Red", 10, 700, 4, false);

            Console.WriteLine(bicycle.AvarageSpeed());
            Console.WriteLine(car.AvarageSpeed());

            Console.WriteLine(bicycle.ToString());
            Console.WriteLine(car.ToString());

            bicycle.DefineNatureHarmness();

            car.DefineNatureHarmness();
            Console.WriteLine(bicycle.GetInfo());




            Vehicle[] vehicles = { bicycle, car };

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.GetInfo());

            }
        }
    }
}