namespace CSharp4
{
    public partial class Freezer
    {
        private int temperature;
        private double width;
        private double length;
        private string brand;
        private int yearOfManufacture;

        public static string DefaultBrand { get; private set; }
        public static int DefaultYearOfManufacture { get; private set; }

        static Freezer()
        {
            DefaultBrand = "Samsung";
            DefaultYearOfManufacture = 2020;
        }

        public Freezer()
        {
            temperature = -18;
            width = 60;
            length = 100;
            brand = DefaultBrand;
            yearOfManufacture = DefaultYearOfManufacture;
        }

        public Freezer(int temperature, double width, double length, string brand, int yearOfManufacture)
        {
            this.temperature = temperature;
            this.width = width;
            this.length = length;
            this.brand = brand;
            this.yearOfManufacture = yearOfManufacture;
        }

        public Freezer(int temperature, double width, double length)
        {
            this.temperature = temperature;
            this.width = width;
            this.length = length;
            brand = DefaultBrand;
            yearOfManufacture = DefaultYearOfManufacture;
        }

        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public double Width
        {
            get { return width; }
            private set { width = value; }
        }

        public double Length
        {
            get { return length; }
            private set { length = value; }
        }

        public string Brand
        {
            get { return brand; }
            private set { brand = value; }
        }

        public int YearOfManufacture
        {
            get { return yearOfManufacture; }
            private set { yearOfManufacture = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Temperature: {temperature}°C");
            Console.WriteLine($"Width: {width} cm");
            Console.WriteLine($"Length: {length} cm");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Year of Manufacture: {yearOfManufacture}");
        }

        public override string ToString()
        {
            return $"Freezer: {brand}, Temperature: {temperature}°C, Width: {width} cm, Length: {length} cm, Year of Manufacture: {yearOfManufacture}";
        }

        public void ChangeSettings(ref int newTemperature, ref double newWidth, ref double newLength)
        {
            temperature = newTemperature;
            width = newWidth;
            length = newLength;
        }

        public void TurnOn()
        {
            Console.WriteLine("Freezer is turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Freezer is turned off.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Freezer[] freezers = new Freezer[5];

            freezers[0] = new Freezer();
            freezers[1] = new Freezer(-20, 70, 120, "LG", 2019);
            freezers[2] = new Freezer(-22, 80, 130, "Whirlpool", 2021);
            freezers[3] = new Freezer(-18, 60, 100);
            freezers[4] = new Freezer(-25, 90, 150, "Bosch", 2022);

            foreach (Freezer freezer in freezers)
            {
                Console.WriteLine(freezer.ToString());
                freezer.DisplayInfo();
                Console.WriteLine();
            }

            int newTemperature = -19;
            double newWidth = 65;
            double newLength = 110;

            freezers[0].ChangeSettings(ref newTemperature, ref newWidth, ref newLength);
            Console.WriteLine("Changed settings:");
            freezers[0].DisplayInfo();
        }
    }
}
