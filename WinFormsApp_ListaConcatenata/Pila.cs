using Newtonsoft.Json;
using System.Security.Cryptography;

namespace WinFormsApp_ListaConcatenata
{
    public class Pila
    {
        static string percorso = "../../../pila.json";
        Nodo inizio;
        Nodo fine;

        public Pila(string Elemento)
        {
            Nodo x = new(Elemento);
            inizio = x;
            fine = x;
        }

        public void Push(string Elemento)
        {
            Nodo x = new(Elemento);
            x.Precedente = fine;
            fine = x;
        }

        public void PopLifo()
        {
            if (fine != null)
            {
                fine = fine.Precedente;
            }
        }

        public void PopFifo()
        {
            if (inizio != null)
            {
                Nodo x = fine;
                if (x.Precedente != null)
                {
                    while (x.Precedente.Precedente != null)
                    {
                        x = x.Precedente;
                    }
                    x.Precedente = null;
                    inizio = x;
                }
                else
                {
                    fine = null;
                    inizio = null;
                }
            }
        }

        public virtual void Serializza()
        {
            File.WriteAllText(percorso, JsonConvert.SerializeObject(this));
        }

        public static Pila Deserializza()
        {
            Pila? x;
            x = JsonConvert.DeserializeObject<Pila>(File.ReadAllText(percorso));
            return x;
        }

        public Nodo Inizio { get => inizio; set => inizio = value; }
        public Nodo Fine { get => fine; set => fine = value; }
    }
}
