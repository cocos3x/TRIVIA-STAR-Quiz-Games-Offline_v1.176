using UnityEngine;
public class RESSpin.Result
{
    // Fields
    public int reelsPacked;
    public int weight;
    public RestaurantRivals.RESPayout payout;
    public bool anticipateReel3;
    public double probability;
    
    // Methods
    public RESSpin.Result(int reel1, int reel2, int reel3, int _weight, RestaurantRivals.RESPayout _payout, bool _anticipate = False)
    {
        null = null;
        int val_1 = RestaurantRivals.RESSpin.SHIFTREEL2;
        int val_2 = RestaurantRivals.RESSpin.SHIFTREEL3;
        val_1 = val_1 & 31;
        this.anticipateReel3 = _anticipate;
        val_2 = val_2 & 31;
        val_1 = reel1 | (reel2 << val_1);
        val_2 = val_1 | (reel3 << val_2);
        this.reelsPacked = val_2;
        this.weight = _weight;
        this.payout = _payout;
    }

}
