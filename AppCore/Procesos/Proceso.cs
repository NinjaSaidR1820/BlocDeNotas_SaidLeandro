using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Procesos
{
    public interface Proceso<T>
    {
        void Añadir(T t, T g);
        string Leer(T t);
    }

}
