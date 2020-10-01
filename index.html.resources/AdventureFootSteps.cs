using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureFootSteps : MonoBehaviour {

    private string floorTag = "default";
    public AudioSource footAudioSource;
    public AudioClip[] defaultSteps;
    public AudioClip[] woodSteps;
    public AudioClip[] metalSteps;
    public AudioClip[] concreteSteps;
    public AudioClip[] sandSteps;
    public AudioClip[] carpetSteps;
    public AudioClip[] tileSteps;

    private void OnTriggerEnter (Collider other) {
        floorTag = other.gameObject.tag;
        Debug.Log (floorTag);
    }

    private void OnTriggerExit (Collider other) {
        floorTag = "default";
        //Debug.Log (floorTag);
    }

    public AudioClip GetAudio () {

        if (floorTag == "wood") {
            return woodSteps[Random.Range (0, woodSteps.Length)];
        } else if (floorTag == "metal") {
            return metalSteps[Random.Range (0, metalSteps.Length)];
        } else if (floorTag == "dirt") {
            //	GetComponent<AudioSource>().volume = 1.0f;
            return sandSteps[Random.Range (0, sandSteps.Length)];
        } else if (floorTag == "sand") {
            //GetComponent<AudioSource>().volume = 1.0f;
            return sandSteps[Random.Range (0, sandSteps.Length)];
        } else if (floorTag == "carpet") {
            //GetComponent<AudioSource>().volume = 1.0f;
            return carpetSteps[Random.Range (0, carpetSteps.Length)];
        } else if (floorTag == "tile") {
            //GetComponent<AudioSource>().volume = 1.0f;
            return tileSteps[Random.Range (0, tileSteps.Length)];
        } else {
            //GetComponent<AudioSource>().volume = 1.0f;
            return defaultSteps[Random.Range (0, defaultSteps.Length)];
        }
    }

    private void Step () {

        //AudioClip clip = GetRandomClip ();

        footAudioSource.PlayOneShot (GetAudio (), GetComponent<AudioSource> ().volume);

    }

}