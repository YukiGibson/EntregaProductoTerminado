using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaProductoTerminado.Email
{
    interface IEmail<IEntity> where IEntity : class
    {
        void SendEmail(IEntity entity);
        StringBuilder BuildMessage(IEntity entity);

    }
}
