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
        public static List<Participante> ParticipanteList = new List<Participante>();

        public static List<Videojuego> VideojuegoList = new List<Videojuego>();

        protected void Page_Load(object sender, EventArgs e)
        {
          

        }

        public void LeerDatos()
        {
            List<Participante> participantes = new List<Participante>();

            string archivo = Server.MapPath("Datos.json");

            StreamReader jsonStream = File.OpenText(archivo);

            string json = jsonStream.ReadToEnd();

            jsonStream.Close();

            participantes = JsonConvert.DeserializeObject<List<Participante>(json);
        }

        public void GuardarDatos()
        {
             
            string json = JsonConvert.SerializeObject(Participante);

        //El nombre del archivo
        string archivo = Server.MapPath("Datos.json");

   
        System.IO.File.WriteAllText(archivo, json);       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}