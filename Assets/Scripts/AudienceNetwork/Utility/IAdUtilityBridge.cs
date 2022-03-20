using UnityEngine;

namespace AudienceNetwork.Utility
{
    internal interface IAdUtilityBridge
    {
        // Methods
        public abstract double DeviceWidth(); // 0
        public abstract double DeviceHeight(); // 0
        public abstract double Width(); // 0
        public abstract double Height(); // 0
        public abstract double Convert(double deviceSize); // 0
        public abstract void Prepare(); // 0
    
    }

}
