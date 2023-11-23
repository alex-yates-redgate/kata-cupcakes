namespace kata_cupcakes.tests
{
    public class DecoratorTests
    {

        [Test]
        public void NutCupcakeName() 
        {
            var myCake = new Nuts(new Cupcake());
            var expected = "A cupcake with nuts";
            var actual = myCake.Name;
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void NutCupcakePrice()
        {
            var myCake = new Nuts(new Cupcake());
            var expected = 1.2;
            var actual = myCake.Price;
            Assert.That(expected, Is.EqualTo(actual));
        }


        [Test]
        public void NutChocolateCupcakeName()
        {
            var myCake = new Nuts(new Chocolate(new Cupcake()));
            var expected = "A cupcake with chocolate and nuts";
            var actual = myCake.Name;
            Assert.That(expected, Is.EqualTo(actual));
        }




    }
}