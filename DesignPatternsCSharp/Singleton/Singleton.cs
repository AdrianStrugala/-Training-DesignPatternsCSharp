using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static volatile Singleton _instance;
        public int Property;
        private static readonly object SyncRoot = new object();

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (_instance == null)
                            _instance = new Singleton();
                    }
                }

                return _instance;
            }
        }
    }
}