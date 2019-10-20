using System;
using System.Collections;
using System.Text;

namespace LogicalLayer
{
    class Singleton
    {
        private static  Singleton instance;

        private ArrayList dollars;
        private ArrayList colones;

        private Singleton()
        {
            this.dollars = new ArrayList();
            this.colones = new ArrayList();

            // datos quemados para pruebas;
            this.colones.Add(1000);
            this.colones.Add(2000);
            this.colones.Add(5000);

            this.dollars.Add(10);
            this.dollars.Add(20);
            this.dollars.Add(50);
        }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                return instance = new Singleton();
            }
            return instance;
        }
    }
}
