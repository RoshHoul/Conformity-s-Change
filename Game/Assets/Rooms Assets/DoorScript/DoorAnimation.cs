using UnityEngine;
using System.Collections;

public class DoorAnimation : MonoBehaviour
{
    bool isDoorOpen;
	// Use this for initialization
	void Start ()
    {
	
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.GetComponent<Animator>().SetTrigger("Open");
            isDoorOpen = true;
        }
            
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.GetComponent<Animator>().SetTrigger("Close");
             isDoorOpen = false;
        }
    }

}
