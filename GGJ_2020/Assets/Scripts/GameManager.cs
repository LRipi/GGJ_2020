using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class GameManager: MonoBehaviour
{
    public static GameManager instance;
    public int score;
    public int player;
    private float timer;
    public Text scoreText;
    public List<int> objectList;

    private void Awake()
    {
        makeSingleton();
        timer = 10.0f;
    }

    private void Update()
    {
        updateTimer();
        catchEntry();
    }

    private void makeSingleton()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void updateTimer()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
            print("END");
        else
            scoreText.text = timer.ToString("0");
    }

    private void catchEntry()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        } else if (Input.GetKeyDown(KeyCode.Z))
        {

        } else if (Input.GetKeyDown(KeyCode.Z))
        {

        } else if (Input.GetKeyDown(KeyCode.Z))
        {

        }
    }
}
