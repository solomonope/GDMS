using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDataLib.BO
{
    public class Readings
    {
        public Guid ReadingsId
        {
            get;
            set;
        }
        public DateTime Date
        {
            get;
            set;
        }

        public String Field
        {

            get;
            set;
        }

        public Double OilProduced
        {
            get;
            set;
        }

        public Double GasLift
        {

            get;
            set;
        }

        public Double NAGProduced
        {

            get;
            set;
        }

        public Double CONGProduced
        {

            get;
            set;
        }

        public Double BSWProduced
        {
            get;
            set;
        }

        public double AGProduced
        {
            get;
            set;
        }
    }

}
