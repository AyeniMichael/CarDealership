namespace Dealership.Models
{
    class Car
    {
        private string _makeModel;
        private int _price;
        private int _mileage;

        public Car(string model, int price, int miles)
        {
            _makeModel = model;
            _price = price;
            _mileage = miles;
        }

        public string GetMakeModel()
        {
            return _makeModel;
        }

        public int GetPrice()
        {
            return _price;
        }

        public int GetMileage()
        {
            return _mileage;
        }

        public void SetMakeModel(string newMakeModel)
        {
            _makeModel = newMakeModel;
        }

        public void SetPrice(int newPrice)
        {
            _price = newPrice;
        }

        public void SetMileage(int newMileage)
        {
            _mileage = newMileage;
        }

        public static string SpeedLimit(int speedLimit)
        {
            return "The speed limit of the cars is "+speedLimit+".";
        }
        

        public bool worthbuying(int maxPrice, int maxMileage)
        {
            return (_price < maxPrice && _mileage < maxMileage);
            
        }

    }
}
