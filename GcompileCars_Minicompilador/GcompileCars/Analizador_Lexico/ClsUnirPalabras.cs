using Mini_Compilador.Clases.Analizador_Lexico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mini_Compilador.Clases.Analizador_Sintactico
{
   public class ClsUnirPalabras
    {
        int total_lineas = 0;
        List<MdSimbolos> tabla;
        public string[] uniendo_lineas()
        {
            total_lineas = ClsAnalizadorLexico.numero_de_lineas;
            tabla = ClsTablaDeSimbolos.Tabla_simbolos;
            string sentencia = null;
            string[] sentencias = new string[total_lineas];
            int n = 0;
            string tipov = "";

            for (int i = 0; i < total_lineas; i++)
            {
                foreach (var token in tabla)
                {
                    if (token.NumLinea == i+1 && token != null)
                    {
                        if (n == 0 && Regex.IsMatch(token.valor, @"(marca|modelo|color|motor|traccion|combustible|precio)$"))  //Palabras reservadas
                        {
                            token.tipo = token.valor;
                            tipov = token.valor;
                        }


                        if (n != 0)
                        {
                            sentencia = sentencia + " " + token.valor.ToString();
                            token.tipo = tipov;
                        }
                        else
                        {
                            sentencia += token.valor.ToString();
                            n = 1;
                        }

                    }
                }
                sentencias[i] = sentencia;
                sentencia = null;
                n = 0;
                tipov = "";
            }

            return sentencias;
        }

    }
}
