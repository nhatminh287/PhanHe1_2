using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Object
{
    // danh sách các đối tượng (table, index, view, proc, ... trong database)
    public class ObjectDB
    {
        public ObjectDB(string objectName, string objectType)
        {
            ObjectName = objectName;
            ObjectType = objectType;
        }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }

        public override string ToString()
        {
            return "(" + ObjectType + ") " + ObjectName;
        }
    }
}
