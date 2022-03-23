using Redarbor.Entity;
using Redarbor.AccessData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Redarbor.Dominio
{
    public class EmployeeDomain
    {
        public List<EmployeeEntity> Listar()
        {
            return EmployeeAccessData.Listar();
        }

        public List<EmployeeEntity> Filtrar(int id)
        {
            return EmployeeAccessData.Filtrar(id);
        }

        public string Registrar(EmployeeEntity entidad)
        {
            return EmployeeAccessData.Registrar(entidad);

        }

        public string Modificar(EmployeeEntity entidad)
        {
            return EmployeeAccessData.Modificar(entidad);

        }

        public string Eliminar(int id)
        {
            return EmployeeAccessData.Eliminar(id);

        }
    }
}
