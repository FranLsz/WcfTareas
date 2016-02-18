using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfTareasServicio.Models.DTO;

namespace WcfTareasServicio
{
    [ServiceContract]
    public interface IServicioUsuario
    {
        UsuarioDTO GetProfesor(int id);

        [OperationContract]
        List<UsuarioDTO> GetAllUsuario();

        [OperationContract]
        void AddUsuario(UsuarioDTO us);
    }
}
