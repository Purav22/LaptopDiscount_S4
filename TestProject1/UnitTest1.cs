using LaptopDiscount;

namespace TestProject1
{


    [TestFixture]
    public class EmployeeDiscountTests
    {
        [Test]
        public void CalculateDiscountedPrice_PartTime_NoDiscount()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartTime,
                Price = 100 // Example price
            };

            decimal discountedPrice = discount.CalculateDiscountedPrice();
            Assert.AreEqual(100, discountedPrice); // No discount expected
        }

    }
}







