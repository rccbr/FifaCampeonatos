using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FillTeam : MonoBehaviour
{
    public Text[] groupTeams;

    int index = 0;

    public void FillTeamName(Text name)
    {
        groupTeams[index].text = name.text;

        index++;
    }
}
