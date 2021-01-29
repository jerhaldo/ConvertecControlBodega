using ConvertecControlBodega.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertecControlBodega.Business
{
    class MovimientoBusiness
    {
        public static List<MovSalidasDataGridDTO> GetMovimientos()
        {
            using (var db = new ConvertecBodegaEntities())
            {
                var data = (
                    from m in db.Movimiento 
                    join s in db.Salida_Prod on m.id_mov equals s.id_mov
                    join p in db.Producto on m.id_producto equals p.id_producto
                    join t in db.Trabajador on s.id_trabajador equals t.id_trabajador
                    orderby m.fecha_mov descending
                    select new MovSalidasDataGridDTO
                    {
                        id_mov = m.id_mov,
                        cod_bodega = p.cod_bodega,
                        descripcion = p.descripcion,
                        cantidad = m.cantidad,
                        fecha_mov = m.fecha_mov,
                        ot = m.ot,
                        obs_mov = m.obs_mov,
                        nombre = t.nombre,
                        apellidos = t.apellidos
                    }
                ).ToList();

                db.Dispose();

                return data;
            }
        }
    }
}
