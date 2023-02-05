using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ClickFunction : MonoBehaviour
{
    public Animator cameraAnimator;
    public Camera cam;
    public GameObject optionsMenu;
    public GameObject switchObjectOff;
    public GameObject switchObjectOn;

    void Start()
    {
        AkSoundEngine.SetSwitch("Amb_Switch", "Start", this.gameObject);
        AkSoundEngine.PostEvent("Play_AMBIANCE_SWITCH", this.gameObject);
        AkSoundEngine.SetState("Music_State", "Default");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            optionsMenu.SetActive(!optionsMenu.activeInHierarchy);
        }
        DetectObjectWithRaycast();
    }

    public void DetectObjectWithRaycast()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == ("GameStart")) {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    switchObjectOff.SetActive(!switchObjectOff.activeInHierarchy);
                    switchObjectOn.SetActive(!switchObjectOn.activeInHierarchy);
                    AkSoundEngine.PostEvent("Play_GameStart", this.gameObject);
                    AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    AkSoundEngine.PostEvent("Play_BUZZES", this.gameObject);
                    AkSoundEngine.SetSwitch("Amb_Switch", "First_Rectangle", this.gameObject);
                    cameraAnimator.SetBool("StartGame", true);
                }

                if (hit.collider.gameObject.name == ("Outlet01"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    // AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    cameraAnimator.SetBool("Dezoom01", true);
                    AkSoundEngine.PostEvent("Play_OUTLET", this.gameObject);
                    AkSoundEngine.SetSwitch("Amb_Switch", "Second_Rectangle", this.gameObject);
                    AkSoundEngine.SetState("Music_State", "First_Outlet");
                    AkSoundEngine.SetRTPCValue("Zoom_RTPC", 80);
                    switchObjectOn.SetActive(!switchObjectOn.activeInHierarchy);
                }

                if (hit.collider.gameObject.name == ("Outlet02"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    //AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    //cameraAnimator.SetBool("StartGame", true);
                    AkSoundEngine.PostEvent("Play_OUTLET", this.gameObject);
                    AkSoundEngine.SetState("Music_State", "Second_Outlet");
                }

                if (hit.collider.gameObject.name == ("Outlet03"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    //AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    cameraAnimator.SetBool("Dezoom02", true);
                    AkSoundEngine.PostEvent("Play_OUTLET", this.gameObject);
                    AkSoundEngine.SetSwitch("Amb_Switch", "Third_Rectangle", this.gameObject);
                    AkSoundEngine.SetState("Music_State", "Third_Outlet");
                    AkSoundEngine.SetRTPCValue("Zoom_RTPC", 40);
                }

                if (hit.collider.gameObject.name == ("Outlet04"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    //AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    //cameraAnimator.SetBool("StartGame", true);
                    AkSoundEngine.PostEvent("Play_OUTLET", this.gameObject);
                    AkSoundEngine.SetState("Music_State", "Fourth_Outlet");
                }

                if (hit.collider.gameObject.name == ("Outlet05"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    //AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    cameraAnimator.SetBool("Dezoom03", true);
                    AkSoundEngine.PostEvent("Play_OUTLET", this.gameObject);
                    AkSoundEngine.SetSwitch("Amb_Switch", "Fourth_Rectangle", this.gameObject);
                    AkSoundEngine.SetState("Music_State", "Fifth_Outlet");
                    AkSoundEngine.SetRTPCValue("Zoom_RTPC", 20);
                }

                if (hit.collider.gameObject.name == ("Outlet06"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    //AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    //cameraAnimator.SetBool("StartGame", true);
                    AkSoundEngine.PostEvent("Play_OUTLET", this.gameObject);
                    AkSoundEngine.SetState("Music_State", "Sixth_Outlet");
                }

                if (hit.collider.gameObject.name == ("Outlet07"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    //AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    //cameraAnimator.SetBool("DezoomFinal", true);
                    AkSoundEngine.PostEvent("Play_OUTLET", this.gameObject);
                    AkSoundEngine.SetState("Music_State", "Seventh_Outlet");
                }

                if (hit.collider.gameObject.name == ("Outlet08"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    //AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    cameraAnimator.SetBool("DezoomFinal", true);
                    AkSoundEngine.PostEvent("Play_OUTLET", this.gameObject);
                    AkSoundEngine.SetSwitch("Amb_Switch", "Fifth_Rectangle", this.gameObject);
                    AkSoundEngine.SetState("Music_State", "Eight_Outlet");
                    AkSoundEngine.SetRTPCValue("Zoom_RTPC", 0);
                }
            }
        }
    }

    
}
