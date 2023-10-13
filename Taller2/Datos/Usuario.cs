using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Modelo;

namespace Taller2.Datos
{
    public class Usuario
    {
        List<Modelo.Usuariomodelo>listausuario=new List<Modelo.Usuariomodelo>();
        public void guardar(Modelo.Usuariomodelo modelo)
        {
            listausuario.Add(modelo);
        }
        public List<Usuariomodelo> consultar ()
        {
            return listausuario;
        }
    }
}
