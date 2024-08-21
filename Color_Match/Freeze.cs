using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Freeze : MonoBehaviour
{
    public Button StartButton;
    void Start()

    {
        Time.timeScale = 0; // Freeze Time
        Button btn = StartButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Time.timeScale = 1;
    }
}
