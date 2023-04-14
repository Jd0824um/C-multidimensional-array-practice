namespace MultidimensionalArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Say I have a parking lot with these cars.
            String[,] parkingLot = { // Instantiate with and array [,]
                {"Ford", "Mustang", "F-150", "Explorer" }, 
                {"Chevy",  "Corvette", "Camaro", "Silverado" }, 
                {"Toyota",  "Corolla", "Camry", "Rav4" } };

            parkingLot[0, 2] = "Fusion"; // Lets change the first row last column car model to Fusion

            foreach (String car in parkingLot) { // Print out all the cars in the parking lot
                Console.WriteLine(car);
            }

            // Let's make a 2 dimensional matrix using nested for loops
            for(int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for(int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}