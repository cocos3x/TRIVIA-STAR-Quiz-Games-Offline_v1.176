using UnityEngine;
public class TournamentInfo
{
    // Fields
    public int tierIndex;
    public System.DateTime endTime;
    public System.Collections.Generic.List<TournamentPlayer> tournamentPlayers;
    public TournamentPlayer me;
    public int myRank;
    public int myScore;
    
    // Methods
    public TournamentInfo()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.tournamentPlayers = null;
        this.myRank = 0;
        this.myScore = 0;
    }

}
