using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float startTime = 60;
    private float currentTime;
    private bool timerStarted;
    public TMP_Text timerTXT;
    public bool playing;

    // I followed a YouTube tutorial for some of this (https://www.youtube.com/watch?v=bGePRqD-SNE), but this is the gist of how to make a timer and how to show it in-game.
    // Future me, come back to this if/when you inevitably get stuck on how to do this in the future!!
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playing = true;
        currentTime = startTime;
        timerTXT.text = currentTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(playing)
        {
           timerStarted = true;
        }

        if (timerStarted)
        {
            currentTime = currentTime - Time.deltaTime;
            timerTXT.text = "TIME REMAINING: " + currentTime.ToString("f2");
        }
        
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;

        }

        else
        {
            timerStarted = false;
            currentTime = 0;
            playing = false;
            Debug.Log("Your Quest is Over!!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
