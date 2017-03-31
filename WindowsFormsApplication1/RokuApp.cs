using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winRokuRemote
{
    class RokuApp
    {
        private String appName;
        private int appId;

        public RokuApp(string name, int id)
        {
            appName = name;
            appId = id;
        }

        public override string ToString()
        {
            return appName;
        }

        public int getId()
        {
            return appId;
        }
    }
}
