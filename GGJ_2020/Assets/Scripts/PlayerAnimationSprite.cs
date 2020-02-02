using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Because Animator on Unity is pure shit (really)
public class PlayerAnimationSprite : MonoBehaviour
{
    // enum is a bunch of related macros
    public enum PlayerStateRun
    {
        NONE = 0,
        UP = 1,
        DOWN,
        LEFT,
        RIGHT
    }

    // Get Sprite renderer
    public SpriteRenderer PlayerSpriteRenderer;

    // Get sprite "sheet" in list
    public List<Sprite> RunningDown;
    public List<Sprite> RunningUp;
    public List<Sprite> RunningLeft;
    public List<Sprite> RunningRight;
    public Sprite Idle;
    public int NbrSpriteInAnimate;

    // _temp for loop in list above
    private int _temp = 0;
    // Keep current animation state
    private PlayerStateRun _animationState = default;

    // Making a clock
    private float _waitTime = 0.1f;
    private float _timer = 0.0f;

    private void Start()
    {
        // Default animation = NONE
        _animationState = PlayerStateRun.NONE;
    }

    private void Update()
    {
        // Get clock value
        _timer += Time.deltaTime;

        if (_timer >= _waitTime)
        {
            // State managment
            switch (_animationState)
            {
                case PlayerStateRun.DOWN:
                    {
                        AnimateTheSprite(RunningDown);
                        break;
                    }
                case PlayerStateRun.UP:
                    {
                        AnimateTheSprite(RunningUp);
                        break;
                    }
                case PlayerStateRun.LEFT:
                    {
                        AnimateTheSprite(RunningLeft);
                        break;
                    }
                case PlayerStateRun.RIGHT:
                    {
                        AnimateTheSprite(RunningRight);
                        break;
                    }
                case PlayerStateRun.NONE:
                    {
                        PlayerSpriteRenderer.sprite = Idle;
                        break;
                    }
                default:
                    break;
            }
            // move in the sprite list
            _temp += 1;
            if (_temp == (NbrSpriteInAnimate))
                _temp = 0;
            _timer = 0.0f;
        }
    }
    
    private void AnimateTheSprite(List<Sprite> listToAnimate)
    {
        // change the sprite thats drawn by the component Sprite Renderer
        PlayerSpriteRenderer.sprite = listToAnimate[_temp];
    }

    /// <summary>
    /// Set new state for animation
    /// </summary>
    /// <param name="newState">New state</param>
    public void SetState(PlayerStateRun newState)
    {
        if (newState != _animationState)
        {
            _animationState = newState;
            _temp = 0;
        }
    }
}
