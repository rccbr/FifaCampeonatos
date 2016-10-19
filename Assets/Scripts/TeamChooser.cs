using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TeamChooser : MonoBehaviour
{
    public Canvas canvasUI;
    public Animator canvasAnim;

    public int index = -1;

    public bool set = false;

    public GameObject[] boardTeamColliders;
    public BoxCollider[] boxColliders;

    public Image escudo;
    public Text nameTeam;

    public int clickCount = 0;
	
	
    void Awake()
    {
        canvasAnim = canvasUI.GetComponent<Animator>();

        foreach (GameObject obj in boardTeamColliders)
        {
            index++;

            boxColliders[index] = obj.GetComponent<BoxCollider>();
        }
    }

    void Update()
    {
        
    }
    
	void FixedUpdate ()
    {
        ChooseTeam();
	}

    void ChooseTeam()
    {
        Ray rayCam = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        Debug.DrawRay(rayCam.origin, rayCam.direction * 50, Color.yellow);

        if (Physics.Raycast(rayCam, out hit, 50.0f))
        {
            if (Input.GetMouseButtonDown(0))
            {
                clickCount++;

                if (hit.collider.gameObject.tag == "Team" && !canvasUI.enabled && clickCount==1)
                {
                    canvasUI.enabled = true;
                    canvasAnim.SetBool("fadein", true);

                    escudo.sprite = hit.collider.GetComponent<SpriteRenderer>().sprite;
                    nameTeam.text = hit.collider.gameObject.name;
                    nameTeam.rectTransform.localPosition = new Vector3(hit.collider.gameObject.GetComponent<Team>().alignmentX,
                       -200.2f, 0f);

                    DisableColliders();

                    set = true;
                }

                if (clickCount>=2)
                {
                    canvasAnim.SetBool("fadein", false);

                    DisableColliders();

                    clickCount = 0;
                }
            }
        }
    }

    void DisableColliders()
    {
        for (int i=0; i<=boxColliders.Length-1; i++)
        {
            boxColliders[i].enabled = !boxColliders[i].enabled;
        }
    }
}
