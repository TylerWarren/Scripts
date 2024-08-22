using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehaviourScript : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggrtEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
