using System.Threading.Tasks;

namespace Fortune
{
    public interface IFortuneRepository
    {
        Task<Fortune> GetAsync(int fortuneId);
    }
}