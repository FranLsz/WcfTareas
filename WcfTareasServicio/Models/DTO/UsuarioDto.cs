using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WcfTareasServicio.Models.DTO
{
    [DataContract]
    public class UsuarioDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellidos { get; set; }
        [DataMember]
        public string Avatar { get; set; }

        public Usuario ToUsuario()
        {
            return new Usuario()
            {
                Id = Id,
                Email = Email,
                Password = Password,
                Nombre = Nombre,
                Apellidos = Apellidos,
                Avatar = Avatar
            };
        }

        public static List<UsuarioDTO> FromListUsuario(List<Usuario> lista)
        {
            var l = new List<UsuarioDTO>();
            foreach (var item in lista)
            {
                l.Add(UsuarioDTO.FromUsuario(item));
            }

            return l;
        }

        public static UsuarioDTO FromUsuario(Usuario u)
        {
           return new UsuarioDTO()
            {
                Id = u.Id,
                Email = u.Email,
                Password = u.Password,
                Nombre = u.Nombre,
                Apellidos = u.Apellidos,
                Avatar = u.Avatar
            };
        }
    }
}