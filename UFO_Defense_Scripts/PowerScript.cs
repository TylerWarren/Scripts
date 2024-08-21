using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Text Mesh Pro namespace added to access the unity librarys for UI


public class PowerScript : MonoBehaviour
{
    public TextMeshProUGUI MyscoreText;
    private int PowerNum;


    // Start is called before the first frame update
    void Start()
    {
        
        PowerNum = 0;
        MyscoreText.text = "Power : " + PowerNum;

    }


    private void OnTriggerEnter(Collider Pickup)
    {

        if (Pickup.tag == "MyPickup")
        {

            PowerNum += 1;
            Destroy(Pickup.gameObject);
            MyscoreText.text = "Power: " + PowerNum;

        }

    }
    
}
