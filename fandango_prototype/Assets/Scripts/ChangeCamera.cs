using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    //public Transform teleportTarget;
    public GameObject thePlayer;
    public Camera cameraTarget;
    public Camera mainCamera;

    private void Start()
    {
        mainCamera.enabled = true;
        cameraTarget.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SwitchCamera();
            //thePlayer.transform.position = teleportTarget.transform.position;
        }
    }

    private void SwitchCamera()
    {
        mainCamera.enabled = false;
        cameraTarget.enabled = true;
    }
}
