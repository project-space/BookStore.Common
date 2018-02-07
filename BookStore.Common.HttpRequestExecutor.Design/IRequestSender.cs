using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Common.HttpRequestExecutor.Design
{
    public interface IRequestSender
    {
        Task<HttpResponseMessage> Send(HttpRequestMessage request);
    }
}
