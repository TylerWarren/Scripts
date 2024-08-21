using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;
    public AudioClip gameOver;
    private AudioSource gameOverSound;
   
    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        gameOverSound = GetComponent<AudioSource>();
    }
       // Update is called one per frame
    void Update()
    {
        if(isGameOver)
        {
            EndGame(); // Start EndGame method
            gameOverSound.PlayOneShot(gameOver, 1.0f);
        }
        else
            gameOverText.gameObject.SetActive(false); // Keep UI Text Game Over hidden
    }
    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true);// Make Game Over text appear
        Time.timeScale = 0; // Freeze Time
    }
}
