using UnityEngine;
using System.Collections;

public class GameScene : MonoBehaviour
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OpenSuperWC()
    {
        GUIAnimSystemFREE.Instance.LoadLevel("SuperWC", 0f);
    }

    public void OpenCups()
    {
        GUIAnimSystemFREE.Instance.LoadLevel("CupsMenu", 0f);
    }

    public void OpenAmericas()
    {
        GUIAnimSystemFREE.Instance.LoadLevel("Americas", 0f);
    }

    public void OpenChampions()
    {
        GUIAnimSystemFREE.Instance.LoadLevel("Champions", 0f);
    }

    public void OpenEuropa()
    {
        GUIAnimSystemFREE.Instance.LoadLevel("Europa", 0f);
    }

    public void OpenAsiaOceania()
    {
        GUIAnimSystemFREE.Instance.LoadLevel("AsiaOcean", 0f);
    }
}
