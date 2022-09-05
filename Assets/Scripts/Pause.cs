using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    static public bool paused = false;
    public GameObject Image1, Image2, PlayBtn, PauseBtn;
    public void PauseGame()
    {
        paused = true;
        Image1.SetActive(true); Image2.SetActive(false); PlayBtn.SetActive(true); PauseBtn.SetActive(false);
    }

    public void ResumeGame()
    {
        paused = false;
        Image1.SetActive(false); Image2.SetActive(true); PauseBtn.SetActive(true); PlayBtn.SetActive(false);
    }
}
