using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_ListenerRotation : MonoBehaviour
{

    public Transform cameraRotation;
    

    // Update is called once per frame
    void Update()
    {
        transform.rotation = cameraRotation.transform.rotation;
    }
}
