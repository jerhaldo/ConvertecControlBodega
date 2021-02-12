using ConvertecControlBodega.Model;
using System.Collections.Generic;
using System.Linq;

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
                        cod_bodega = p.cod_bodega,
                        descripcion = p.descripcion,
                        cantidad = m.cantidad,
                        fecha_mov = m.fecha_mov,
                        ot = m.ot,
                        obs_mov = m.obs_mov,
                        nombre = t.nombre,
                        apellidos = t.apellidos
                    }
                ).Take(100).ToList();

                db.Dispose();

                return data;
            }
        }

        public static List<IdTrabajdor> GetIDs()
        {
            using (var db = new ConvertecBodegaEntities())
            {
                var data = (
                    from t in db.Trabajador
                    select new IdTrabajdor
                    {
                        id_trabajador = t.id_trabajador
                    }
                ).ToList();

                db.Dispose();

                return data;
            }
        }

        public static List<NumeroOt> GetOt()
        {
            using (var db = new ConvertecBodegaEntities())
            {
                var data = (
                    from m in db.Movimiento
                    orderby m.ot
                    select new NumeroOt
                    {
                        ot = m.ot
                    }
                ).ToList();

                db.Dispose();

                return data;
            }
        }

        public static NombreTrabajador GetNombre(int id)
        {
            using (var db = new ConvertecBodegaEntities())
            {
                var data = (
                    from t in db.Trabajador
                    where t.id_trabajador == id
                    select new NombreTrabajador
                    {
                        nombre = t.nombre,
                        apellidos = t.apellidos
                    }
                ).SingleOrDefault();

                db.Dispose();

                return data;
            }
        }

        public static bool CheckId(int id)
        {
            using (var db = new ConvertecBodegaEntities())
            {
                var result = (from t in db.Trabajador
                              where t.id_trabajador == id
                              select t.id_trabajador).Any();

                return result;
            }
        }

        public static List<CodBodegaProducto> GetCodBodegaProductos()
        {
            using (var db = new ConvertecBodegaEntities())
            {
                var data = (
                    from p in db.Producto
                    where p.cod_bodega != null
                    where p.borrado == false
                    select new CodBodegaProducto
                    {
                        cod_bodega = p.cod_bodega
                    }
                ).ToList();

                db.Dispose();

                return data;
            }
        }

        public static DescProducto GetDescProductos(int cod)
        {
            using (var db = new ConvertecBodegaEntities())
            {
                var data = (
                    from p in db.Producto
                    join m in db.Marca on p.id_marca equals m.id_marca
                    join pr in db.Proveedor on p.id_proveedor equals pr.id_proveedor
                    join im in db.Imagen_Producto on p.id_producto equals im.id_producto
                    where p.cod_bodega == cod
                    where p.borrado == false
                    select new DescProducto
                    {
                        descripcion = p.descripcion,
                        nom_marca = m.nom_marca,
                        nom_proveedor = pr.nom_proveedor,
                        parte_plano = p.parte_plano,
                        obs = p.obs,
                        image = im.image,
                        id_producto = p.id_producto,
                        stock = p.stock
                    }
                ).SingleOrDefault();

                db.Dispose();

                return data;
            }
        }

        public static bool CheckProducto(int cod)
        {
            using (var db = new ConvertecBodegaEntities())
            {
                var result = (from p in db.Producto
                              where p.cod_bodega == cod
                              where p.borrado == false
                              select p.cod_bodega).Any();

                return result;
            }
        }

        public static void InsertSalida(List<ProdSalida> prodSalList)
        {
            ConvertecBodegaEntities db = new ConvertecBodegaEntities();
            foreach (ProdSalida prodsalida in prodSalList)
            {
                //INSERT MOVIMIENTO
                Movimiento mov = new Movimiento
                {
                    id_producto = prodsalida.id_producto,
                    fecha_mov = prodsalida.fecha_mov,
                    cantidad = prodsalida.cantidad,
                    ot = prodsalida.ot,
                    obs_mov = prodsalida.obs_mov
                };
                db.Movimiento.Add(mov);
                db.SaveChanges();

                //INSERT SALIDA
                Salida_Prod pd = new Salida_Prod
                {
                    id_mov = mov.id_mov,
                    id_trabajador = prodsalida.id_trabajador,
                    folio = prodsalida.folio
                };
                db.Salida_Prod.Add(pd);
                db.SaveChanges();

                //UPDATE STOCK DEL PRODUCTO
                var producto = db.Producto.SingleOrDefault(p => p.id_producto == prodsalida.id_producto);
                if (producto != null)
                {
                    producto.stock = producto.stock - prodsalida.cantidad;
                    db.SaveChanges();
                }
            }
        }

        public static bool GetDisponibilidad(double stock, double cant)
        {
            if ((stock - cant) < 0)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
