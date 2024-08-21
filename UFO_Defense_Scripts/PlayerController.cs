using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private AudioSource playerAudio;
    public float horizontalInput;
    public float speed = 25;

    public float xRange = 30;

    public Transform blaster;
    public GameObject lazerBolt;
    public AudioClip laserSound;

    public GameManager gameManager;

    
    void Start()
    {   //                             GameObject               Script Component
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //Reference GameManager script on GameManager object
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      // Set horizontalInput to recive values from keybord
       horizontalInput = Input.GetAxis("Horizontal");

    // Moves Player left and righ
       transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
       //Keep player with in bounds
       //Left side wall
       if(transform.position.x < -xRange ) 
       {
           transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
       }
       //Right side wall
        if(transform.position.x > xRange ) 
        {
         transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }
         // if space bar is pressed fire lazerbolt
        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false) // *Second condition gameManager.isGameOver prevents the player from shooting after isGameOver becomes trues

        {
            //Create lazerBolt at the blaster transform position maintaining the objects rotation.
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
            playerAudio.PlayOneShot(laserSound, 1.0f);
        }
    }
}
