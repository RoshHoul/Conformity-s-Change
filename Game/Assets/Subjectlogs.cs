using UnityEngine;
using System.Collections;

public class Subjectlogs : MonoBehaviour {

    public AudioClip audio;
    public AudioSource source;
	// Use this for initialization
    
    void Start() {
    	source = GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
            source.PlayOneShot(audio, 1.0f);
    }
}

