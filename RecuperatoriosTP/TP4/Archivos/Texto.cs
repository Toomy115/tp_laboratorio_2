using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        string path;
        public Texto(string archivo)
        {
            this.path = archivo;
        }

        public bool guardar(string datos)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(this.path, true);
                streamWriter.WriteLine(datos);
                streamWriter.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool leer(out List<string> datos)
        {
            datos = new List<string>();
            try
            {
                
                StreamReader streamReader = new StreamReader(this.path);
                while(streamReader.EndOfStream == false)
                {
                    datos.Add(streamReader.ReadLine());
                }
                streamReader.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
