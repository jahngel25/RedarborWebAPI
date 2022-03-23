using System;
using System.Collections.Generic;
using System.Text;
using Redarbor.Dominio.IRepositories;
using Redarbor.Dominio;
using Redarbor.Entity;

namespace Redarbor.Dominio.Persistence.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeDomain _employeeDomain = new EmployeeDomain();
        

        public string Eliminar(int id)
        {
            try
            {                
                return _employeeDomain.Eliminar(id);
            }
            catch(Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public List<EmployeeEntity> Filtrar(int id)
        {
            try
            {
                return _employeeDomain.Filtrar(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<EmployeeEntity> Listar()
        {
            try
            {
                return _employeeDomain.Listar();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string Modificar(EmployeeEntity entidad)
        {
            try
            {
                return _employeeDomain.Modificar(entidad);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string Registrar(EmployeeEntity entidad)
        {
            try
            {
                return _employeeDomain.Registrar(entidad);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
