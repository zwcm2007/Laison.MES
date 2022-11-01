using System.Threading.Tasks;
using Laison.MES.Application.Contracts;
using Shouldly;
using Xunit;

namespace Laison.MES.Samples
{
    public class SampleAppService_Tests : MESApplicationTestBase
    {
        private readonly IUserAppService _orderAppService;

        public SampleAppService_Tests()
        {
            _orderAppService = GetRequiredService<IUserAppService>();
        }

        //[Fact]
        //public async Task GetAsync()
        //{
        //    var result = await _sampleAppService.GetAsync();
        //    result.Value.ShouldBe(42);
        //}

        //[Fact]
        //public async Task GetAuthorizedAsync()
        //{
        //    var result = await _sampleAppService.GetAuthorizedAsync();
        //    result.Value.ShouldBe(42);
        //}
    }
}
