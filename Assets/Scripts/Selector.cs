using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Selector : MonoBehaviour
{
    public GameObject team;

    public Transform center;

    public Text selectedTeam;

    public FillTeam fillTeam;

    public bool getIt = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            getIt = true;
    }

    void DeleteTeam()
    {
        Destroy(team);

        fillTeam.FillTeamName(selectedTeam);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (getIt)
        {
            team = col.gameObject;
            team.transform.position = center.position;
            team.transform.rotation = Quaternion.identity;
            team.GetComponent<Rigidbody2D>().isKinematic = true;

            selectedTeam.text = team.GetComponent<Team>().teamName;

            getIt = false;

            Invoke("DeleteTeam", 3.0f);
        }
    }
}
