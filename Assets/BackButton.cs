using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour
{
    public string sceneName;

	public void OpenScene()
    {
        GUIAnimSystemFREE.Instance.LoadLevel(sceneName, 0f);
    }
}
