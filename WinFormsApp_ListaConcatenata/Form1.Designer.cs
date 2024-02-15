namespace WinFormsApp_ListaConcatenata
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxValore = new TextBox();
            buttonPush = new Button();
            listBoxPila = new ListBox();
            buttonPopLifo = new Button();
            buttonSerializza = new Button();
            buttonDeserializza = new Button();
            buttonPopFifo = new Button();
            SuspendLayout();
            // 
            // textBoxValore
            // 
            textBoxValore.Location = new Point(12, 12);
            textBoxValore.Name = "textBoxValore";
            textBoxValore.PlaceholderText = "Valore del nuovo nodo";
            textBoxValore.Size = new Size(134, 23);
            textBoxValore.TabIndex = 0;
            // 
            // buttonPush
            // 
            buttonPush.Location = new Point(12, 41);
            buttonPush.Name = "buttonPush";
            buttonPush.Size = new Size(134, 23);
            buttonPush.TabIndex = 1;
            buttonPush.Text = "Push";
            buttonPush.UseVisualStyleBackColor = true;
            buttonPush.Click += buttonPush_Click;
            // 
            // listBoxPila
            // 
            listBoxPila.FormattingEnabled = true;
            listBoxPila.ItemHeight = 15;
            listBoxPila.Location = new Point(152, 12);
            listBoxPila.Name = "listBoxPila";
            listBoxPila.Size = new Size(183, 199);
            listBoxPila.TabIndex = 2;
            // 
            // buttonPopLifo
            // 
            buttonPopLifo.Location = new Point(12, 70);
            buttonPopLifo.Name = "buttonPopLifo";
            buttonPopLifo.Size = new Size(134, 23);
            buttonPopLifo.TabIndex = 3;
            buttonPopLifo.Text = "Pop LIFO";
            buttonPopLifo.UseVisualStyleBackColor = true;
            buttonPopLifo.Click += buttonPopLifo_Click;
            // 
            // buttonSerializza
            // 
            buttonSerializza.Location = new Point(12, 159);
            buttonSerializza.Name = "buttonSerializza";
            buttonSerializza.Size = new Size(134, 23);
            buttonSerializza.TabIndex = 4;
            buttonSerializza.Text = "Salva";
            buttonSerializza.UseVisualStyleBackColor = true;
            buttonSerializza.Click += buttonSerializza_Click;
            // 
            // buttonDeserializza
            // 
            buttonDeserializza.Location = new Point(12, 188);
            buttonDeserializza.Name = "buttonDeserializza";
            buttonDeserializza.Size = new Size(134, 23);
            buttonDeserializza.TabIndex = 5;
            buttonDeserializza.Text = "Carica";
            buttonDeserializza.UseVisualStyleBackColor = true;
            buttonDeserializza.Click += buttonDeserializza_Click;
            // 
            // buttonPopFifo
            // 
            buttonPopFifo.Location = new Point(12, 99);
            buttonPopFifo.Name = "buttonPopFifo";
            buttonPopFifo.Size = new Size(134, 23);
            buttonPopFifo.TabIndex = 6;
            buttonPopFifo.Text = "Pop FIFO";
            buttonPopFifo.UseVisualStyleBackColor = true;
            buttonPopFifo.Click += buttonPopFifo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 225);
            Controls.Add(buttonPopFifo);
            Controls.Add(buttonDeserializza);
            Controls.Add(buttonSerializza);
            Controls.Add(buttonPopLifo);
            Controls.Add(listBoxPila);
            Controls.Add(buttonPush);
            Controls.Add(textBoxValore);
            Name = "Form1";
            Text = "Form Pila";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxValore;
        private Button buttonPush;
        private ListBox listBoxPila;
        private Button buttonPopLifo;
        private Button buttonSerializza;
        private Button buttonDeserializza;
        private Button buttonPopFifo;
    }
}