using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Healthcare_domain;
namespace Healthcare_Interface
{
     public interface IProcedure
    {
      List<ProcedureMaster> GetProcedure();
    }
}
