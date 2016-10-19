using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChampionLabel : MonoBehaviour
{
    ChampionsDB championsDB;
    ChampionsDB.ChampionTeam[] champ;

    TextAsset campeonatosText;

    public Image[] teamIcons;
    public Sprite[] americaTeams;
    public Text[] teamNames;

    public Sprite addChampion;
    public GameObject canvasSelection;

    public int id;

    
    void Awake()
    {
        campeonatosText = Resources.Load<TextAsset>("Campeonatos");
    }

    void Start ()
    {
        championsDB = RetrieveChampions();

        champ = new ChampionsDB.ChampionTeam[7];

        if (id == 0)
            champ = championsDB.Americas;
        else if (id == 1)
            champ = championsDB.Champions;
        else if (id == 2)
            champ = championsDB.Europa;
        else if (id == 3)
            champ = championsDB.AsiaOcean;

        ShowChampions();
    }
	
	void Update ()
    {
        
	}

    ChampionsDB RetrieveChampions()
    {
        return ChampionsDB.CreateFromJSON(campeonatosText.text);
    }

    void ShowChampions()
    {
        for (int i=0; i<= teamIcons.Length-1; i++)
        {
            if (i <= champ.Length-1)
            {
                teamIcons[i].sprite = getTeamIcon(champ[i].teamID);
                teamNames[i].text = champ[i].name;
                teamIcons[i].color = new Color(teamIcons[i].color.r, teamIcons[i].color.g, teamIcons[i].color.b,
                                            1f);
            }
            else
            {
                teamIcons[champ.Length].sprite = addChampion;
                teamNames[champ.Length].text = "Vazio";
                teamIcons[champ.Length].gameObject.AddComponent<Button>();
                teamIcons[champ.Length].gameObject.GetComponent<Button>().onClick.AddListener(canvasSelection.GetComponent<NewChampionSelection>().EnableCanvas);
                teamIcons[champ.Length].color = new Color(teamIcons[i].color.r, teamIcons[i].color.g, teamIcons[i].color.b,
                            1f);
                break;
            }
        }
    }

    Sprite getTeamIcon(int teamID)
    {
        Sprite icon;

        icon = americaTeams[teamID];

        return icon;
    }
}
