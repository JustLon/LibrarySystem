//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaPresentacion.BaseDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class prestamo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public prestamo()
        {
            this.detalle_prestamo = new HashSet<detalle_prestamo>();
        }
    
        public int idPrestamo { get; set; }
        public int id_usuario { get; set; }
        public int id_usario_admin { get; set; }
        public System.DateTime fecha_prestamo { get; set; }
        public System.DateTime fecha_devolucion { get; set; }
        public Nullable<int> id_estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalle_prestamo> detalle_prestamo { get; set; }
        public virtual estado estado { get; set; }
        public virtual usuariosPrestamista usuariosPrestamista { get; set; }
        public virtual usuarios_admin usuarios_admin { get; set; }
    }
}