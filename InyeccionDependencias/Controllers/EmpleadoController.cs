using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InyeccionDependencias.Entities;
using InyeccionDependencias.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InyeccionDependencias.Controllers
{
    [Route("api/Empleado")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        IEmpleadoService _empleadoService;
        public EmpleadoController(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }

        [HttpGet]
        public IEnumerable<Empleado> Get() {

            return _empleadoService.GetEmpleados();
        }
    }
}