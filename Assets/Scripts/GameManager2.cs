using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public static bool isGameOver;
    public float timeCount;
    public GameObject gameoverScreen;
    public float timePerSecond;

    SpikeTop spikeTop;
    [SerializeField] GameObject spikeT;

    SpikeBot spikeBot;
    [SerializeField] GameObject spikeB;

    Spawner spawner;
    [SerializeField] GameObject spawn;



    private void Awake()
    {
        isGameOver = false;
        spikeTop = spikeT.GetComponent<SpikeTop>();
        spikeBot = spikeB.GetComponent<SpikeBot>();
        spawner = spawn.GetComponent<Spawner>();
    }
    private void Start()
    {
        timeCount = 0;

    }

    private void Update()
    {
        if (isGameOver)
        {
            gameoverScreen.SetActive(true);

        }

        timeCount += timePerSecond;
        IncreaseSpeed();
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        timeCount = 0;
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    void IncreaseSpeed()
    {
        if (timeCount > 10 && timeCount < 12)
        {
            spawn.SetActive(false);
        }
        if (timeCount > 12 && timeCount < 22)
        {
            spikeBot.speed = 7;
            spikeTop.speed = 7;
            spawn.SetActive(true);
        }
        if (timeCount > 22 && timeCount < 24)
        {
            spawn.SetActive(false);
        }
        if (timeCount > 24 && timeCount < 35)
        {
            spikeBot.speed = 10;
            spikeTop.speed = 10;
            spawn.SetActive(true);
        }
        if (timeCount > 35 && timeCount < 37)
        {
            spawn.SetActive(false);
        }
        if (timeCount > 37)
        {
            spikeTop.speed = 15;
            spikeBot.speed = 15;
            spawn.SetActive(true);
        }

        if (timeCount <= 10)
        {
            spikeTop.speed = 5;
            spikeBot.speed = 5;
        }
    }
}
