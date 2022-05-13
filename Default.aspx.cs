using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SegundoExamenParcial
{
    public partial class _Default : Page
    {
        public static List<Participante> Participantes = new List<Participante>();

        public static List<Videojuego> Videojuegos = new List<Videojuego>();

        protected void Page_Load(object sender, EventArgs e)
        {
            LeerDatos();
        }


        public void LeerDatos()
        {
            try
            {
                string path = Server.MapPath("Datos.json");
                StreamReader reader = File.OpenText(path);
                string datos = reader.ReadToEnd();
                reader.Close();
                if (datos.Length > 0)
                    Participantes = JsonConvert.DeserializeObject<List<Participante>>(datos);
                else
                    Participantes = new List<Participante>();
            }
            catch (Exception e)
            {

            }
        }

        private void GuardarDatos()
        {
            string path = Server.MapPath("Datos.json");
            string content = JsonConvert.SerializeObject(Videojuegos);
            System.IO.File.WriteAllText(path, content);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Videojuego album = new Videojuego()
            {
                nombre = TextBox3.Text,
                genero = TextBox4.Text,

               Videojuegoo = Videojuegos.ToArray().ToList()
            };
            Participantes.Clear();
            Videojuegos.Add(album);
            GuardarDatos();
        
    }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Participante participant = new Participante()
            {
                nombre = TextBox1.Text,
                experiencia = Convert.ToInt32(TextBox2.Text)
            };
            Participantes.Add(participant);
            GridView1.DataSource = Videojuegos;
            GridView1.DataBind();
            GuardarDatos();
        }
    }



   

     
    
}