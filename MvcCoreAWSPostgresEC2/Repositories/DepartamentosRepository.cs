using Microsoft.EntityFrameworkCore;
using MvcCoreAWSPostgresEC2.Data;
using MvcCoreAWSPostgresEC2.Models;

namespace MvcCoreAWSPostgresEC2.Repositories
{
    public class DepartamentosRepository
    {
        private DepartamentosContext context;
        public DepartamentosRepository(DepartamentosContext context)
        {
            this.context = context;
        }

        public async Task<List<Departamento>> GetDepartamentosAsync()
        {
            return await this.context.Departamentos.ToListAsync();
        }

        public async Task<Departamento> FindDepartamentoAsync(int id)
        {
            return await this.context.Departamentos
                .FirstOrDefaultAsync(x => x.IdDepartamento == id);
        }

        public async Task InsertDepartamentoAsync(int id,string nombre,string loc)
        {
            await this.context.Departamentos.AddAsync(new Departamento
            {
                IdDepartamento = id,
                Localidad = loc,
                Nombre = nombre
            });
            await this.context.SaveChangesAsync();
        }
    }
}
