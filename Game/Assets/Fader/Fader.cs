using UnityEngine;
using System.Collections;

public class Fader : MonoBehaviour
{
    public GameObject endingtext;
    public GameObject fade;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            endingtext.SetActive(true);
            fade.GetComponent<Animator>().SetTrigger("FadeIn");
        }
    }


}

