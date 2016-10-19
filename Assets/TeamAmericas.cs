using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TeamAmericas : MonoBehaviour
{
    private float offSetPos = 0f;

    public AmericaTeamData americaTeamData;

    TextAsset timesAmericasAsset;

    public Text countryTitleLabel;

    public GameObject teamSlider;

    public Sprite[] Argentina;

    public GameObject[] teams;

	void Start ()
    {
        //timesAmericasAsset = Resources.Load<TextAsset>("TimesAmericas");

       // americaTeamData = AmericaTeamData.CreateFromJSON(timesAmericasAsset.text);

       // teams = new GameObject[americaTeamData.Argentina.Length];

        //CreateTeams();
	}
	
	void Update ()
    {
	    
	}

    void CreateTeams()
    {
        countryTitleLabel.text = "Argentina";

        for (int i = 0; i <= americaTeamData.Argentina.Length - 1; i++)
        {
            teams[i] = new GameObject("team");
            teams[i].AddComponent<Image>();
            teams[i].GetComponent<Image>().sprite = Argentina[americaTeamData.Argentina[i].teamID];
            teams[i].AddComponent<Button>();
            teams[i].gameObject.transform.parent = teamSlider.transform;
            teams[i].GetComponent<RectTransform>().localPosition = new Vector3(offSetPos, .0f, .0f);
            offSetPos += 200.0f;
        }
    }
}
