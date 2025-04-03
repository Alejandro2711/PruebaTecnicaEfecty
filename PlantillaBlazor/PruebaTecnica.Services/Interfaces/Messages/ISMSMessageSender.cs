using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Services.Interfaces.Messages
{
    public interface ISMSMessageSender
    {
        public Task<bool> SendSMSMessage(string phoneNumber, string message, string concepto, string identificacionProceso, string tipoProceso);
    }
}
