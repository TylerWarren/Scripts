using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float delay;
    public GameObject objectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitToSpawn());
    }

    IEnumerator WaitToSpawn ()
    {
        yield return new WaitForSeconds(delay);
        Spawn();
    }

    void Spawn ()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
        StartCoroutine(WaitToSpawn());
    }
}
