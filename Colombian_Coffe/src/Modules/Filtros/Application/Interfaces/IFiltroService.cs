using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colombian_Coffe.src.Modules.Filtros.Application.Interfaces
{
    public interface IFiltroService
    {
        Task<IEnumerable<VariedadCafe>> ObtenerVariedadesFiltradasAsync(Filtro filtro);
    }
}