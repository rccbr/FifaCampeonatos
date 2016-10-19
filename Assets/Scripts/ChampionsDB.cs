using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class ChampionsDB
{
    [Serializable]
    public struct ChampionTeam
    {
        public string name;
        public int teamID;
    }

    public ChampionTeam[] Americas;
    public ChampionTeam[] Champions;
    public ChampionTeam[] Europa;
    public ChampionTeam[] AsiaOcean;

    public string Times;

    public static ChampionsDB CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<ChampionsDB>(jsonString);
    }
}
