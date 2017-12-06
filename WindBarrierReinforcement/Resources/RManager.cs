using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace WindBarrierReinforcement.Resources
{
    public static class RManager
    {
        public static ResourceManager Manager { get; set; }

        static RManager()
        {
            Manager = new ResourceManager(typeof(Resource));
        }
        public static string GetWord(string Key)
        {
            return Manager.GetString(Key);
        }
    }
}
