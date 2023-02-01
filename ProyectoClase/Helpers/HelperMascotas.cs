using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoClase.Models;

namespace ProyectoClase.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
        }

        private void CreateMascotas(string data)
        {
            this.Mascotas.Clear();
            string[] datosmascotas = data.Split(',');
            foreach(string m in datosmascotas)
            {
                string[] propiedades = m.Split('#');
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        private string GetMascotasString()
        {
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                string temp = mascota.Nombre + "#" + mascota.Raza;
                data += temp + ",";
            }
            data = data.Trim(',');
            return data;
        }

        public static async Task<byte[]> ConvertFileToByte(string fileName)
        {
            return await File.ReadAllBytesAsync(fileName);
        }

        public static MemoryStream ConvertBytesToStream(byte[] bytes)
        {
            return new MemoryStream(bytes);
        }

        public async Task ReadFileMascotasAsync(string path)
        {
            string data = await HelperFiles.ReadFileAsync(path);
            this.CreateMascotas(data);
        }

        public async Task SaveFileMascotasAsync(string path)
        {
            string data = this.GetMascotasString();
            await HelperFiles.WriteFileAsync(path, data);
        }
    }
}
