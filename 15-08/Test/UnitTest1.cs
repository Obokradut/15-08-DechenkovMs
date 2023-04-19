using _15_08;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Fio_DechenkovMaxim_IsValid()
        {
            string fio = "Деченков Максим";

            Assert.AreEqual(true, Valid.IsFioValid(fio));
        }

        [Test]
        public void Address_1ballastiyper13_IsValid()
        {
            string address = "1 Балластный пер., 13";

            Assert.AreEqual(true, Valid.IsAddressValid(address));
        }

        [Test]
        public void Email_IsValid()
        {
            string email = "Visond@rambler.ru";

            Assert.AreEqual(true, Valid.IsEmailValid(email));
        }
    }
}