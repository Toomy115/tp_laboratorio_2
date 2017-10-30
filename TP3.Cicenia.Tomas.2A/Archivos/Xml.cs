using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Excepciones;


namespace Archivos
{
    public class Xml <T> : IArchivo<T>
    {
        public bool guardar(string archivo, T datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                TextWriter writer = new StreamWriter(archivo, false);
                serializer.Serialize(writer, datos);
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }


            
        }

        public bool leer(string archivo, out T datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                TextReader reader = new StreamReader(archivo);
                datos = (T)serializer.Deserialize(reader);
                return true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
    }
}
