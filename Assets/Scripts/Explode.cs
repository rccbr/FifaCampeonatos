using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour
{
    public Vector2 direction;

	// Use this for initialization
	void Start ()
    {
       // InvokeRepeating("ExplodeBalls", 3.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Teams")
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(direction * 400.0f);
    }
}
