using Redarbor.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redarbor.Service.IServices
{
    public interface IEmployeeService
    {
        List<EmployeeDto> Listar();

        List<EmployeeDto> Filtrar(int id);

        string Registrar(EmployeeDtoCreate entidad);

        string Modificar(EmployeeDtoUpdate entidad);

        string Eliminar(int id);
    }
}
