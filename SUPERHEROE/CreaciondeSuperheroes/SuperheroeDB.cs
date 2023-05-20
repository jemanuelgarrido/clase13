using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaciondeSuperheroes
{
    internal class SuperheroeDB
    {
        public readonly string cadenaConexion = "Data Source=c:\\tmp\\SuperheroeDB.db";
        private readonly SQLiteConnection conexion;

        public SuperheroeDB()
        {
            conexion = new SQLiteConnection(cadenaConexion);
        }

        public void CrearTablaHeroe(ISuperheroe heroe)
        {
            try
            {
                conexion.Open();
                string sql = "INSERT INTO SuperHeroe (nombre, fuerza, agilidad) VALUES ('" + heroe.nombre + "', " + heroe.fuerza + ", " + heroe.agilidad + ")";
                SQLiteCommand command = new SQLiteCommand(sql, conexion);
                command.ExecuteNonQuery();
                Console.WriteLine("SuperHeroe insertado correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el SuperHeroe: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
