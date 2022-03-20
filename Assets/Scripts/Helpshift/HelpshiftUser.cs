using UnityEngine;

namespace Helpshift
{
    public class HelpshiftUser
    {
        // Fields
        public readonly string identifier;
        public readonly string email;
        public readonly string name;
        public readonly string authToken;
        
        // Methods
        private HelpshiftUser(string identifier, string email, string name, string authToken)
        {
            val_1 = new System.Object();
            this.identifier = identifier;
            this.email = val_1;
            this.name = name;
            this.authToken = authToken;
        }
    
    }

}
