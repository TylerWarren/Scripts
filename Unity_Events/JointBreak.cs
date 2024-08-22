using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class JointBreak : MonoBehaviour
{
    void OnJointBreak(float breakForce)
    {
        Debug.Log("Joint Broke!, force: " + breakForce);
    }
}