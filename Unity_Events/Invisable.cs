using UnityEngine;
using UnityEngine.Events;

public class Invisable : MonoBehaviour
{
    void OnBecameInvisible()
    {
        enabled = false;
    }
}