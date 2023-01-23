using System.Threading.Tasks;
using Warehouse.Models.TokenAuth;
using Warehouse.Web.Controllers;
using Shouldly;
using Xunit;

namespace Warehouse.Web.Tests.Controllers
{
    public class HomeController_Tests: WarehouseWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}