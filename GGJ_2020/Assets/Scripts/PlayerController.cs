using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // speed and boolean variables
    public float Speed;
    public bool Working;
    public SpriteRenderer PlayerSprite;

    public PlayerAnimationSprite PlayerAnimation;

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

        // move the parent
        transform.Translate(moveHorizontal, moveVertical, 0);
        
        // if any key is pressed, the animation will be played, else no animation (idle mode)
        if (Input.anyKey)
        {
            ChangeSprite(moveHorizontal, moveVertical);
        }
        else
        {
            PlayerAnimation.SetState(PlayerAnimationSprite.PlayerStateRun.NONE);
        }
        // block rotation
        transform.rotation = Quaternion.identity;
    }

    void ChangeSprite(float X, float Y)
    {
        // if the player is facing a particular direction, we go throught the sprite list to 
        // display the animation. This is a way to avoid the animator tool.
        if (X < 0)
        {
            PlayerAnimation.SetState(PlayerAnimationSprite.PlayerStateRun.LEFT);
            print("player facing left");
        }
        else if (X > 0)
        {
            PlayerAnimation.SetState(PlayerAnimationSprite.PlayerStateRun.RIGHT);
            print("player facing right");
        }
        else if (Y > 0)
        {
            PlayerAnimation.SetState(PlayerAnimationSprite.PlayerStateRun.UP);
            print("player facing up");
        }
        else if (Y < 0)
        {
            PlayerAnimation.SetState(PlayerAnimationSprite.PlayerStateRun.DOWN);
            print("player facing bottom");
        }
    }
}
