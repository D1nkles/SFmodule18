class Program 
{
    static void Main(string[] args) 
    {
        CarPlant carPlant = new CarPlant();

        CarConveyor carConveyor = new CarConveyor();
        carPlant.Construct(carConveyor);
        carConveyor.Product.Show();

        ScooterConveyor scooterConveyor = new ScooterConveyor();
        carPlant.Construct(scooterConveyor);
        scooterConveyor.Product.Show();

        MotorcycleConveyor motorcycleConveyor = new MotorcycleConveyor();
        carPlant.Construct(motorcycleConveyor);
        motorcycleConveyor.Product.Show();
    }
}