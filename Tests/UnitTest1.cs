using CRMBL.Model;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class UnitTest1
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
                ProductId=2,
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
    }
}