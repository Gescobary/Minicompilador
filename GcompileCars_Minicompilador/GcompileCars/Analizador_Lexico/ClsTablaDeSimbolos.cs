using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Compilador.Clases.Analizador_Lexico
{
    public class ClsTablaDeSimbolos
    {
        public static List<MdSimbolos> reglas = new List<MdSimbolos>();
        public static List<MdSimbolos> Tabla_simbolos = new List<MdSimbolos>();

        public List<MdSimbolos> TSimbolos2
        {
            get { return reglas; }
            set { reglas = value; }
        }

        public List<MdSimbolos> versimbolos()
        {
            return Tabla_simbolos;
        }
        public void limpiar()
        {
            Tabla_simbolos = new List<MdSimbolos>();
        }

        
        public void establecer_reglas()
        {
            MdSimbolos ts = new MdSimbolos("marca", 0, 0, "Palabra reservada", "Se describe la marca del vehículo");
            reglas.Add(ts);
            ts = new MdSimbolos("modelo", 0, 0, "Palabra reservarda", "Se describe la fecha de fabricación del vehículo");
            reglas.Add(ts);
            ts = new MdSimbolos("traccion", 0, 0, "Palabra reservada", "Se indica si es tracción 4WD, 4X4,FWD,RWD");
            reglas.Add(ts);
            ts = new MdSimbolos("motor", 0, 0, "Palabra reservada", "Se asigna los centimetro cubicos del motor");
            reglas.Add(ts);
            ts = new MdSimbolos("color", 0, 0, "Palabra reservarda", "El tipo de color del vehículo y que tiene registrado");
            reglas.Add(ts);
            ts = new MdSimbolos("combustible", 0, 0, "Palabra reservada", "Tipo");
            reglas.Add(ts);
            ts = new MdSimbolos("precio", 0, 0, "Palabra reservada", "Con esta palabra se determina el precio del vehículo");
            reglas.Add(ts);
            ts = new MdSimbolos("nuevo", 0, 0, "Palabra reservarda", "Con esta palabra se registra un vehículo de nuevo ingreso");
            reglas.Add(ts);
            ts = new MdSimbolos("#", 0, 0, "Cadena", "inicio o fin de cadena");
            reglas.Add(ts);
            ts = new MdSimbolos("-", 0, 0, "Operador de asignacion", "se usa para asignar un valor");
            reglas.Add(ts);
        }
        public bool verificar(string palabra, int num_linea, int id)
        {
            establecer_reglas();
            bool r = false;
            foreach(var pal in reglas)
            {
                if(pal.valor == palabra)
                {
                    MdSimbolos tab = new MdSimbolos(pal.valor, num_linea, id, pal.tipo, pal.descripcion);
                    Tabla_simbolos.Add(tab);
                    r = true;
                    break;
                }
                else
                {
                    r = false;
                }
            }
            reglas.Clear();
            return r;
        }
        public void añadir_objeto(MdSimbolos Ts)
        {
            Tabla_simbolos.Add(Ts);
        }
    }
}