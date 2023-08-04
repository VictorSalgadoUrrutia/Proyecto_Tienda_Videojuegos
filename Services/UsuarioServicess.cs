using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Relational;
using Proyecto_majo.Entities;
using Proyecto_majo.Proyecto_MajoDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_majo.Services
{
    public class UsuarioServicess
    {
        public Vendedor Login(string username, string password)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    var usuario = _context.Vendedor.Include(y => y.Roles).FirstOrDefault(x => x.UserName == username && x.Password == password ) ;
                    return usuario;
                }
                //Include(y => y.Roles).FirstOrDefault(x => x.UserName == username && x.Password == password)
            }
            catch (Exception f)
            {

                throw new Exception("error" + f.Message);
            }
        }

        public List<Vendedor> GetVendedor()
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    List<Vendedor> vendedores = new List<Vendedor>();

                    vendedores = _context.Vendedor.Include(x => x.Roles).ToList();

                    return vendedores;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Succedio un error " + ex.Message);
            }
        }

        public List<Roles> GetRoles()
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    List<Roles> roles = _context.Roles.ToList();

                    return roles;
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Succedio un error" + ex.Message);
            }
        }

        public void AddUser(Vendedor request)
        {
            try
            {
                if (request != null)
                {
                    using (var _context = new ApplicationDbContext())
                    {
                        Vendedor res = new Vendedor();
                        res.NombreVendedor = request.NombreVendedor;
                        res.UserName = request.UserName;
                        res.Password = request.Password;
                        res.Roles = request.Roles;
                        _context.Vendedor.Add(res);
                        _context.SaveChanges();

                    }

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Succedio un erro " + ex.Message);
            }

        }




    }
}
