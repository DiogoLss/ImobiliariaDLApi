using ImobiliariaDLApi.Context;
using ImobiliariaDLApi.Models;

namespace ImobiliariaDLApi.Repository
{
    public class ImagemRepository : Repository<Imagem>, IImagemRepository
    {
        public ImagemRepository(ImobiliariaDLDbContext context) : base(context)
        {
        }
    }
}
