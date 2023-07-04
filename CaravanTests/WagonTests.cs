namespace Caravan.Tests
{
    public class WagonTests
    {
        [Fact]
        public void Wagon_Constructor_CreatesWagonObjectWithCorrectNameProperty()
        {
            string name = "Black Betty";
            int numWheels = 6;
            bool isCovered = true;

            var testWagon = new Wagon(name, numWheels, isCovered);

            Assert.Equal(name, testWagon.Name);
        }
        [Fact]
        public void Wagon_Constructor_CreatesWagonObjectWithCorrectNumWheelsProperty()
        {
            string name = "Black Betty";
            int numWheels = 6;
            bool isCovered = true;

            var testWagon = new Wagon(name, numWheels, isCovered);

            Assert.Equal(numWheels, testWagon.NumWheels);
        }
        [Fact]
        public void Wagon_Constructor_CreatesWagonObjectWithCorrectIsCoveredProperty()
        {
            string name = "Black Betty";
            int numWheels = 6;
            bool isCovered = true;

            var testWagon = new Wagon(name, numWheels, isCovered);

            Assert.Equal(isCovered, testWagon.IsCovered);
        }
        [Fact]
        public void Wagon_Constructor_CreatesWagonObjectWithEmptyListOfPassengers()
        {
            string name = "Black Betty";
            int numWheels = 6;
            bool isCovered = true;

            var testWagon = new Wagon(name, numWheels, isCovered);

            Assert.IsType<List<Passenger>>(testWagon.Passengers);
            Assert.Empty(testWagon.Passengers);

        }
    }
}