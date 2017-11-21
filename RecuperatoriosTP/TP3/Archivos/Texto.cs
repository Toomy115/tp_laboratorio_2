using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool guardar (string archivo, string datos)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(archivo, true);
                streamWriter.WriteLine(datos);
                streamWriter.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        public bool leer (string archivo, out string datos)
        {
            try
            {
                StreamReader streamReader = new StreamReader(archivo);
                datos = streamReader.ReadToEnd();
                streamReader.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
    }
}
