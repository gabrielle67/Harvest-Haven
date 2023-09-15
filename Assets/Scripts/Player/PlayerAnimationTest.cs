using UnityEngine;

public class PlayerAnimationTest : MonoBehaviour
{
    public float xInput;
    public float yInput;
    public bool isWalking;
    public bool isRunning;
    public bool isIdle;
    public bool isCarrying;
    public ToolEffect toolEffect;
    public bool isUsingToolRight;
    public bool isUsingToolLeft;
    public bool isUsingToolUp;
    public bool isUsingToolDown;
    public bool isLiftingToolRight;
    public bool isLiftingToolLeft;
    public bool isLiftingToolUp;
    public bool isLiftingToolDown;
    public bool isPickingRight;
    public bool isPickingLeft;
    public bool isPickingUp;
    public bool isPickingDown;
    public bool isSwingingToolRight;
    public bool isSwingingToolLeft;
    public bool isSwingingToolUp;
    public bool isSwingingToolDown;
    public bool idleUp;
    public bool idleDown;
    public bool idleLeft;
    public bool idleRight;

    private void Update()
    {
        EventHandler.CallMovementEvent(xInput, yInput, isWalking, isRunning, isIdle, isCarrying, toolEffect,
isUsingToolRight, isUsingToolLeft, isUsingToolUp, isUsingToolDown,
isLiftingToolRight, isLiftingToolLeft, isLiftingToolUp, isLiftingToolDown,
isPickingRight, isPickingLeft, isPickingUp, isPickingDown,
isSwingingToolRight, isSwingingToolLeft, isSwingingToolUp, isSwingingToolDown,
idleUp, idleDown, idleLeft, idleRight);
    }
    private void Start()
    {
        // Disable the script by default
        enabled = false;
    }
}