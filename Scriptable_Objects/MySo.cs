using UnityEngine;

public class MySo : ScriptableObject
{
    public GameObject target;

    void Reset()
    {
       Debug.Log("Reset");
        if (!target)
            target = GameObject.FindWithTag("Player");
    }
}