using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    private float _StartTime;
    private bool _workBench = false;
    public bool countEnd = false;
    public bool WorkBench;
    public Text TimerText;

    // Start is called before the first frame update
    void Start()
    {

    }
         

    // Update is called once per frame
    void Update()
    {
        float t;
        float seconds;
        int countDown = 0;

        if (_workBench == true)
        {
            t = Time.time - _StartTime;
            seconds = (t % 60);
            countDown = (5 - ((int)seconds % 6));
            TimerText.text = "Crafting: " + countDown.ToString();
            if (countDown == 0)
            {
                _workBench = false;
                countEnd = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if ((coll.gameObject.tag == "Player") && (countEnd == false))
        {
            _workBench = true;
            _StartTime = Time.time;
        }
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            _workBench = false;
            countEnd = false;
        }
    }
}
