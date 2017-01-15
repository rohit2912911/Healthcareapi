using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Healthcare_domain;
using Healthcare_Interface;
using Healthcare_sql;

namespace Healthcare_Repository
{
public class ProcedureRepository:IProcedure
    {
        Medripple_echEntities dbentity = new Medripple_echEntities();
        public List<Healthcare_domain.ProcedureMaster> GetProcedure()
        {
            
           
            
            return a.ToList() ;
        }

    }
}
