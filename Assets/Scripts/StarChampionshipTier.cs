using UnityEngine;
public class StarChampionshipTier
{
    // Fields
    public int tierIndex;
    public int goal;
    public int reward;
    public bool isTopTier;
    
    // Methods
    public StarChampionshipTier()
    {
    
    }
    public StarChampionshipTier(int tierIndex, int goal, int reward, bool isTopTier = False)
    {
        this.tierIndex = tierIndex;
        this.goal = goal;
        this.reward = reward;
        this.isTopTier = isTopTier;
    }

}
