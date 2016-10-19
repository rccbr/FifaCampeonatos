using UnityEngine;
using System.Collections;

public class NewChampionSelection : MonoBehaviour
{
    public Canvas teamSelectionCanvas;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void EnableCanvas()
    {
        teamSelectionCanvas.enabled = true;
    }

    public void CloseCanvas()
    {
        teamSelectionCanvas.enabled = false;
    }
}
