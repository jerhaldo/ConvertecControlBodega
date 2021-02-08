using System;

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

    class IdTrabajdor
    {
        public int id_trabajador { get; set; }
    }

    class NumeroOt
    {
        public string ot { get; set; }
    }

    class CodBodegaProducto
    {
        public Nullable<long> cod_bodega { get; set; }
    }

    class NombreTrabajador
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
    }

    class DescProducto
    {
        public string descripcion { get; set; }
        public string nom_proveedor { get; set; }
        public string nom_marca { get; set; }
        public string parte_plano { get; set; }
        public string obs { get; set; }
        public string image { get; set; }
        public int id_producto { get; set; }
    }

    class ProdSalida
    {
        public int id_producto { get; set; }
        public System.DateTime fecha_mov { get; set; }
        public string ot { get; set; }
        public double cantidad { get; set; }
        public string obs_mov { get; set; }
        public int id_trabajador { get; set; }
        public int folio { get; set; }
    }
}
