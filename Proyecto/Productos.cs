//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.Catologo = new HashSet<Catologo>();
        }
    
        public int idProductos { get; set; }
        public string Descripcion_del_producto { get; set; }
        public int Precio { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public int Compra_idCompra { get; set; }
        public byte[] Imagen_del_producto { get; set; }
        public int Proveedor_idProveedor { get; set; }
        public int Departamento_idDepartamento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Catologo> Catologo { get; set; }
        public virtual Compra Compra { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}