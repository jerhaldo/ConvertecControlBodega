//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConvertecControlBodega.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingreso_Prod
    {
        public long id_mov { get; set; }
        public int id_proveedor { get; set; }
        public int id_marca { get; set; }
        public string cod_prod_prov { get; set; }
        public string documento { get; set; }
        public int valor { get; set; }
        public Nullable<int> valor_unitario { get; set; }
    
        public virtual Marca Marca { get; set; }
        public virtual Movimiento Movimiento { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
