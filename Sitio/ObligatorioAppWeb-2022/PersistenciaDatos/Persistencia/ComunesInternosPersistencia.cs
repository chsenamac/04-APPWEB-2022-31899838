using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entidades;

namespace Persistencia
{
    internal class ComunesInternosPersistencia
    {
        private string strConexion = "Data Source=.; Initial Catalog=ObligatorioAppWeb2022; integrated Security=true";

        public string StringConexion
        {
            get { return strConexion; }
        }

    }
}
