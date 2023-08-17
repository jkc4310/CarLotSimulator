using System;
namespace CarLotSimulator
{
	public class Car
    { //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        public Car()
		{
			CarLot.numberOfCars++;
		}

		public Car(int year,string make,string model, string engineNoise,string honkNoise,bool isDriveable)
		{
            Year = year;
			Make = make;
			Model = model;
			EngineNoise = engineNoise;
			HonkNoise = honkNoise;
			IsDriveable = isDriveable;


		}

		public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool IsDriveable { get; set; }


		//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
		public void MakeEngineNoise(string noise)
		{
			Console.WriteLine(EngineNoise);
		}

		public void MakeHonkNoise(string noise)
		{
			Console.WriteLine(HonkNoise);


	
		}
    }
}

