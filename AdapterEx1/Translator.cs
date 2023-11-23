using AdapterEx1.ConcreteClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterEx1
{
    //el traductor sabe perfecto ingles (por lo que implementa ICommunication)
    public class Translator : ICommunication
    {
        //como tambien sabe español, inyecta un spanish speaker por dependencias
        private readonly SpanishSpeaker _spanishSpeaker;
        public Translator(SpanishSpeaker spanishSpeaker)
        {
            _spanishSpeaker = spanishSpeaker;
        }

        //ahora adaptamos
        public string Ask(string question)
        {
            return _spanishSpeaker.Pregunta(question);
        }

        public string Reply(string answer)
        {
            return _spanishSpeaker.Respuesta(answer);
        }
    }
}
