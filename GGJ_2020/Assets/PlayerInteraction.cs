using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using baseComponents;
public class PlayerInteraction : MonoBehaviour
{
    void Start()
    {        
    }

    void Update()
    {
        
    }

    //On trigger 2D methods
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Workbench")) {
            print(other.name);
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        print("Exit range of " + other.name);
    }
}
