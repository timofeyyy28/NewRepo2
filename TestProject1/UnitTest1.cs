using ClassLab;
using _12._222222;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPointConstructor()
        {
            var data = new Musicalinstrument("Инструмент №1", 1);
            var point = new Point<Musicalinstrument>(data);

            Assert.AreEqual(data, point.Data);
            Assert.IsNull(point.Next);
            Assert.IsNull(point.Pred);
        }

        [TestMethod]
        public void TestPointDefaultConstructor()
        {
            var point = new Point<Musicalinstrument>();

            Assert.IsNull(point.Data);
            Assert.IsNull(point.Next);
            Assert.IsNull(point.Pred);
        }

        [TestMethod]
        public void TestPointToString()
        {
            var data = new Musicalinstrument("Инструмент №1", 1);
            var point = new Point<Musicalinstrument>(data);

            Assert.AreEqual(data.ToString(), point.ToString());
        }

        [TestMethod]
        public void TestPointToStringWithNullData()
        {
            var point = new Point<Musicalinstrument>();

            Assert.AreEqual("", point.ToString());
        }
        [TestMethod]
        public void TestPointMakeRandomData()
        {
            var randomDataPoint = Point<Musicalinstrument>.MakeRandomData();

            Assert.IsNotNull(randomDataPoint.Data);
            Assert.IsNull(randomDataPoint.Next);
            Assert.IsNull(randomDataPoint.Pred);
        }

        [TestMethod]
        public void TestPointMakeRandomItem()
        {
            var randomData = Point<Musicalinstrument>.MakeRandomItem();

            Assert.IsNotNull(randomData);

        }


        [TestMethod]
        public void Constructor_SizeIsSetCorrectly()
        {
            var myhashtable = new MyHashTable<Musicalinstrument>(10);
            Assert.AreEqual(10, myhashtable.Capacity);
        }
        [TestMethod]
        public void Constructor_SizeLimitIsEnforced()
        {
            var largeHashTable = new MyHashTable<Musicalinstrument>(150);
            Assert.AreEqual(100, largeHashTable.Capacity);
        }
        public void TestAddPoint_WhenItemIsAdded_ThenContainsItem()
        {

            var myHashTable = new MyHashTable<Musicalinstrument>(10);
            var instrument = new Musicalinstrument("Инструмент №1", 1);


            myHashTable.AddPoint(instrument);
            var containsItem = myHashTable.Contains(instrument);


            Assert.IsTrue(containsItem);


        }

        [TestMethod]
        public void TestContains_WhenItemIsAdded_ThenItemIsFound()
        {

            var myHashTable = new MyHashTable<Musicalinstrument>(10);
            var instrument = new Musicalinstrument("Инструмент №3", 1);


            myHashTable.AddPoint(instrument);


            Assert.IsTrue(myHashTable.Contains(instrument));
        }
        [TestMethod]
        public void TestContains_WhenItemIsNotAdded_ThenItemIsNotFound()
        {

            var myHashTable = new MyHashTable<Musicalinstrument>(10);
            var instrument = new Musicalinstrument("Инструмент №4", 1);


            Assert.IsFalse(myHashTable.Contains(instrument));
        }

        [TestMethod]
        public void TestRemoveData_WhenItemIsRemoved_ThenItemIsRemovedAndNotFound()
        {

            var myHashTable = new MyHashTable<Musicalinstrument>(10);
            var instrument = new Musicalinstrument("Инструмент №3", 1);
            myHashTable.AddPoint(instrument);


            Assert.IsTrue(myHashTable.RemoveData(instrument));
            Assert.IsFalse(myHashTable.Contains(instrument));

        }
        [TestMethod]
        public void TestRemoveData_WhenItemNotInTable_ThenReturnFalse()
        {

            var myHashTable = new MyHashTable<Musicalinstrument>(10);
            var instrument = new Musicalinstrument("Инструмент №2", 1);


            Assert.IsFalse(myHashTable.RemoveData(instrument));
        }
        [TestMethod]
        public void TestSearchItem_WhenItemIsFound_ThenReturnItem()
        {

            var myHashTable = new MyHashTable<Musicalinstrument>(10);
            var instrument = new Musicalinstrument("Инструмент №5", 1);
            myHashTable.AddPoint(instrument);


            var result = myHashTable.SearchItem(instrument);


            Assert.AreEqual(instrument, result.Data);
        }
        [TestMethod]
        public void TestSearchItem_WhenItemIsNotFound_ThenReturnNull()
        {

            var myHashTable = new MyHashTable<Musicalinstrument>(10);
            var instrument = new Musicalinstrument("Инструмент №1", 1);


            var result = myHashTable.SearchItem(instrument);


            Assert.IsNull(result);
        }
    }
}