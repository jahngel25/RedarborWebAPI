using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Redarbor.Dominio.IRepositories;
using Redarbor.Entity;
using Redarbor.Service.Dtos;
using Redarbor.Service.IServices;

namespace Redarbor.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public string Eliminar(int id)
        {
            try
            {
                var result = _employeeRepository.Eliminar(id);
                return result;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public List<EmployeeDto> Filtrar(int id)
        {
            try
            {
                var result = _employeeRepository.Filtrar(id);
                List<EmployeeDto> employeeDtos = result.Select(item => new EmployeeDto
                {
                    Id = item.Id,
                    CompanyId = item.CompanyId,
                    CreatedOn = item.CreatedOn,
                    DeletedOn = item.DeletedOn,
                    Email = item.Email,
                    Fax = item.Fax,
                    Name = item.Name,
                    Lastlogin = item.Lastlogin,
                    Password = item.Password,
                    PortalId = item.PortalId,
                    RoleId = item.RoleId,
                    StatusId = item.StatusId,
                    Telephone = item.Telephone,
                    UpdatedOn = item.UpdatedOn,
                    Username = item.Username
                }).ToList();

                return employeeDtos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<EmployeeDto> Listar()
        {            
            try
            {
                var result = _employeeRepository.Listar();
                List<EmployeeDto> employeeDtos = result.Select(item => new EmployeeDto
                {
                    Id = item.Id,
                    CompanyId = item.CompanyId,
                    CreatedOn = item.CreatedOn,
                    DeletedOn = item.DeletedOn,
                    Email = item.Email,
                    Fax = item.Fax,
                    Name = item.Name,
                    Lastlogin = item.Lastlogin,
                    Password = item.Password,
                    PortalId = item.PortalId,
                    RoleId = item.RoleId,
                    StatusId = item.StatusId,
                    Telephone = item.Telephone,
                    UpdatedOn = item.UpdatedOn,
                    Username = item.Username
                }).ToList();

                return employeeDtos;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public string Modificar(EmployeeDtoUpdate entidad)
        {
            try
            {
                EmployeeEntity employee = new EmployeeEntity();
                employee.Id = entidad.Id;
                employee.CompanyId = entidad.CompanyId;
                employee.CreatedOn = entidad.CreatedOn;
                employee.DeletedOn = entidad.DeletedOn;
                employee.Email = entidad.Email;
                employee.Fax = entidad.Fax;
                employee.Name = entidad.Name;
                employee.Lastlogin = entidad.Lastlogin;
                employee.Password = entidad.Password;
                employee.PortalId = entidad.PortalId;
                employee.RoleId = entidad.RoleId;
                employee.StatusId = entidad.StatusId;
                employee.Telephone = entidad.Telephone;
                employee.UpdatedOn = entidad.UpdatedOn;
                employee.Username = entidad.Username;
                var result = _employeeRepository.Modificar(employee);

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string Registrar(EmployeeDtoCreate entidad)
        {
            try
            {
                EmployeeEntity employee = new EmployeeEntity();
                employee.CompanyId = entidad.CompanyId;
                employee.CreatedOn = entidad.CreatedOn;
                employee.DeletedOn = entidad.DeletedOn;
                employee.Email = entidad.Email;
                employee.Fax = entidad.Fax;
                employee.Name = entidad.Name;
                employee.Lastlogin = entidad.Lastlogin;
                employee.Password = entidad.Password;
                employee.PortalId = entidad.PortalId;
                employee.RoleId = entidad.RoleId;
                employee.StatusId = entidad.StatusId;
                employee.Telephone = entidad.Telephone;
                employee.UpdatedOn = entidad.UpdatedOn;
                employee.Username = entidad.Username;
                var result = _employeeRepository.Registrar(employee);

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
