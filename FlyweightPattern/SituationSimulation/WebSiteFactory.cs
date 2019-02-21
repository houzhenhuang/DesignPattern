using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.SituationSimulation
{
    class WebSiteFactory
    {
        private Hashtable flyweights = new Hashtable();

        public WebSite GetWebSiteCategory(string key)
        {
            if (!flyweights.ContainsKey(key))
                flyweights.Add(key, new ConcreteWebSite(key));
            return (WebSite)flyweights[key];
        }
        public int GetWebSiteCount()
        {
            return flyweights.Count;
        }
    }
}
