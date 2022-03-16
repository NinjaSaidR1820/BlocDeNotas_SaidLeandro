using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstructura.Metodos
{
    internal class Streams : BlockDeNotas
    {
        private BinaryWriter binaryWriter;

        public Streams()
        {

        }
        public void Añadir(string texto, string ruta)
        {
            try
            {
                using (FileStream fileStream = new FileStream(ruta, FileMode.Append, FileAccess.Write))
                {
                    binaryWriter = new BinaryWriter(fileStream);
                    binaryWriter.Write(texto);
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

        public string Guardar(string text)
        {
            throw new NotImplementedException();
        }
        public string Leer(string t)
        {
            string text = string.Empty;

            try
            {
                text = File.ReadAllText(t);

                return text;
            }
            catch (IOException)
            {

                throw;
            }
        }
    }
}