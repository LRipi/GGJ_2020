using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    public static GameManager instance;
    public int score;
    public int player;
    private float timer;
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
            print("HEY");
    }

    private void catchEntry()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {

        }
    }
}
