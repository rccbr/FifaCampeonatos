using UnityEngine;
using System.Collections;

public class RotateGlobe : MonoBehaviour
{
    public bool rotate = false;

	// Use this for initialization
	void Start ()
    {
        Invoke("BeginRotate", 3.0f);
	}
	
	// Update is called once per frame
	void Update () {

        if (rotate)
            transform.Rotate(Vector3.forward * 50.0f * Time.deltaTime);

        
	}

    void BeginRotate()
    {
        rotate = true;
    }
}
