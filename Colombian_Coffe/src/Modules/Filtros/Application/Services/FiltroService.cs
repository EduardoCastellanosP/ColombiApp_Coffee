using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colombian_Coffe.src.Modules.Filtros.Application.Interfaces;

namespace Colombian_Coffe.src.Modules.Filtros.Application.Services
{
    public class FiltroService : IFiltroService
    {
         private readonly IFiltroRepository _filtroRepository;

        public FiltroService(IFiltroRepository filtroRepository)
        {
            _filtroRepository = filtroRepository;
        }

        public async Task<IEnumerable<VariedadCafe>> ObtenerVariedadesFiltradasAsync(Filtro filtro)
        {
            
            return await _filtroRepository.ObtenerVariedadesFiltradasAsync(filtro);
        }
    }
}