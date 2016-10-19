using UnityEngine;
using System.Collections;

public class DisableCanvas : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void DisableCanvasUI()
    {
        GetComponent<Canvas>().enabled = false;
    }
}
