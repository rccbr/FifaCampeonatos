using UnityEngine;
using System.Collections;

public class SceneGUIControl : MonoBehaviour
{
    public static SceneGUIControl instance;

    public GUIAnimFREE logoParent;
    public GUIAnimFREE iniciarText;

    public bool isClickEnabled = false;

    void Awake()
    {
        instance = this;

        GUIAnimSystemFREE.Instance.m_AutoAnimation = false;
    }

	void Start ()
    {
        StartCoroutine(ShowLogo());
	}

	void Update ()
    {
        if (Input.GetMouseButtonDown(0) && isClickEnabled)
        {
            StartCoroutine(HideLogo());

            isClickEnabled = false;
        }
    }

    IEnumerator ShowLogo()
    {
        yield return new WaitForSeconds(8.0f);

        logoParent.MoveIn(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);
        iniciarText.MoveIn(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);

        StartCoroutine(EnableClick());
    }

    IEnumerator EnableClick()
    {
        yield return new WaitForSeconds(5.0f);

        isClickEnabled = true;
    }

    IEnumerator HideLogo()
    {
        yield return null;

        logoParent.MoveOut(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);
        iniciarText.MoveOut(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);

        GUIAnimSystemFREE.Instance.LoadLevel("Game", 1.5f);
    }
}
