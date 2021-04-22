using CData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CNegocio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service.svc o Service.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service : IService
    {
        private PruebaEntities1 srv = new PruebaEntities1();

        public void create(Usuario usuario)
        {
            srv.Usuario.Add(usuario);
            srv.SaveChanges();            
        }

        public void delete(int id)
        {
            var old = srv.Usuario.Single(p => p.Id == id);
            srv.Usuario.Remove(old);            
            srv.SaveChanges();
        }

        public Usuario find(int id)
        {
            return srv.Usuario.Single(p => p.Id == id);
        }

        public List<Usuario> findAll()
        {
            return srv.Usuario.ToList();
        }

        public void update(int id,Usuario usuario)
        {
            var old = srv.Usuario.Single(p => p.Id == id);
            old.Nombre = usuario.Nombre;
            old.Sexo = usuario.Sexo;
            old.FechaNacimiento = usuario.FechaNacimiento;
            srv.SaveChanges();
        }
    }
}
