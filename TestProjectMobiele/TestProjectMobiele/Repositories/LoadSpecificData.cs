using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMobiele.Repositories
{
    class LoadSpecificData
    {
        private IDataConnection dbContext;
        public LoadSpecificData(IDataConnection dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Foto> LoadFotos(int FotoID)
        {
            return await dbContext.Fotos.SingleAsync(item => item.FotoID == FotoID);
        }

        public async Task<Gezin> LoadGezinnen(int GezinsID)
        {
            return await dbContext.Gezinnen.SingleAsync(item => item.GezinsID == GezinsID);
        }

        public async Task<Hoek> LoadHoeken(int HoekID)
        {
            return await dbContext.Hoekken.SingleAsync(item => item.HoekID == HoekID);
        }

        public async Task<Klas> LoadKlassen(int KlasID)
        {
            return await dbContext.Klassen.SingleAsync(item => item.KlasID == KlasID);
        }

        public async Task<Kleuter> LoadKleuters(int KleuterID)
        {
            return await dbContext.Kleuters.SingleAsync(item => item.KleuterID == KleuterID);
        }

        public async Task<Leerkracht> LoadLeerkrachten(string LeerkrachtCode)
        {
            return await dbContext.Leerkrachten.SingleAsync(item => item.LeerkrachtCode == LeerkrachtCode);
        }

        public async Task<School> LoadScholen(int SchoolID)
        {
            return await dbContext.Scholen.SingleAsync(item => item.SchoolID == SchoolID);
        }
    }
}
