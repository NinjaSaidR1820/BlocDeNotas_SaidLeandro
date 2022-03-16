#region Usos
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace AppCore.Procesos
{
    public interface BlockNotas : Proceso<String>
    {
        String Guardar(string text);
    }
}
