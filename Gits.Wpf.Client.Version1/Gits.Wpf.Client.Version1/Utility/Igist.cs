using Gits.Wpf.Client.Version1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gits.Wpf.Client.Version1.Utility
{
    interface Igist
    {
        GistModel ListOneUserGists(string username);

        List<GistModel> ListAllPublicGists();

        List<GistModel> ListStarredGists();
    }
}
