using System;
using Szkolenie.Controllers;
using Szkolenie.Data;
using Szkolenie.Models;
using Xunit;

namespace XUnitProductTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddProduct()
        {
            //Arrange
            var p = new Product { Name = "Test name", Author = "Test author", ReleaseDate = DateTime.Now, UserRate = 2, NumberOfPages = 123 };

            //Act
            var context = new ApplicationDbContext();
            var repo = new ProductRepository(context);
            var prodcontroler = new ProductsController(productRepository);
            //Assert
        }
    }
}
