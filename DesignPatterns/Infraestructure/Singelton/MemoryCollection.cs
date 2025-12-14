using System.Collections.Generic;

namespace DesignPatterns.Infraestructure.Singelton
{
    public class MemoryCollection
    {
        private static MemoryCollection _instance;

        public ICollection<Models.Vehicle> Vehicles { get; set; }

        public MemoryCollection() 
        { 
        
            Vehicles = new List<Models.Vehicle>();
        
        }

        public static MemoryCollection GetInstance() 
        { 
            if (_instance == null) 
            { 
                _instance = new MemoryCollection();
            
            }
            
            return _instance;
        }

    }






}