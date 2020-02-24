using NUnit.Framework;
using NSubstitute;
using FlowerShop;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Order_SetDelivered()
        {
           //ARRANGE
            var IOrder=Substitute.For<IOrderDAO>();
            var IClient=Substitute.For<IClient>();
            var order_sub= new Order(IOrder,IClient); 
            //ACT
            order_sub.Deliver();
            //ASSERT
            IOrder.Received().SetDelivered(order_sub);
        }
        [Test]
        public void PriceOrder_Accuracy()
        {
            //ARRANGE
            var IOrder=Substitute.For<IOrderDAO>();
            var IClient=Substitute.For<IClient>();
            var order_sub= new Order(IOrder,IClient); 
            //ACT
            //there is no need to act here;
            //ASSERT
            Assert.That(order_sub.Price,Is.EqualTo(135));
        }
    }
}