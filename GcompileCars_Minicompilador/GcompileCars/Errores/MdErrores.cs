using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Compilador.Clases
{
    class MdErrores
    {
        
        public int ID;
        public int num_linea;
        public string error;
        public string descrip;
        public string sol_error;


        public MdErrores(int id, int nl, string e, string se, string d)
        {
            this.Id = id;
            num_linea = nl;
            error = e;
            sol_error = se;
            descrip = d;

        }
        public MdErrores(int id, string e, string se, string d)
        {

            ID = id;
            error = e;
            sol_error = se;
            descrip = d;

        }
        public MdErrores()
        {

        }

        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public int Numero_de_Linea
        {
            get { return num_linea; }
            set { num_linea = value; }
        }

        public string Error
        {
            get { return error; }
            set { error = value; }
        }

        public string Solucion
        {
            get { return sol_error; }
            set { sol_error = value; }
        }
        public string Descripcion
        {
            get { return descrip; }
            set { descrip = value; }
        }
    }
}
