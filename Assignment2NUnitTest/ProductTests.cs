using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;

namespace Assignment2NUnitTest
{
    public class ProductTests
    {
        //Test case for productId

        // To check minimum value
        [Test]
        public void productID_ShouldEqualToMinimunValue()
        {
            //Arrange

            var product = new Product(1, "Product1", 50.0m, 9);

            //Act
            var current = product.ProductId;

            //Assert
            Assert.That(current, Is.EqualTo(1));
        }

        // To check maxmimumvalue
        [Test]
        public void productID_ShouldEqualToMaximumValue()
        {
            //Arrange

            var product = new Product(1000, "Product1", 50.0m, 9);

            //Act
            var current = product.ProductId;

            //Assert
            Assert.That(current, Is.EqualTo(1000));
        }

        // To check range
        [Test]
        public void productID_ShouldNotBeZeroOrNegative()
        {
            //Arrange

            var product = new Product(5, "Product1", 50.0m, 9);

            //Act
            var current = product.ProductId;

            //Assert
            Assert.That(current, Is.EqualTo(5));
        }

        // Test cases for ProductName 

        [Test]
        public void ProductName_ShouldNotBeNullOrEmpty()
        {
            // Arrange
            var productName = " ";
            var product = new Product(200, "productName", 10.0m, 5);

            // Act
            var current = product.ProductName;

            // Assert
            Assert.That(current, Is.EqualTo(productName));
        }

        [Test]
        public void ProductName_ShouldAllowRegularNames()
        {
            // Arrange
            var productName = "Test Product";
            var product = new Product(200, "productName", 10.0m, 5);

            // Act
            var current = product.ProductName;

            // Assert
            Assert.That(current, Is.EqualTo(productName));
        }

        [Test]
        public void ProductName_ShouldTrimWhitespace()
        {
            // Arrange
            var productName = "   Test Product   ";
            var product = new Product(200, productName.Trim(), 10.0m, 5);

            // Act
            var current = product.ProductName;

            // Assert
            Assert.That(current, Is.EqualTo("Test Product"));
        }
        // Test case for price

        // To check minimum value
        [Test]
        public void price_ShouldEqualToMinimunValue()
        {
            //Arrange

            var product = new Product(100, "Product1", 1.0m, 7);

            //Act
            var current = product.Price;

            //Assert
            Assert.That(current, Is.EqualTo(1.0m));
        }

        // To check maxmimumvalue
        [Test]
        public void price_ShouldEqualToMaximumValue()
        {
            //Arrange

            var product = new Product(100, "Product1", 500.0m, 7);

            //Act
            var current = product.Price;

            //Assert
            Assert.That(current, Is.EqualTo(500.0m));
        }

        // To check range
        [Test]
        public void price_ShouldNotBeNegative()
        {
            //Arrange

            var product = new Product(100, "Product1", 40.0m, 7);

            //Act
            var current = product.Price;

            //Assert
            Assert.That(current, Is.EqualTo(40.0m));
        }

        // Test case for Stock

        // To check minimum value
        [Test]
        public void Stock_ShouldEqualToMinimunValue()
        {
            //Arrange

            var product = new Product(150, "Product1", 10.0m, 1);

            //Act
            var current = product.Stock;

            //Assert
            Assert.That(current, Is.EqualTo(1));
        }

        // To check maxmimumvalue
        [Test]
        public void Stock_ShouldEqualToMaximumValue()
        {
            //Arrange

            var product = new Product(150, "Product1", 10.0m, 700);

            //Act
            var current = product.Stock;

            //Assert
            Assert.That(current, Is.EqualTo(700));
        }

        // To check range
        [Test]
        public void Stock_ShouldBeInRange_WhenInitialized()
        {
            //Arrange

            var product = new Product(150, "Product1", 10.0m, 5);

            //Act
            var current = product.Stock;

            //Assert
            Assert.That(current, Is.EqualTo(5));
        }

        // Test case for Increasestock

        [Test]
        public void IncreaseStock_ShouldNotChangeStock_WhenAmountIsZero()
        {
            //Arrange
            var product = new Product(300, "Product", 50.0m, 125);
            var increaseAmount = 0;

            //Act
            product.IncreaseStock(increaseAmount);
            var current = product.Stock;

            //Assert
            Assert.That(current, Is.EqualTo(125));
        }
        [Test]
        public void IncreaseStock_ShouldIncreaseStockByGivenAmount()
        {
            // Arrange
            var product = new Product(300, "Product1", 50.0m, 100);
            var increaseAmount = 105;

            // Act
            product.IncreaseStock(increaseAmount);
            var current = product.Stock;

            // Assert
            Assert.That(current, Is.EqualTo(205));
        }
        [Test]
        public void IncreaseStock_ShouldNotChangeStock_WhenAmountIsNegative()
        {
            // Arrange
            var product = new Product(300, "Product1", 50.0m, 100);
            var increaseAmount = -5;

            // Act
            product.IncreaseStock(increaseAmount);
            var current = product.Stock;

            // Assert
            Assert.That(current, Is.EqualTo(100));
        }


        // Test cases for DecreaseStock method

        [Test]
        public void DecreaseStock_ShouldNotChangeStock_WhenAmountIsZero()
        {
            // Arrange
            var product = new Product(100, "Product1", 10.0m, 200);
            var decreaseAmount = 0;

            // Act
            product.DecreaseStock(decreaseAmount);
            var current = product.Stock;

            // Assert
            Assert.That(current, Is.EqualTo(200));
        }
        [Test]
        public void DecreaseStock_ShouldDecreaseStockByGivenAmount()
        {
            // Arrange
            var product = new Product(100, "Product1", 10.0m, 200);
            var decreaseAmount = 50;

            // Act
            product.DecreaseStock(decreaseAmount);
            var current = product.Stock;

            // Assert
            Assert.That(current, Is.EqualTo(150));
        }

        [Test]
        public void DecreaseStock_ShouldNotChangeStock_WhenAmountIsNegative()
        {
            // Arrange
            var product = new Product(100, "Product1", 10.0m, 30);
            var initialStock = product.Stock;
            var decreaseAmount = -5;

            // Act
            product.DecreaseStock(decreaseAmount);
            var current = product.Stock;

            // Assert
            Assert.That(current, Is.EqualTo(initialStock));
        }


    }
}
