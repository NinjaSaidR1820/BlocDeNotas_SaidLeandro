using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Procesos;

namespace AppCore.Servicios
{
    public abstract class BaseS<T> : BlockNotas
    {
        private Modelo<T> Model;
        protected BaseS(Modelo<T> model)
        {
            this.Model = model;
        }

        public void Añadir(T t, T g)
        {
            Modelo.Add(t, g);
        }

        public string Leer(T t)
        {
            return Modelo.Leer(t);
        }
    }
}
