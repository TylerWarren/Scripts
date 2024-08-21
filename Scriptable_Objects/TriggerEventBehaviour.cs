using UnityEngine;
using UnityEngine.Events;
public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

   
    public void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
