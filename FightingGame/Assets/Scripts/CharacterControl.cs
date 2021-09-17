using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterControl : MonoBehaviour
{
    [Header("Player Properties")]
    [Tooltip("Player's Maximum Health")]
    [SerializeField] int maxHealth = 100;
    [Tooltip("Player's Move Speed")]
    [SerializeField] float moveSpeed = 10f;

    int currentJump = 0;
    [Tooltip("Player's Maximum Amount of Jump")]
    int maxJump = 2;
    [Tooltip("Player's Jumping Power")]
    [SerializeField] float jumpForce = 10f;

    private float horizontal;
    private bool isFacingRight = true;
    private PlayerInputActions playerInputActions;
    private InputAction movement;

    [Header("Other Stuff")]
    [SerializeField] Rigidbody2D playerPhysics;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Animator animator;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions(); //Create new PlayerInputActions
    }

    #region Set-up
    private void OnEnable() //These Actions are from the settings in the InputMaster Unity asset
    {
        movement = playerInputActions.PlayerControls.VectorMovement;
        movement.Enable();

        playerInputActions.PlayerControls.Jump.performed += DoJump;
        playerInputActions.PlayerControls.Jump.Enable();

        playerInputActions.PlayerControls.Crouch.performed += DoCrouch;
        playerInputActions.PlayerControls.Crouch.Enable();

        //playerInputActions.PlayerControls.WalkLeft.performed += DoWalkLeft;
        //playerInputActions.PlayerControls.WalkLeft.Enable();

        //playerInputActions.PlayerControls.WalkRight.performed += DoWalkRight;
        //playerInputActions.PlayerControls.WalkRight.Enable();

        playerInputActions.PlayerControls.AttackA.performed += DoAttackA;
        playerInputActions.PlayerControls.AttackA.Enable();

        playerInputActions.PlayerControls.AttackB.performed += DoAttackB;
        playerInputActions.PlayerControls.AttackB.Enable();

        playerInputActions.PlayerControls.AttackC.performed += DoAttackC;
        playerInputActions.PlayerControls.AttackC.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
        playerInputActions.PlayerControls.Jump.Disable();
        playerInputActions.PlayerControls.Crouch.Disable();
        //playerInputActions.PlayerControls.WalkLeft.Disable();
        //playerInputActions.PlayerControls.WalkRight.Disable();
        playerInputActions.PlayerControls.AttackA.Disable();
        playerInputActions.PlayerControls.AttackB.Disable();
        playerInputActions.PlayerControls.AttackC.Disable();
    }
    #endregion
    private void Update()
    {
        playerPhysics.velocity = new Vector2(horizontal * moveSpeed, playerPhysics.velocity.y);

        if(!isFacingRight && horizontal > 0f) // Flip Character Sprite
        {
            Flip();
        }
        else if (isFacingRight && horizontal < 0f)
        {
            Flip();
        }
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    #region Movement Methods
    public void VectorMovement(InputAction.CallbackContext context)
    {
        Debug.Log("Start Running");
        horizontal = context.ReadValue<Vector2>().x; //Read Value
        animator.Play("Run");

        if (context.canceled)
        {
            Debug.Log("Stop Running");
            animator.Play("Idle");
        }
    }

    public void DoJump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump");
        if (context.performed && IsGrounded()) // Jump Button Pressed & is Grounded
        {
            playerPhysics.velocity = new Vector2(playerPhysics.velocity.x, jumpForce);
            animator.Play("Jump");
        }
        if (context.canceled && playerPhysics.velocity.y > 0f) // Jump Button Released
        {
            playerPhysics.velocity = new Vector2(playerPhysics.velocity.x, playerPhysics.velocity.y * 0.5f);
        }
    }

    public void DoCrouch(InputAction.CallbackContext context)
    {
        Debug.Log("Crouch");
        // No Crouching in the game yet
    }
    #endregion

    #region Attack Methods
    public void DoAttackA(InputAction.CallbackContext context)
    {
        Debug.Log("Attack A");
        animator.Play("Attack1");
    }
    public void DoAttackB(InputAction.CallbackContext context)
    {
        Debug.Log("Attack B");
        animator.Play("Attack2");
    }
    public void DoAttackC(InputAction.CallbackContext context)
    {
        Debug.Log("Attack C");
        animator.Play("Attack3");
    }
    #endregion
}
