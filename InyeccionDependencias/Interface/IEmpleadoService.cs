using InyeccionDependencias.Entities;
using System.Collections.Generic;

namespace InyeccionDependencias.Interface
{
    public interface IEmpleadoService
    {
        List<Empleado> GetEmpleados();
    }
}
