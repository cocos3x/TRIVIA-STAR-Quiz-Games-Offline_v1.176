using UnityEngine;

namespace SG
{
    public class InitOnStart : MonoBehaviour
    {
        // Fields
        public int totalCount;
        
        // Methods
        private void Start()
        {
            object val_1 = this.GetComponent<System.Object>();
            if(this != 0)
            {
                    mem[1152921514382208736] = this.totalCount;
            }
            else
            {
                    mem[16] = this.totalCount;
            }
            
            this.RefillCells(offset:  0);
        }
        public InitOnStart()
        {
            this.totalCount = 0;
        }
    
    }

}
