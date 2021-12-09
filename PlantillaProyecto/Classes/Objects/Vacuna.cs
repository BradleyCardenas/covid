using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantillaProyecto.Classes.Objects
{
    public class Vacuna{
        string marca;
        string dosis;
        DateTime fecha_vacuna;
        string sede;

        public Vacuna() { }

        public string Marca { get => marca; set => marca = value; }
        public string Dosis { get => dosis; set => dosis = value; }
        public DateTime Fecha_vacuna { get => fecha_vacuna; set => fecha_vacuna = value; }
        public string Sede { get => sede; set => sede = value; }
    }
}
