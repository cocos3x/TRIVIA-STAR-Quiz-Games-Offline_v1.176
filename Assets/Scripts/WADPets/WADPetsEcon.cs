using UnityEngine;

namespace WADPets
{
    public static class WADPetsEcon
    {
        // Fields
        public static int FeedCost;
        public static int FedDurationHours;
        public static int DefaultFoodQuantity;
        
        // Methods
        private static WADPetsEcon()
        {
            WADPets.WADPetsEcon.FeedCost = 1;
            WADPets.WADPetsEcon.FedDurationHours = 48;
            WADPets.WADPetsEcon.DefaultFoodQuantity = 3;
        }
    
    }

}
