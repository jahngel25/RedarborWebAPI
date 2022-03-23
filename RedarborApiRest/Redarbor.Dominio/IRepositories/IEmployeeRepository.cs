using Redarbor.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Redarbor.Dominio.IRepositories
{
    public interface IEmployeeRepository
    {
        List<EmployeeEntity> Listar();

        List<EmployeeEntity> Filtrar(int id);

        string Registrar(EmployeeEntity entidad);

        string Modificar(EmployeeEntity entidad);

        string Eliminar(int id);

    }
}
