namespace WinFormsApp_ListaConcatenata
{
    public partial class Form1 : Form
    {
        Pila pila;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            string valore = textBoxValore.Text;
            if (pila == null)
            {
                pila = new(valore);
            }
            else
            {
                pila.Push(valore);
            }
            textBoxValore.Text = "";
            textBoxValore.Focus();
            VisualizzaLista();
        }

        private void buttonPopLifo_Click(object sender, EventArgs e)
        {
            if (pila != null)
            {
                pila.PopLifo();
            }
            VisualizzaLista();
        }

        private void VisualizzaLista()
        {
            listBoxPila.Items.Clear();
            Nodo x = pila.Fine;
            while (x != null)
            {
                listBoxPila.Items.Add(x.Valore);
                x = x.Precedente;
            }
        }

        private void buttonSerializza_Click(object sender, EventArgs e)
        {
            if (pila != null)
            {
                pila.Serializza();
                MessageBox.Show("Lista serializzata correttamente", "Serializzazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Non è stata creata nessuna lista", "Serializzazione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeserializza_Click(object sender, EventArgs e)
        {
            if (pila != null)
            {
                DialogResult scelta = MessageBox.Show("Vuoi veramente sovrascivere il contenuto della lista?",
                                                   "Deserializzazione",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
                if (scelta == DialogResult.Yes)
                {
                    pila = Pila.Deserializza();
                    VisualizzaLista();
                }
            }
            else
            {
                pila = Pila.Deserializza();
                MessageBox.Show("Lista deserializzata correttamente", "Deserializzazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VisualizzaLista();
            }
        }

        private void buttonPopFifo_Click(object sender, EventArgs e)
        {
            if (pila != null)
            {
                pila.PopFifo();
            }
            VisualizzaLista();
        }
    }
}