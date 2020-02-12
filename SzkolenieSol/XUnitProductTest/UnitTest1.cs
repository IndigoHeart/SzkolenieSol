using System;
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


            //Assert
        }
    }
}
