using EscolaMVC.IServices;
using EscolaMVC.Models.Entities;

namespace EscolaMVC.Data
{
    public class SeedingService
    {
        private MeuContexto meuContexto;

        public SeedingService(MeuContexto meuContexto)
        {
            this.meuContexto = meuContexto;
        }
        public void Seed()
        {
            
        }
    }
}
