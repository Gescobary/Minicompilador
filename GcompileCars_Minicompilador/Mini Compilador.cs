using Mini_Compilador.Clases;
using Mini_Compilador.Clases.Analizador_Lexico;
using Mini_Compilador.Clases.Analizador_Sintactico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Mini_Compilador
{
    public partial class MiniCompilador : Form
    {
        public MiniCompilador()
        {
            InitializeComponent();

        }
        public static MiniCompilador _puerta = new MiniCompilador();
        AnalizadorSintactico asin = new AnalizadorSintactico();
        public string archivo, ruta_archivo;
        ClsUnirPalabras sent = new ClsUnirPalabras();

        ClsAnalizadorLexico al = new ClsAnalizadorLexico();
        string[] sentencias;
        public int errores = 0;

        ClsTablaDeSimbolos ts = new ClsTablaDeSimbolos();
        ClsErrores me = new ClsErrores();
        private void principal_Load(object sender, EventArgs e)
        {

        }



        public void Unir()
        {
            asin.puerta(this);
            sentencias = sent.uniendo_lineas();
        }

        public void Analizador_Sintactico()
        {
            asin.puerta(this);
            errores += asin.Aplicar_Analizador_Sintactico(sentencias);
        }

        public void Analizador_Lexico()
        {
            archivo = IngresarLenguaje.Text;
            al.puerta(this);
            errores += al.Aplicar_Analizador_Lexico(archivo);

        }

        public void Limpiar()
        {
            me.reinicialista();
            ts.limpiar();
            sentencias = null;
            errores = 0;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            Analizador_Lexico();
            Unir();
            Analizador_Sintactico();
            resultados();

            

        }


       

    private void IngresarLenguaje_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TablaDeSimbolos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void resultados()
        {
            TablaDeErrores.DataSource = me.llamatablaE();
            TablaDeSimbolos.DataSource = ts.versimbolos();
        }

       
    }
}
