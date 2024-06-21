using LaptopDiscount;

namespace TestProject1
{

    [TestFixture]
    public class Test
    {
        [Test]
        public void CalculatePrice_PartTime()
        {
            var discountPrice = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartTime,
                Price = 300 
            };

            decimal discountedPrice = discountPrice.CalculateDiscountedPrice();
            Assert.AreEqual(300, discountedPrice); 
        }
        [Test]
        public void CalculateDiscountedPrice_5Per()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartialLoad,
                Price = 200
            };

            decimal discountedPrice = discount.CalculateDiscountedPrice();
            Assert.AreEqual(190, discountedPrice); 
        }

        [Test]
        public void CalculateDiscountedPrice_10PerFullTime()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = 200
            };

            decimal discountedPrice = discount.CalculateDiscountedPrice();
            Assert.AreEqual(180, discountedPrice); 
        }

        [Test]
        public void CalculateDiscountedPrice_20Per()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = 200
            };

            decimal discountedPrice = discount.CalculateDiscountedPrice();
            Assert.AreEqual(160, discountedPrice); 
        }

        [Test]
        public void CalculateDiscountedPrice_NegativeValue()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = -10
            };

            Assert.Throws<ArgumentOutOfRangeException>(() => discount.CalculateDiscountedPrice());
        }

        [Test]
        public void CalculateDiscountedPrice_LowPrice()
        {
            var discount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = 10 
            };

            decimal discountedPrice = discount.CalculateDiscountedPrice();
            Assert.AreEqual(8, discountedPrice); 
        }


    }
}







