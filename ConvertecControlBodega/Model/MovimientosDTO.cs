using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertecControlBodega.Model
{
    class MovSalidasDataGridDTO
    {
        public long id_mov { get; set; }
        public Nullable<long> cod_bodega { get; set; }
        public string descripcion { get; set; }
        public double cantidad { get; set; }
        public System.DateTime fecha_mov { get; set; }
        public string ot { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string obs_mov { get; set; }

    }
}
