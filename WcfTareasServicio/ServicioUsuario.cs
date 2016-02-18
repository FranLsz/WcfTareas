using System.Collections.Generic;
using System.Linq;
using WcfTareasServicio.Models;
using WcfTareasServicio.Models.DTO;

namespace WcfTareasServicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioUsuario" in both code and config file together.
    public class ServicioUsuario : IServicioUsuario
    {
        public UsuarioDTO GetProfesor(int id)
        {
            using (var db = new GestionDeTareas15Entities())
            {
                var u = db.Usuario.Find(id);

                var udto = UsuarioDTO.FromUsuario(u);

                return udto;
            }
        }

        public List<UsuarioDTO> GetAllUsuario()
        {
            using (var db = new GestionDeTareas15Entities())
            {
                var udto = UsuarioDTO.FromListUsuario(db.Usuario.ToList());

                return udto;
            }

        }

        public void AddUsuario(UsuarioDTO us)
        {
            var u = us.ToUsuario();

            using (var db = new GestionDeTareas15Entities())
            {
                db.Usuario.Add(u);
                db.SaveChanges();
            }
        }
    }
}
