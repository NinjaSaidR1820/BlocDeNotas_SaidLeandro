using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public interface Modelo<T>
    {
        void Añadir(T t, T g);
        string Leer(T t);
    }
}
