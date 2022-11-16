using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.DAL
{
    public class DataContextFactory
    {
        public static sistemaDataContext dataContext;
        sistemaDataContext Datacontext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new sistemaDataContext();
                return dataContext;
            }
        }
    }
}
