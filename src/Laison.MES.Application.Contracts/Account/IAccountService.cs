using Laison.MES.Application.Contracts;
using System.Threading.Tasks;

namespace Laison.MES.Application.Contracts
{
    public interface IAccountService
    {
        Task LoginAsync(LoginParamsType model);
        Task<string> GetCaptchaAsync(string modile);
    }
}