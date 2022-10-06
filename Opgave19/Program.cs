using Opgave19;

//cars create
Car car1 = new Car("Dacia", "Logan", "Beige", 170000, false);
Car car2 = new Car("Toyota", "Yaris", "Red", 89000, true);
Car car3 = new Car("Honda", "Civic", "Hvid", 199000, false);

car1.PrintInfo();//original info
car1.PutOnSale();//on sale
car1.PrintInfo();//on sale info
