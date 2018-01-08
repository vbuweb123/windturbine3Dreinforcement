using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBR_Common.Writer
{
    public enum SaveDataType
    {
        Default,
        //Navigation is an object that has other properties to be saved
        Class,
        //List is a list or observable collection of primary values
        List,
        //list of objects with other properties to be saved
        ListOfClass
    }
}
