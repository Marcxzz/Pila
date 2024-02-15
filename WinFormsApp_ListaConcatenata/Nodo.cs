namespace WinFormsApp_ListaConcatenata
{
    public class Nodo
    {
        string valore;
        Nodo precedente;

        public Nodo(string Valore)
        {
            valore = Valore;
        }

        public string Valore { get => valore; set => valore = value; }
        public Nodo Precedente { get => precedente; set => precedente = value; }
    }
}
