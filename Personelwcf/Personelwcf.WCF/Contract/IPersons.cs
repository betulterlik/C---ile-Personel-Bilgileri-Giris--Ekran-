using Personelwcf.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Personelwcf.WCF
{
    [ServiceContract]
    public  interface IPersons
    {[OperationContract]
        List<Persons> Listele();
    }
}
