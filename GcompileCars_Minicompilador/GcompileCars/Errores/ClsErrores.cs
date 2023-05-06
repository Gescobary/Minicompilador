using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Compilador.Clases
{
    class ClsErrores
    {
        
        public static List<MdErrores> TErrores2 = new List<MdErrores>();

        public void reinicialista() 
        { 
            TErrores2 = new List<MdErrores>();
        }
        public List<MdErrores> llamatablaE()
        {
            return TErrores2;
        }
        public void nuevoerror(MdErrores error)
        {
            TErrores2.Add(error);  
        }
    }
}

