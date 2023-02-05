using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ClickFunction : MonoBehaviour
{
    public Animator cameraAnimator;
    public Camera cam;
    public GameObject optionsMenu;

    void Start()
    {
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
                    AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    cameraAnimator.SetBool("StartGame", true);
                }

                if (hit.collider.gameObject.name == ("Outlet01"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    // AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    cameraAnimator.SetBool("Dezoom01", true);
                }

                if (hit.collider.gameObject.name == ("Outlet02"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    //AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    //cameraAnimator.SetBool("StartGame", true);
                }

                if (hit.collider.gameObject.name == ("Outlet03"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    //AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    cameraAnimator.SetBool("Dezoom02", true);
                }

                if (hit.collider.gameObject.name == ("Outlet04"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    //AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    //cameraAnimator.SetBool("StartGame", true);
                }

                if (hit.collider.gameObject.name == ("Outlet05"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    //AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    cameraAnimator.SetBool("Dezoom03", true);
                }

                if (hit.collider.gameObject.name == ("Outlet06"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    //AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    //cameraAnimator.SetBool("StartGame", true);
                }

                if (hit.collider.gameObject.name == ("Outlet07"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    //AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    //cameraAnimator.SetBool("DezoomFinal", true);
                }

                if (hit.collider.gameObject.name == ("Outlet08"))
                {

                    Debug.Log($"{hit.collider.name} Detected",
                        hit.collider.gameObject);
                    //AkSoundEngine.PostEvent("Play_ROOTS", this.gameObject);
                    cameraAnimator.SetBool("DezoomFinal", true);
                }
            }
        }
    }

    
}
