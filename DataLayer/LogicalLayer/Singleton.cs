using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalLayer
{
    class Singleton
    {
        private static  Singleton instance;

        private List<Money> dollars;
        private List<Money> colones;

        private Singleton()
        {
            this.dollars = new List<Money>();
            this.colones = new List<Money>();
        }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                return new Singleton();
            }
            return instance;
        }
    }
}
