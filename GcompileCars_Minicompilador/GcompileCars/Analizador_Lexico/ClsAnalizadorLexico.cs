using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Mini_Compilador.Clases.Analizador_Lexico
{
    public class ClsAnalizadorLexico
    {
        
        ClsTablaDeSimbolos reg = new ClsTablaDeSimbolos();       
        private MiniCompilador frm;
        ClsErrores te = new ClsErrores();
        public static int numero_de_lineas = 0;
        Regex identificadores = new Regex(@"^[a-zA-Z]+([0-9]{4})$"); 
        public void puerta(MiniCompilador form)
        {
            this.frm = form;
        }
        
        //Constructor para las funciones del analizador lexico
        public int Aplicar_Analizador_Lexico(string archivo)
        {
            int i = 0;
            int c = 0;
            int errores = 0;

            //Inicia el manejador de errores.
            try
            {
                string[] Palabras_Separadas;
                string[] lineas = archivo.Split('\n');
                
                frm.IngresarLenguaje.Select(0, frm.IngresarLenguaje.SelectionStart);
                for(i = 0; i < lineas.Length; i++)
                {
                    numero_de_lineas = i + 1;
                    Palabras_Separadas = Regex.Split(lineas[i], @"\s+");
                    foreach (var palabra in Palabras_Separadas)
                    {
                        
                        
                        if (reg.verificar(palabra.ToString(), numero_de_lineas, c ))
                        {                            
                        }
                        
                        else if (Regex.IsMatch(palabra, @"^(#[^#]*)|([^#]*#)$"))//Simbolo numeral
                        {
                            MdSimbolos nuevo = new MdSimbolos(palabra, numero_de_lineas, c, "Cadena de texto", "No coincide con la tabla prederteminada, se considera una cadena de texto");
                            reg.añadir_objeto(nuevo);
                        }

                        else 
                        {
                            if (identificadores.IsMatch(palabra)) //identificará las palabras que ya se encuentran guardadas.
                            {
                                MdSimbolos nuevo = new MdSimbolos(palabra, numero_de_lineas, c, "Identificador", "Palabra inventada por el usuario que es parte del contexto que esta tratando");
                                reg.añadir_objeto(nuevo);
                            }
                            else  //si no existe indica, o bien si esta mal escrita.
                            {
                                MdSimbolos nuevo = new MdSimbolos(palabra, numero_de_lineas, c, "Desconocido", "El texto ingresado no es valido");
                                reg.añadir_objeto(nuevo);
                                MdErrores md_E = new MdErrores(c, numero_de_lineas, "Palabra no identificada", "Estar conciente que la palabra empleada sea parte del lenguaje", "Para que la palabra sea aceptada tiene que ir escrita asi, por ejemplo: Marca+modelo eje.Toyota2022");
                                te.nuevoerror(md_E);
                                errores++;
                            }
                        }
                        c++;
                    }
                }
                Palabras_Separadas = null;
                return errores;
            }
            //Finaliza el try para manejar errores 
            //Dando lugar al catch para identificarlo y mostar que tipo de error corresponde.
            catch (Exception ex)
            {
                MessageBox.Show("El analizador lexico tiene un error" + ex.Message);
                return errores;
            }
        }//Finaliza el método aplicar analizador léxico.
    }//Fin clase AnalizadorLexico.
}