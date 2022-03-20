using UnityEngine;
public class RESEventRewardData
{
    // Fields
    public RESEventRewardType rewardType;
    public int pointsReq;
    public decimal rewardQty;
    public System.Collections.Generic.Dictionary<string, object> metaData;
    
    // Methods
    public RESEventRewardData()
    {
    
    }
    public RESEventRewardData(RESEventRewardType rewType, decimal rewQty, int ptsReq, System.Collections.Generic.Dictionary<string, object> mData)
    {
        this.rewardType = rewType;
        this.pointsReq = ptsReq;
        this.rewardQty = rewQty;
        mem[1152921512534167620] = rewQty.hi;
        mem[1152921512534167624] = rewQty.lo;
        mem[1152921512534167628] = rewQty.mid;
        this.metaData = mData;
    }
    public RESEventRewardData(RESEventRewardData rData)
    {
        if(rData != 0)
        {
                this.rewardType = rData.rewardType;
        }
        else
        {
                this.rewardType = 0;
        }
        
        if(rData != 0)
        {
                this.pointsReq = rData.pointsReq;
        }
        else
        {
                this.pointsReq = 0;
        }
        
        this.metaData = rData.metaData;
    }

}
