using UnityEngine;

namespace WordForest
{
    public struct WFOForestData
    {
        // Fields
        public int level;
        public string forestName;
        public int initialCost;
        public int costIncrease;
        public int stages;
        public WordForest.WFOBackgroundType bgType;
        
        // Methods
        public WFOForestData(int _level, int _costIncrease, int _initialCost, string _name, int _stages = 20, WordForest.WFOBackgroundType _bgType = 0)
        {
            this.initialCost = _initialCost;
        }
        public int GetGrowthCost(int toStage)
        {
            if(new WordForest.WFOForestData() != 1)
            {
                    return (int)this.costIncrease;
            }
            
            if(toStage > 4)
            {
                    this.costIncrease = 10;
            }
            
            return 10;
        }
    
    }

}
