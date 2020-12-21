using CLU.Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CLU.Controllers
{
    public class SolicitudLegitimoUsuarioController : ApiController
    {
        modelEntities BD = new modelEntities();
        public IEnumerable<SolicitudLegitimoUsuario> Get() 
        {
            var listado = BD.SolicitudLegitimoUsuario.ToList();
            return listado;
        } 

    }
}
