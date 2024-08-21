using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioSource explosionSource;

    void Start() {
        explosionSource = GetComponent<AudioSource> ();
    }

    void Update() {
        
    }

    void OnCollisionEnter (Collision collision) {
        if(collision.gameObject.tag == "Explosion") {

            explosionSource.Play();
        }
    }
}
