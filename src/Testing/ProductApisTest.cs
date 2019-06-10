using System.Threading.Tasks;
using Xunit;
using Newtonsoft.Json;
using dotnetsqlserverexample.Models;
using System.Net.Http;
using System;
using System.Text;

namespace Testing
{
    public class ProductApisTest : TestFixture
    {
        [Fact]
        public async Task Test_Get_Products()
        {
            Console.WriteLine(_client);
            // Act
            var response = await _client.GetAsync("/api/products");

            // Assert
            response.EnsureSuccessStatusCode();
        }


        [Fact]
        public async Task Test_Post_Products()
        {
            var productModel = new Product
            {
                Name = "C# Programming",
                Price = (decimal)35.44
            };

            // Act
            var contents = new StringContent(JsonConvert.SerializeObject(productModel), Encoding.UTF8, "application/json");
            // Act
            var response = await _client.PostAsync("/api/products", contents);

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<Product>(responseString);
            // Console.WriteLine(product);

            Assert.True(product.Id > 0);
        }
    }
}
