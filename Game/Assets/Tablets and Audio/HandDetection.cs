using UnityEngine;
using System.Collections;

public class HandDetection : MonoBehaviour {

    public AudioClip audio;
    AudioSource source;
    bool audioFlag, doorFlag = false;
    GameObject doors;

    private bool IsHand(Collider other)
    {
        if (other.transform.parent && other.transform.parent.parent && other.transform.parent.parent.GetComponent<HandModel>())
            return true;
        else
            return false;
    }

    void Start()
    {
        source = GetComponent<AudioSource>();
        doors = GameObject.FindGameObjectWithTag("doors");

    }


    void OnTriggerEnter(Collider other)
    {

        Debug.Log("Pipa");
        if ((IsHand(other)) && (!audioFlag))
        {
            Debug.Log("Tablet's parent is: " + transform.parent.name);
            audioFlag = true;
            source.PlayOneShot(audio, 1.0f);
        }
    }

    void Update()
    {
        if (source.isPlaying && doorFlag == false)
        {
            doorFlag = true;
            doors.GetComponent<BoxCollider>().enabled = false;
            Debug.Log("Message");
        }
  /*      else if (!source.isPlaying && doorFlag == true)
        {
            doors.GetComponent<BoxCollider>().enabled = true;
            doorFlag = false;
        } */
    }
}
