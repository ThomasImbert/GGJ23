using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFunction : MonoBehaviour
{
    public GameObject myTarget;

    void OnMouseDown()
    {
        Debug.Log(myTarget.gameObject.name);
        AkSoundEngine.PostEvent("Play_Test", this.gameObject);
    }
}
