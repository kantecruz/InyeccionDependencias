using InyeccionDependencias.Entities;
using InyeccionDependencias.Interface;
using System.Collections.Generic;

namespace InyeccionDependencias.Service
{
    public class EmpleadoServices: IEmpleadoService
    {
        public List<Empleado> GetEmpleados(){
            List<Empleado> lista = new List<Empleado>();
            lista.Add(new Empleado() {Id=1,NombreCompleto="Carlos Kante Cruz",DNI="123456" });
            lista.Add(new Empleado() { Id = 2, NombreCompleto = "Juan Lopez", DNI="654321" });
            return lista;
        }

    }
}
