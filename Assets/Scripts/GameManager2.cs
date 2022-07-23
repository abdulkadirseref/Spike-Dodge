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
        switch (timeCount)
        {
            case 1... 10
                spikeTop.speed = 5;
                spikeBot.speed = 5;
                break;
            case 10... 12
            spawn.SetActive(false);
                break;
            case 12... 22
                spikeBot.speed = 7;
                spikeTop.speed = 7;
                spawn.SetActive(true);
                break;
            case 22... 24
                spawn.SetActive(false);
                break;
            case 24... 35
                spikeBot.speed = 10;
                spikeTop.speed = 10;
                spawn.SetActive(true);
                break;
            case 35... 37
                    spawn.SetActive(false);
                break;
            default:
                spikeBot.speed = 5;
                spikeTop.speed = 5;
                break;
        }
    }
