using Microsoft.AspNetCore.Mvc;
using Redarbor.Entity;
using Redarbor.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Redarbor.Service.IServices;
using Redarbor.Service.Dtos;

namespace Redarbor.Service.Controllers
{
    [ApiController]
    [Route("redarbor/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public List<EmployeeDto> GetAll()
        {            
            return _employeeService.Listar();
        }

        [HttpGet("{id}")]
        public List<EmployeeDto> Get(int id)
        {            
            return _employeeService.Filtrar(id);
        }

        [HttpPost]
        public string Post([FromBody] EmployeeDtoCreate entidad)
        {            
            return _employeeService.Registrar(entidad);
        }

        [HttpPut()]
        public string Put([FromBody] EmployeeDtoUpdate entidad)
        {            
            return _employeeService.Modificar(entidad);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {            
            return _employeeService.Eliminar(id);
        }
    }
}
