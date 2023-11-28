using PersonalSite.Models;
using System.Threading.Tasks;

namespace PersonalSite.Services
{
    public interface IMailService
    {
        Task Send(Email email);
    }
}