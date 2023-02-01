using ProyectoClase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProyectoClase.Repositories
{
    public class RepositoryLink
    {
        XmlSerializer serializer;
        public RepositoryLink()
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Lista";
            // xRoot.Namespace = "http://www.cpandl.com";
            xRoot.IsNullable = true;
            this.serializer = new XmlSerializer(typeof(List<Link>), xRoot);
        }

        public List<Link> GetDatos()
        {
            using (StreamReader reader = new StreamReader("prueba.xml"))
            {
                List<Link> listaLinks = (List<Link>)this.serializer.Deserialize(reader);
                return listaLinks;
            }
        }

        public async void SetDatos(List<Link> lista)
        {
            using (StreamWriter writer = new StreamWriter("prueba.xml"))
            {
                this.serializer.Serialize(writer, lista);
                await writer.FlushAsync();
                writer.Close();
            }
        }
    }
}
