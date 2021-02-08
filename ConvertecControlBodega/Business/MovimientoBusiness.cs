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
                    select new DescProducto
                    {
                        descripcion = p.descripcion,
                        nom_marca = m.nom_marca,
                        nom_proveedor = pr.nom_proveedor,
                        parte_plano = p.parte_plano,
                        obs = p.obs,
                        image = im.image,
                        id_producto = p.id_producto
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
                var result = (from t in db.Producto
                              where t.cod_bodega == cod
                              select t.cod_bodega).Any();

                return result;
            }
        }

        public static ProdSalida AddToList(int id_prod, string ot, double cantidad, string obs_mov, int id_trabajador, int folio)
        {
            var data = new ProdSalida {
                id_producto = id_prod,
                fecha_mov = System.DateTime.Now,
                ot = ot,
                cantidad = cantidad,
                obs_mov = obs_mov,
                id_trabajador = id_trabajador,
                folio = folio
            };

            return data;
        }

    }
}
