using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCA_Desktop
{
    public class GlobalVar
    {
        //Get Set Public Variables
        static string _usuario;

        //Get Set Public Variables Methods
        public static string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }


    }
}
