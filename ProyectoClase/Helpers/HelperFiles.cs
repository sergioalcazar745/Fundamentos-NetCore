using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoClase.Helpers
{
    public class HelperFiles
    {
        public static async Task<string> ReadFileAsync(string path)
        {
            string contenido = "";
            FileInfo file = new FileInfo(path);
            using (TextReader reader = file.OpenText())
            {
                contenido = await reader.ReadToEndAsync();
                reader.Close();
            }
            return contenido;
        }

        public static async Task WriteFileAsync(string path, string data)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(data);
                await writer.FlushAsync();
                writer.Close();
            }
        }
    }
}
