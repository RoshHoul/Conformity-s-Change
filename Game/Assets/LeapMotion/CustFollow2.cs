using UnityEngine;
using System.Collections;

public class CustFollow2 : MonoBehaviour
{
    Transform target;
    Transform cameraBox;

    void Start()
    {
        target = GameObject.Find("FPSController").transform;
        cameraBox = target.transform.GetChild(0);
    }

    void Update()
    {
        transform.position = target.transform.position;
        transform.rotation = target.transform.rotation;
    }
}

//.FindChild("FirstPersonController")