using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class stay
    {
        public int numstay { get; set; }
        //public int numsvar { get; set; }
        // public int numproz { get; set; }
        // public int numrels { get; set; }
        //  public int numPosInModel { get; set; }

        public stay(int ns)
        {
            numstay = ns;

            // numPosInModel = np;

        }

    }
    class svarka
    {
        public int numsvar { get; set; }
        public svarka(int nsv)
        {
            numsvar = nsv;
        }

    }

    class proiz
    {
        public int numprs { get; set; }
        public proiz(int prs)
        {
            numprs = prs;
        }


    }
    class relax
    {
        public int numrelax { get; set; }

        public relax(int rels)
        {
            numrelax = rels;
        }
    }
}
