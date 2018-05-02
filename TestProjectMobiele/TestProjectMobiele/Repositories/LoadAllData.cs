using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace TestProjectMobiele
{
    public class LoadAllData
    {
        private IDataConnection dbContext;

        public LoadAllData(IDataConnection dbContext)
        {
            this.dbContext = dbContext; 
        }

        public async Task<List<Foto>> LoadFotos()
        {
            return await dbContext.Fotos.ToListAsync();
        }

        public async Task<List<Gezin>> LoadGezinnen()
        {
            return await dbContext.Gezinnen.ToListAsync();
        }

        public async Task<List<Hoek>> LoadHoeken()
        {
            return await dbContext.Hoekken.ToListAsync();
        }

        public async Task<List<Klas>> LoadKlassen()
        {
            return await dbContext.Klassen.ToListAsync();
        }

        public async Task<List<Kleuter>> LoadKleuters()
        {
            return await dbContext.Kleuters.ToListAsync();
        }

        public async Task<List<Leerkracht>> LoadLeerkrachten()
        {
            return await dbContext.Leerkrachten.ToListAsync();
        }

        public async Task<List<School>> LoadScholen()
        {
            return await dbContext.Scholen.ToListAsync();
        }
    }
}
