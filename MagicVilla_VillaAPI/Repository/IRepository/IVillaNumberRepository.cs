using MagicT_TAPI.Repository.IRepository;
using MagicVilla_VillaAPI.Models;
using System.Threading.Tasks;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
