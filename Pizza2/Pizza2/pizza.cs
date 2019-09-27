using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza2
{
    public class pizza
    {
        public Refresco refresco { get; set; }
        public string Tamaño { get; set; }
        public string Tipo { get; set; }
        public int Porciones { get; set; }

        public pizza()
        {
            
            this.queso = new queso();
            this.oregano = new oregano();
        }
        public queso queso { get; set; }
        public oregano oregano { get; set; }
    }

    
    public class queso
    {

    }
    public class oregano
    {

    }
    public class Refresco
    {
        public string nombre { get; set; }
        public int litros { get; set; }
    }
}
