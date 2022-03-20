using UnityEngine;
public class BingoEventHandler.BingoEcon
{
    // Fields
    public int maxBingoCalls;
    public int maxBallsPerLevel;
    public int ballLevelIntervall;
    public bool purchasersOnly;
    public int basePrize;
    public int prizePerBall;
    
    // Methods
    public BingoEventHandler.BingoEcon()
    {
        this.maxBingoCalls = 24;
        this.maxBallsPerLevel = 4;
        this.ballLevelIntervall = 1;
        this.basePrize = 5;
        this.prizePerBall = 1;
    }

}
