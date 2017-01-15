using UnityEngine;
using System.Collections;

public class CUSTFollowPlayer : MonoBehaviour {

    Transform leapBox;
    public Transform target;
    public float smoothing = 4f;

    void Start()
    {
        target = GameObject.Find("FPSController").transform;
        leapBox.transform.position = transform.position;
    }

    void Update()
    {

        Vector3 temp = target.localScale;
        //        temp.x = (target.localScale.x + 0.1f);
        //       temp.y = (target.localScale.y - 1.02f);
        //      temp.z = (target.localScale.z - 1.1f);

        temp.x = target.transform.position.x + 0.1f;
        temp.y = target.transform.position.y + 1.0f;
        temp.z = target.transform.position.z + 0.9f;


        transform.position = temp;
        transform.rotation = target.transform.rotation;
    }
}

/* 
 leap box: x = -57; y = 15.48, z = 0.58
 player: x = -57.1; y = 14.46747, z = -0.4
    
    
     Vector3 temp = target.localScale;
        temp.x = (target.localScale.x + 0.1f);
        temp.y = (target.localScale.y - 1.02f);
        temp.z =  (target.localScale.z - 1.1f)*/
        