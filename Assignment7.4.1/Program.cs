namespace Assignment7._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
			Console.WriteLine(parkingSystem.AddCar(1)); 
            Console.WriteLine(parkingSystem.AddCar(2)); 
            Console.WriteLine(parkingSystem.AddCar(3)); 
            Console.WriteLine(parkingSystem.AddCar(1));
		}
    }
	public class ParkingSystem
	{
		private Dictionary<int, int> parkingSlots; 
		public ParkingSystem(int big, int medium, int small)//keys - 1, 2, 3 values - big, medium, small
		{
			parkingSlots = new Dictionary<int, int> 
			{ 
				{ 1, big }, // 1 for big cars
				{ 2, medium }, // 2 for medium cars
				{ 3, small } // 3 for small cars
			}; 
		} 
		public bool AddCar(int carType) 
		{ 
			if (parkingSlots.ContainsKey(carType) && parkingSlots[carType] > 0) 
			{ 
				parkingSlots[carType]--; 
				return true; 
			} 
			return false; 
		} 
	}
}
