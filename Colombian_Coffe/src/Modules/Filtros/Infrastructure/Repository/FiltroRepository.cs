using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colombian_Coffe.src.Modules.Filtros.Application.Interfaces;
using Colombian_Coffe.src.Shared.Context;
using Microsoft.EntityFrameworkCore;

namespace Colombian_Coffe.src.Modules.Filtros.Infrastructure.Repository
{
    public class FiltroRepository : IFiltroRepository
    {
        private readonly AppDbContext _context;
        public FiltroRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<VariedadCafe>> ObtenerVariedadesFiltradasAsync(Filtro filtro)
        {
            // Consulta base
            var query = _context.VariedadesCafe.AsQueryable();

            // Aplica filtros dinámicos solo si no son null o vacíos
            if (!string.IsNullOrEmpty(filtro.Porte))
                query = query.Where(v => v.Porte == filtro.Porte);

            if (!string.IsNullOrEmpty(filtro.TamañoGrano))
                query = query.Where(v => v.TamañoGrano == filtro.TamañoGrano);

            if (filtro.AltitudMinima.HasValue)
                query = query.Where(v => v.AltitudOptimaSiembra >= filtro.AltitudMinima.Value);

            if (filtro.AltitudMaxima.HasValue)
                query = query.Where(v => v.AltitudOptimaSiembra <= filtro.AltitudMaxima.Value);

            if (!string.IsNullOrEmpty(filtro.PotencialRendimiento))
                query = query.Where(v => v.PotencialRendimiento == filtro.PotencialRendimiento);

            if (filtro.CalidadGrano.HasValue)
                query = query.Where(v => v.CalidadGrano == filtro.CalidadGrano.Value);

            if (!string.IsNullOrEmpty(filtro.ResistenciaRoya))
                query = query.Where(v => v.ResistenciaRoya == filtro.ResistenciaRoya);

            if (!string.IsNullOrEmpty(filtro.ResistenciaAntracnosis))
                query = query.Where(v => v.ResistenciaAntracnosis == filtro.ResistenciaAntracnosis);

            if (!string.IsNullOrEmpty(filtro.ResistenciaNematodos))
                query = query.Where(v => v.ResistenciaNematodos == filtro.ResistenciaNematodos);

            if (filtro.TiempoCosecha.HasValue)
                query = query.Where(v => v.TiempoCosecha == filtro.TiempoCosecha.Value);

            if (filtro.Maduracion.HasValue)
                query = query.Where(v => v.Maduracion == filtro.Maduracion.Value);

            if (!string.IsNullOrEmpty(filtro.Nutricion))
                query = query.Where(v => v.Nutricion == filtro.Nutricion);

            if (filtro.DensidadSiembra.HasValue)
                query = query.Where(v => v.DensidadSiembra == filtro.DensidadSiembra.Value);

            return await query.ToListAsync();
        }
    }
}