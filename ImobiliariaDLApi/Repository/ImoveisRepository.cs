using ImobiliariaDLApi.Context;
using ImobiliariaDLApi.Models;

namespace ImobiliariaDLApi.Repository
{
    public class ImoveisRepository : Repository<Imovel>, IImoveisRepository
    {
        public ImoveisRepository(ImobiliariaDLDbContext context) : base(context)
        {
        }
    }
}
