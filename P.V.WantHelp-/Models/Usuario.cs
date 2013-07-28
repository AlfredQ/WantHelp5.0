//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P.V.WantHelp_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.archivos = new HashSet<archivos>();
            this.Comentarios = new HashSet<Comentarios>();
            this.inscripcion = new HashSet<inscripcion>();
            this.Material = new HashSet<Material>();
            this.mensajes = new HashSet<mensajes>();
            this.Preguntas = new HashSet<Preguntas>();
            this.puntuacionChat = new HashSet<puntuacionChat>();
            this.puntuacionRes = new HashSet<puntuacionRes>();
            this.Respuestas = new HashSet<Respuestas>();
            this.Respuestas_Chat = new HashSet<Respuestas_Chat>();
        }
        [Required]
        public int Id_Usu { get; set; }
       [Required]
        public string Nombre { get; set; }
        public string Apellido_P { get; set; }       
        public string Apellido_M { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string sexo { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Estado { get; set; }
        public string Avatar { get; set; }
    
        public virtual ICollection<archivos> archivos { get; set; }
        public virtual ICollection<Comentarios> Comentarios { get; set; }
        public virtual ICollection<inscripcion> inscripcion { get; set; }
        public virtual ICollection<Material> Material { get; set; }
        public virtual ICollection<mensajes> mensajes { get; set; }
        public virtual ICollection<Preguntas> Preguntas { get; set; }
        public virtual ICollection<puntuacionChat> puntuacionChat { get; set; }
        public virtual ICollection<puntuacionRes> puntuacionRes { get; set; }
        public virtual ICollection<Respuestas> Respuestas { get; set; }
        public virtual ICollection<Respuestas_Chat> Respuestas_Chat { get; set; }
    }
}
