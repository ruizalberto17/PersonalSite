using System.Threading.Tasks;
using PersonalSite.Models;

namespace PersonalSite.Services
{
    public interface IMailService
    {
        Task Send(Email email);
    }
}