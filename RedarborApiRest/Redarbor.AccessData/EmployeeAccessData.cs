using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Redarbor.Entity;

namespace Redarbor.AccessData
{
    public class EmployeeAccessData
    {
        public static List<EmployeeEntity> Listar()
        {
            var lista = new List<EmployeeEntity>();
            string cadenaConexion = "Data Source=22LAP5CD746D2BK;DataBase=Redarbor;Integrated Security=true";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Sp_Employee_List", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader command = cmd.ExecuteReader();


            while (command.Read())
            {
                EmployeeEntity oEmpleadoEntity = new EmployeeEntity();
                oEmpleadoEntity.Id = Convert.ToInt32(command["Id"]);
                oEmpleadoEntity.CompanyId = Convert.ToInt32(command["CompanyId"]);
                oEmpleadoEntity.CreatedOn = Convert.ToDateTime(command["CreatedOn"]);
                oEmpleadoEntity.DeletedOn = Convert.ToDateTime(command["DeletedOn"]);
                oEmpleadoEntity.Email = command["Email"].ToString().Trim();
                oEmpleadoEntity.Fax = command["Fax"].ToString().Trim();
                oEmpleadoEntity.Name = command["Name"].ToString().Trim();
                oEmpleadoEntity.Lastlogin = command["Lastlogin"].ToString().Trim();
                oEmpleadoEntity.Password = command["Password"].ToString().Trim();
                oEmpleadoEntity.PortalId = Convert.ToInt32(command["PortalId"]);
                oEmpleadoEntity.RoleId = Convert.ToInt32(command["RoleId"]);
                oEmpleadoEntity.StatusId = Convert.ToInt32(command["StatusId"]);
                oEmpleadoEntity.Telephone = command["Telephone"].ToString().Trim();
                oEmpleadoEntity.UpdatedOn = Convert.ToDateTime(command["UpdatedOn"]);
                oEmpleadoEntity.Username = command["Username"].ToString().Trim();
                lista.Add(oEmpleadoEntity);
            }
            return lista;
        }

        public static List<EmployeeEntity> Filtrar(int id)
        {
            var lista = new List<EmployeeEntity>();
            string cadenaConexion = "Data Source=22LAP5CD746D2BK;DataBase=Redarbor;Integrated Security=true";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Sp_Employee_Filter", cn);
            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.VarChar, 100)).Value = id;           

            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader command = cmd.ExecuteReader();


