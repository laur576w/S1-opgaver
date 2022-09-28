using CarHandler;

Car car0 = new Car("Ford", "Mustang", 1980, "Red");
Car car1 = new Car("Porsche", "911", 2004, "Silver");

// forskellen mellem ToString og GetInfo er at GetInfo er structureret 
//tjekker om det er en skoda der ikke kan starte


List<Car> cars = new List<Car>();


cars.Add(car0);
cars.Add(car1);




int input = 1;

while(input != 0) {
    Console.WriteLine("Hey and welcome to caradministrator\n" +
        "Do you want to\n" +
        "(1)Write a car in?\n" +
        "(2)View information on all the cars");
    input = int.Parse(Console.ReadLine());
    Console.WriteLine();
    switch (input) {
        case 1:
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Production year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Colour: ");
            string color = Console.ReadLine();
            Car car3 = new Car(brand, model, year, color);
            cars.Add(car3);// saving automatically and doesn't re:write it 
            break;
        case 2:
            foreach (Car car in cars)
                Console.WriteLine(car);
            break;
    }
    Console.WriteLine("\n");
}