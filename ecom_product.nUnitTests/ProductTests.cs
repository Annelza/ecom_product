namespace ecom_product.nUnitTests
{
    public class Tests
    {
        private Product _productid { get; set; } = null;
        private Product _productname { get; set; } = null;
        private Product _productprice { get; set; } = null;
        private Product _productstock { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _productstock = new Product(500);
        }

        [TestCase('1')]
        [TestCase('5')]
        [TestCase('8')]
        public void Productid_Test(char id)
        {
            _productid = new Product(id);
            char a = _productid.productID;
            Assert.That(a, Is.InRange(1,5000));

        }
        [TestCase("Laptop")]
        [TestCase("Monitor")]
        [TestCase("Mouse")]
        public void Productname_Test(string name)
        {
            _productname = new Product(name);
            string a = _productname.productName;
            Assert.That(a, Is.EqualTo("Laptop"));

        }
        [TestCase(197.55)]
        [TestCase(125.22)]
        [TestCase(0.0)]
        public void Productprice_Test(double pr)
        {
            _productprice = new Product(pr);
            double a = _productprice.price;
            Assert.That(a, Is.InRange(1,10000));

        }
        [TestCase(200)]
        [TestCase(5001)]
        [TestCase(0)]
        public void Productstock_Test(int st)
        {
            _productstock = new Product(st);
            int a = _productstock.stock;
            Assert.That(a, Is.InRange(1, 5000));

        }
        [TestCase(5)]
        [TestCase(256)]
        [TestCase(695)]
        public void StockIncrease_Test(int val)
        {
            var st = _productstock.StockIncrease(val);
            Assert.That(st, Is.EqualTo(505));
        }
        [TestCase(5)]
        [TestCase(256)]
        [TestCase(695)]
        public void StockDecrease_Test(int val)
        {
            var st = _productstock.StockDecrease(val);
            Assert.That(st, Is.EqualTo(495));
        }
    }
}