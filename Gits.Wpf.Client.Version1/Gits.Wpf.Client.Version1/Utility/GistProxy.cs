using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gits.Wpf.Client.Version1.Utility
{
    public class GistProxy:RestProxyBase
    {
        public override string SendGetRequest(string url)
        {
            return base.SendGetRequest(url);
        }

        public override string SendPostRequest(string url,Dictionary<string,object> postDic)
        {
            return base.SendPostRequest(url,postDic);
        }
    }
}
