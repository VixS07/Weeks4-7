using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameStates : MonoBehaviour
{
    public FlySpawn flies;
    public GameObject spawner;
    public int score;
    public TextMeshProUGUI scoreDisplay;
    public GameObject win;

    //timer
    public float t = 0;
    public float timerMaxValue = 60;
    public Slider timerVisuals;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreDisplay.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //update timer
        t += Time.deltaTime;
        timerVisuals.value = t;

        //score updater (win screen)
        flies = spawner.GetComponent<FlySpawn>();
        score = flies.fliesKilled;
        scoreDisplay.text = score.ToString();
        //when timer is over show win screen
        if(t >= 60)
        {
            t = t;
            win.SetActive(true);
        }
    }
}
