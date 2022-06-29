using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGrab : MonoBehaviour
{
    float Yrot;
    RaycastHit hit;
    GameObject grabbedOBJ;
    public Transform grabPos;
    void Update()
    {
        Yrot -= Input.GetAxis("Mouse Y");
        Yrot = Mathf.Clamp(Yrot, -60, 60);
        transform.localRotation = Quaternion.Euler(Yrot,0,0);
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(transform.position, transform.forward, out hit, 5) && hit.transform.GetComponent<Rigidbody>())
        {
           grabbedOBJ = hit.transform.gameObject;
        }
        else if(Input.GetMouseButtonUp(0)){
           grabbedOBJ = null;
        }
        if(grabbedOBJ)
        {
            grabbedOBJ.GetComponent<Rigidbody>().velocity = 10 *(grabPos.position - grabbedOBJ.transform.position);
        }
    }
}
