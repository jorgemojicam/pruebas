using CData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CNegocio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]        
        List<Usuario> findAll();

        [OperationContract]
        Usuario find(int id);

        [OperationContract]
        void create(Usuario usuario);

        [OperationContract]
        void update(int id,Usuario usuario);

        [OperationContract]
        void delete(int id);


    }
}
