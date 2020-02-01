using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public bool Working;

    // Start is called before the first frame update
    void Start() {

    }
    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * Speed;
        float moveVertical = Input.GetAxis("Vertical") * Speed;

        moveHorizontal *= Time.deltaTime;
        moveVertical *= Time.deltaTime;

        transform.Translate(moveHorizontal, moveVertical, 0);
        transform.rotation = Quaternion.identity;
    }
}
