using System.Threading.Tasks;
using ProCarlosV1.Models.TokenAuth;
using ProCarlosV1.Web.Controllers;
using Shouldly;
using Xunit;

namespace ProCarlosV1.Web.Tests.Controllers
{
    public class HomeController_Tests: ProCarlosV1WebTestBase
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