            while (command.Read())
            {
                EmployeeEntity oEmpleadoEntity = new EmployeeEntity();
                oEmpleadoEntity.Id = Convert.ToInt32(command["Id"]);
                oEmpleadoEntity.CompanyId = Convert.ToInt32(command["CompanyId"]);
                oEmpleadoEntity.CreatedOn = Convert.ToDateTime(command["CreatedOn"]);
                oEmpleadoEntity.DeletedOn = Convert.ToDateTime(command["DeletedOn"]);
                oEmpleadoEntity.Email = command["Email"].ToString().Trim();
                oEmpleadoEntity.Fax = command["Fax"].ToString().Trim();
                oEmpleadoEntity.Name = command["Name"].ToString().Trim();
                oEmpleadoEntity.Lastlogin = command["Lastlogin"].ToString().Trim();
                oEmpleadoEntity.Password = command["Password"].ToString().Trim();
                oEmpleadoEntity.PortalId = Convert.ToInt32(command["PortalId"]);
                oEmpleadoEntity.RoleId = Convert.ToInt32(command["RoleId"]);
                oEmpleadoEntity.StatusId = Convert.ToInt32(command["StatusId"]);
                oEmpleadoEntity.Telephone = command["Telephone"].ToString().Trim();
                oEmpleadoEntity.UpdatedOn = Convert.ToDateTime(command["UpdatedOn"]);
                oEmpleadoEntity.Username = command["Username"].ToString().Trim();
                lista.Add(oEmpleadoEntity);
            }
            return lista;
        }

        public static string Registrar(EmployeeEntity entidad)
        {
            var lista = new List<EmployeeEntity>();
            string cadenaConexion = "Data Source=22LAP5CD746D2BK;DataBase=Redarbor;Integrated Security=true";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Sp_Employee_Register", cn);            
            cmd.Parameters.Add(new SqlParameter("@CompanyId", SqlDbType.Int)).Value = entidad.CompanyId;
            cmd.Parameters.Add(new SqlParameter("@CreatedOn", SqlDbType.DateTime)).Value = entidad.CreatedOn;
            cmd.Parameters.Add(new SqlParameter("@DeletedOn", SqlDbType.DateTime)).Value = entidad.DeletedOn;
            cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 100)).Value = entidad.Email;
            cmd.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar, 100)).Value = entidad.Fax;
            cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 100)).Value = entidad.Name;
            cmd.Parameters.Add(new SqlParameter("@Lastlogin", SqlDbType.VarChar, 100)).Value = entidad.Lastlogin;
            cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 100)).Value = entidad.Password;
            cmd.Parameters.Add(new SqlParameter("@PortalId", SqlDbType.Int)).Value = entidad.PortalId;
            cmd.Parameters.Add(new SqlParameter("@RoleId", SqlDbType.Int)).Value = entidad.RoleId;
            cmd.Parameters.Add(new SqlParameter("@StatusId", SqlDbType.Int)).Value = entidad.StatusId;
            cmd.Parameters.Add(new SqlParameter("@Telephone", SqlDbType.VarChar, 100)).Value = entidad.Telephone;
            cmd.Parameters.Add(new SqlParameter("@UpdatedOn", SqlDbType.DateTime)).Value = entidad.UpdatedOn;
            cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 100)).Value = entidad.Username;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            return "Registro Exitoso";

        }

        public static string Modificar(EmployeeEntity entidad)
        {
            var lista = new List<EmployeeEntity>();
            string cadenaConexion = "Data Source=22LAP5CD746D2BK;DataBase=Redarbor;Integrated Security=true";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Sp_Employee_Update", cn);
            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)).Value = entidad.Id;
            cmd.Parameters.Add(new SqlParameter("@CompanyId", SqlDbType.Int)).Value = entidad.CompanyId;
            cmd.Parameters.Add(new SqlParameter("@CreatedOn", SqlDbType.DateTime)).Value = entidad.CreatedOn;
            cmd.Parameters.Add(new SqlParameter("@DeletedOn", SqlDbType.DateTime)).Value = entidad.DeletedOn;
            cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 100)).Value = entidad.Email;
            cmd.Parameters.Add(new SqlParameter("@Fax", SqlDbType.VarChar, 100)).Value = entidad.Fax;
            cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 100)).Value = entidad.Name;
            cmd.Parameters.Add(new SqlParameter("@Lastlogin", SqlDbType.VarChar, 100)).Value = entidad.Lastlogin;
            cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 100)).Value = entidad.Password;
            cmd.Parameters.Add(new SqlParameter("@PortalId", SqlDbType.Int)).Value = entidad.PortalId;
            cmd.Parameters.Add(new SqlParameter("@RoleId", SqlDbType.Int)).Value = entidad.RoleId;
            cmd.Parameters.Add(new SqlParameter("@StatusId", SqlDbType.Int)).Value = entidad.StatusId;
            cmd.Parameters.Add(new SqlParameter("@Telephone", SqlDbType.VarChar, 100)).Value = entidad.Telephone;
            cmd.Parameters.Add(new SqlParameter("@UpdatedOn", SqlDbType.DateTime)).Value = entidad.UpdatedOn;
            cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.VarChar, 100)).Value = entidad.Username;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            return "Modificación Exitosa";

        }

        public static string Eliminar(int id)
        {
            var lista = new List<EmployeeEntity>();
            string cadenaConexion = "Data Source=22LAP5CD746D2BK;DataBase=Redarbor;Integrated Security=true";
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Sp_Empleado_Delete", cn);
            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)).Value = id;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            return "Eliminación Exitosa";

        }
    }
}
