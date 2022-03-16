using AppCore.Procesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Servicios
{
    public class Blocks : BaseS<String> , BlockNotas
    {
        BlockDeNotas textoModel;
        public TextoService(BlockDeNotas model) : base(model)
        {
            this.textoModel = model;
        }

        public string Guardar(string text)
        {
            throw new NotImplementedException();
        }
    }
}
