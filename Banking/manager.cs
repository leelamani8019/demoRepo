using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public interface manager
    {
        string create();
         string Read();
        string update();
        string delete();
    }
    public interface accountholder
    {
        string create();
        string Read();
        string update();
        string delete();
    }
}
