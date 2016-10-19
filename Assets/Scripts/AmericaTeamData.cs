using UnityEngine;
using System.Collections;

[System.Serializable]
public class AmericaTeamData
{
    [System.Serializable]
    public struct TimesAmericas
    {
        public string name;
        public int teamID;
    }

    public TimesAmericas[] Argentina;
    public TimesAmericas[] Brasil;
    public TimesAmericas[] Colombia;
    public TimesAmericas[] Chile;
    public TimesAmericas[] EstadosUnidos;
    public TimesAmericas[] Mexico;

    public static AmericaTeamData CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<AmericaTeamData>(jsonString);
    }
}
