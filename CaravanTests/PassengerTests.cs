namespace Caravan.Tests
{
    public class PassengerTests
    {
        [Fact]
        public void Passenger_Constructor_CreatesPassengerObjectWithCorrectName()
        {
            string name = "testName";
            int age = 20;
            string destination = "oregon";
            string wagonName = "Black betty";
            int wagonNumWheels = 6;
            bool wagonIsCovered = true;
            // var wagon = new Wagon(wagonName, wagonNumWheels, wagonIsCovered)
            var testPassenger = new Passenger(name, age, destination/*, wagon */);

            Assert.Equal(name, testPassenger.Name);
        }
        [Fact]
        public void Passenger_Constructor_CreatesPassengerObjectWithCorrectAge()
        {
            string name = "testName";
            int age = 20;
            string destination = "oregon";
            string wagonName = "Black betty";
            int wagonNumWheels = 6;
            bool wagonIsCovered = true;
            // var wagon = new Wagon(wagonName, wagonNumWheels, wagonIsCovered)
            var testPassenger = new Passenger(name, age, destination/*, wagon */);

            Assert.Equal(age, testPassenger.Age);
        }
        [Fact]
        public void Passenger_Constructor_CreatesPassengerObjectWithCorrectDestination()
        {
            string name = "testName";
            int age = 20;
            string destination = "oregon";
            string wagonName = "Black betty";
            int wagonNumWheels = 6;
            bool wagonIsCovered = true;
            // var wagon = new Wagon(wagonName, wagonNumWheels, wagonIsCovered)
            var testPassenger = new Passenger(name, age, destination/*, wagon */);

            Assert.Equal(destination, testPassenger.Destination);
        }
        /*
        [Fact]
        public void Passenger_Constructor_CreatesPassengerObjectWithCorrectWagon()
        {
            string name = "testName";
            int age = 20;
            string destination = "oregon";
            string wagonName = "Black betty";
            int wagonNumWheels = 6;
            bool wagonIsCovered = true;
            // var wagon = new Wagon(wagonName, wagonNumWheels, wagonIsCovered)
            var testPassenger = new Passenger(name, age, destination/*, wagon );

            Assert.IsEqual(name, testPassenger.Name);
        }
        */
    }
}