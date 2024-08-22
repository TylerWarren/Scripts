using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class MouseOver : MonoBehaviour
{
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }
        void OnMouseEnter()
    {
        rend.material.color = Color.red;
    }
        void OnMouseOver()
    {
        rend.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
    }
        void OnMouseExit()
    {
        rend.material.color = Color.white;
    }
}