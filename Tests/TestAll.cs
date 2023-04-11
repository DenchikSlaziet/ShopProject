using CRMBL.Model;
using FluentAssertions;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace Tests
{
    public class TestAll
    {
        [Fact]
        public void CartTest()
        {
            // arrange
            var customer = new Customer()
            {
                CustomerId = 1,
                Name = "testuser"
            };

            var product1 = new Product()
            {
                ProductId = 1,
                Name = "pr1",
                Price = 100,
                Count = 10
            };

            var product2 = new Product()
            {
                ProductId = 2,
                Name = "pr2",
                Price = 200,
                Count = 20
            };

            var cart = new Cart(customer);

            var expextedResult = new List<Product>()
            {
                product1,product1, product2
            };

            //act
            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product2);

            var cartresult = cart.GetAll();

            //assert
            expextedResult.Count.Should().Be(cartresult.Count);

            for (int i = 0; i < expextedResult.Count; i++)
            {
                expextedResult[i].Should().Be(cartresult[i]);
            }

        }


        [Fact]
        public void CashDeskTest()
        {
            //arrange
            var customer1 = new Customer()
            {
                Name = "testuser1",
                CustomerId = 1
            };

            var customer2 = new Customer()
            {
                Name = "testuser2",
                CustomerId = 2
            };

            var seller = new Seller()
            {
                SellerId = 1,
                Name = "testseller",
                Age = 18,
                Surname = "surname",
                CompanySeller = "company"
            };

            var product1 = new Product()
            {
                ProductId = 1,
                Name = "pr1",
                Price = 100,
                Count = 10
            };

            var product2 = new Product()
            {
                ProductId = 2,
                Name = "pr2",
                Price = 200,
                Count = 20
            };

            var cart1 = new Cart(customer1);
            cart1.Add(product1);
            cart1.Add(product1);
            cart1.Add(product2);

            var cart2 = new Cart(customer2);
            cart2.Add(product1);
            cart2.Add(product2);
            cart2.Add(product2);

            var cashdesk = new CashDesk(1, seller);
            cashdesk.MaxQueueLenght = 10;
            cashdesk.Enqueue(cart1);
            cashdesk.Enqueue(cart2);

            var cart1ExpectedResult = 400m;
            var cart2ExpectedResult = 500m;

            //act
            var cart1ActualResult = cashdesk.Dequeue();
            var cart2ActualResult = cashdesk.Dequeue();

            //assert
            cart1ExpectedResult.Should().Be(cart1ActualResult);
            cart2ExpectedResult.Should().Be(cart2ActualResult);

        }

        [Fact]
        public void StartTest()
        {
            var model = new ShopComputerModel();
            model.Start();
            Thread.Sleep(10000);
        }
    }
}