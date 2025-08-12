using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colombian_Coffe.src.Modules.Filtros.Domain.Entities;

public class Filtro
{
    public string Porte { get; set; } 

    // Tamaño del grano: Pequeño, Medio, Grande
    public string TamañoGrano { get; set; } 

    // Altitud óptima de siembra (puede ser rango)
    public int? AltitudMinima { get; set; }
    public int? AltitudMaxima { get; set; }

    // Potencial de rendimiento (de muy bajo a excepcional)
    public string PotencialRendimiento { get; set; }

    // Calidad del grano según altitud (1 a 5)
    public int? CalidadGrano { get; set; }

    // Resistencias a enfermedades: roya, antracnosis, nematodos
    public string ResistenciaRoya { get; set; } 
    public string ResistenciaAntracnosis { get; set; }
    public string ResistenciaNematodos { get; set; }

    // Otros filtros agronómicos opcionales
    public int? TiempoCosecha { get; set; }  
    public int? Maduracion { get; set; }      
    public string Nutricion { get; set; }     
    public int? DensidadSiembra { get; set; }
}
