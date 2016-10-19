using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Sorteio : MonoBehaviour
{
    public List<Image> placeHolders;

    public List<Sprite> timesEscudos;

    public List<int> timesGrupos;

    public int teamID;
    public int teamIcon;
    public int teamHolder;

	
	void Start ()
    {
        StartCoroutine(ChooseNextTeam());
    }

    void RaflleGroupTeam()
    {
        teamID = Random.Range(0, timesGrupos.Count);
        teamIcon = Random.Range(0, timesEscudos.Count);

        FillGroup();
    }

    void FillGroup()
    {
        placeHolders[teamID].sprite = timesEscudos[teamIcon];
        placeHolders[teamID].GetComponent<GUIAnimFREE>().enabled = true;

        placeHolders.RemoveAt(teamID);
        timesEscudos.RemoveAt(teamIcon);
        timesGrupos.RemoveAt(teamID);

        if (placeHolders.Count > 0)
            StartCoroutine(ChooseNextTeam());
    }

    IEnumerator ChooseNextTeam()
    {
        yield return new WaitForSeconds(3.0f);

        RaflleGroupTeam();
    }
}
