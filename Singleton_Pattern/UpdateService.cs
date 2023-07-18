using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
     sealed class UpdateService
    {
        private UpdateService() { } // Private constructor to prevent direct instantiation
        public int Id { get; private set; } // Property to store the ID of the update service
        private static UpdateService _Instance;  //  Property to store the ID of the update service
        public static readonly object _InstanceLock = new object();  // Lock object for thread safety
        public static UpdateService Instance(int id)
        {
            if(_Instance == null) // Acquire lock to ensure thread safety
            {
                lock(_InstanceLock) //Double-checked locking
                {
                    if(_Instance == null)
                    {
                        _Instance = new UpdateService();
                        _Instance.Id = id;
                    }
                }
                
            }
            return _Instance;
        }


    }
}
