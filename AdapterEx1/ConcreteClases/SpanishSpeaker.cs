using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEx1.ConcreteClases
{
    public class SpanishSpeaker
    {
        public string Pregunta(string pregunta)
        {
            return "Pregunta en español: " + pregunta;
        }

        public string Respuesta(string respuesta)
        {
            return "Respuesta en español: " + respuesta;
        }
    }
}