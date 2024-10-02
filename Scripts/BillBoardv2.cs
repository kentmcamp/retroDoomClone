using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoardv2 : MonoBehaviour
{
    private Transform camTransform;

    // Start is called before the first frame update
    void Start()
    {
        Camera cam = Camera.main; // Automatically find the Main Camera

        if (cam != null)
        {
            camTransform = cam.transform;
        }
        else
        {
            Debug.LogError("Main Camera not found.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (camTransform != null)
        {
            transform.rotation = camTransform.rotation;
        }
    }
}
