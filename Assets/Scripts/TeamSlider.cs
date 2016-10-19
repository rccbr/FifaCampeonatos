using UnityEngine;
using System.Collections;

public class TeamSlider : MonoBehaviour
{
    public Canvas canvasSelection;

    public float sliderSpeed = 1f;
    public float currentPos;
    public float nextPos;

    public bool buttonDown = false;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        ProcessClick();

        if (nextPos < currentPos && buttonDown && canvasSelection.enabled)
        {
            sliderSpeed = -0.5f;

            MoveSlider();

            buttonDown = false;
        }
        
        if (nextPos > currentPos && buttonDown && canvasSelection.enabled)
        {
            sliderSpeed = 0.5f;

            MoveSlider();

            buttonDown = false;
        }
	}

    void ProcessClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentPos = Input.mousePosition.x;

            buttonDown = true;
        }
        else
            sliderSpeed = 0f;

        if (Input.GetMouseButton(0))
            nextPos = Input.mousePosition.x;
    }

    void MoveSlider()
    {
        iTween.MoveBy(this.gameObject, iTween.Hash("x", sliderSpeed * 600.0f, "easeType", "linear", "time", 0.5f));
    }
}
