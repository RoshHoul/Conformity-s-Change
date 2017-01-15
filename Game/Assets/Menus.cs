using UnityEngine;
using System.Collections;

public class Menus : MonoBehaviour
{

    GameObject button;

    private bool IsHand(Collider other)
    {
        if (other.transform.parent && other.transform.parent.parent && other.transform.parent.parent.GetComponent<HandModel>())
            return true;
        else
            return false;
    }

    void Start()
    {
        button = GameObject.Find("StartButton");
    }


    void OnTriggerEnter(Collider other)
    {

        Debug.Log("Pipa");
        if ((IsHand(other) ))
        {
            Application.LoadLevel("wasted talents");
        }
        else if (IsHand(other))
        {
            Application.Quit();
        }

    }

    void Update()
    {

    }
}
