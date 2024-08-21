using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : IDContainerBehaviour
{
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); // Reference GameManager Script
    }

    private IEnumerator OnTriggerEnter(Collider other)

      {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if(tempObj == null)
            yield break;

        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
            Debug.Log("Game Over!");
            gameManager.isGameOver = true;
            Time.timeScale = 0; // Freeze Time

        }
    }
}
