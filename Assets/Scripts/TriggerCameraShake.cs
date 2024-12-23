using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeTrigger : MonoBehaviour
{
    public KeyCode screamKey = KeyCode.G;
    public CameraShake cameraShake;
    void Update()
    {
        if (Input.GetKey(screamKey))
        {
            StartCoroutine(cameraShake.Shake(0.15f, 0.4f));
        }    
    }
}
