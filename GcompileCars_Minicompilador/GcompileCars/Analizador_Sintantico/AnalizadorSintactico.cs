using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mini_Compilador.Clases.Analizador_Sintactico
{
    public class AnalizadorSintactico
    {
        private MiniCompilador frm;
        ClsErrores me = new ClsErrores();
        public int Aplicar_Analizador_Sintactico(string[] sentencias)
        {
            int c = 0;
            int errores = 0;
            for (int i = 0; i < sentencias.Length; i++)
            {
                c += sentencias.Length;
                if (sentencias[i] != null)
                {
                    if (Regex.IsMatch(sentencias[i], @"^nuevo")) 
                    {
                        if (Regex.IsMatch(sentencias[i], @"^(nuevo)\s[a-zA-Z]+([0-9]{0,4})$"))
                        {
                            frm.IngresarLenguaje.SelectionStart = frm.IngresarLenguaje.Find(sentencias[i]);
                            frm.IngresarLenguaje.SelectionColor = Color.Green; //cuando es correcto
                        }
                        else
                        {
                            frm.IngresarLenguaje.SelectionStart = frm.IngresarLenguaje.Find(sentencias[i]);
                            frm.IngresarLenguaje.SelectionColor = Color.Red; //asignación de color cuando lo ingresado es incorrecto, ya se por qu eno se estan cumpliendo las reglas definidas. 
                            MdErrores md = new MdErrores(c, i + 1, "Error Tipo Sintactico", "Revisen que la sintaxis este correcta", "La palabra tiene que ir escrita como 'nuevo' para que funcione");
                            me.nuevoerror(md);
                            errores++;
                        }
                    }
                   
                    else if (Regex.IsMatch(sentencias[i], @"^(marca|modelo|color|motor|traccion|combustible|precio)"))
                    {
                        if (Regex.IsMatch(sentencias[i], @"^(marca|modelo|color|motor|traccion|combustible|precio)\s[a-zA-Z]+([0-9]{0,4})\s(-)\s(#.*#)$"))
                        {
                            frm.IngresarLenguaje.SelectionStart = frm.IngresarLenguaje.Find(sentencias[i]);
                            frm.IngresarLenguaje.SelectionColor = Color.Green;
                        }
                        else
                        {
                            frm.IngresarLenguaje.SelectionStart = frm.IngresarLenguaje.Find(sentencias[i]);
                            frm.IngresarLenguaje.SelectionColor = Color.Red;
                            MdErrores md = new MdErrores(c, i + 1, "Error Tipo Sintactico", "Vea si la sintaxis esta bien escrita", "El error surge cuando la sintaxis no fue escrita de manera correcta");
                            me.nuevoerror(md);
                            errores++;
                        }
                    }
                    
                    else 
                    {
                        frm.IngresarLenguaje.SelectionStart = frm.IngresarLenguaje.Find(sentencias[i]);
                        frm.IngresarLenguaje.SelectionColor = Color.Red;
                        MdErrores md = new MdErrores(c, i + 1, "Palabra No Reconocida Por El Lenguaje", "Verifique la tabla de errores", "El error surge cuando la sintaxis no fue escrita de manera correcta");
                        me.nuevoerror(md);
                        errores++;
                    }
                }
            }
            return errores;
        }
        public void puerta(MiniCompilador form)
        {
            this.frm = form;
        }
    }
}
