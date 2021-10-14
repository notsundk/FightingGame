using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterControl : MonoBehaviour
{
    [Header("Player Properties")]
    [Tooltip("Player's Maximum Health")] [SerializeField] int maxHealth = 100;
    [Tooltip("Player's Move Speed")] [SerializeField] float moveSpeed = 10f;
    public bool onAttacking = false; // We will use this to check if our character is still attacking or not.

    [Header("Other Stuff")]
    [SerializeField] Rigidbody2D playerPhysics;
    private float horizontal;
    public GameObject playerHitbox;
    public Animator animator;
    public PlayerInputActions playerInputActions;
    private InputAction movement;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions(); // Create new PlayerInputActions
        playerHitbox.SetActive(false);
    }

    // Setting-up Player Input Actions
    #region Set-up
    private void OnEnable() //These Actions are from the settings in the InputMaster Unity asset
    {
        movement = playerInputActions.PlayerControls.VectorMovement;
        movement.Enable();

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
        playerInputActions.PlayerControls.AttackA.Disable();
        playerInputActions.PlayerControls.AttackB.Disable();
        playerInputActions.PlayerControls.AttackC.Disable();
    }
    #endregion

    private void Update()
    {
        HorizontalMovement();
        Debug.Log("Horizontal Value: " + horizontal);
    }

    // -----------------------------------------------------------------------------------------------------//
    // ----------------------------------------------------- MOVEMENT --------------------------------------//
    private void HorizontalMovement()
    {
        playerPhysics.velocity = new Vector2(horizontal * moveSpeed, playerPhysics.velocity.y);
    }

    public void VectorMovement(InputAction.CallbackContext context)
    {
        Debug.Log("Start Running");
        horizontal = context.ReadValue<Vector2>().x; //Read Value
        animator.Play("Run");
        onAttacking = false;

        if (context.canceled)
        {
            Debug.Log("Stop Running");
            animator.Play("Idle");
        }
    }

    // -----------------------------------------------------------------------------------------------------//
    // ----------------------------------------------------- ATTACK ----------------------------------------//
    public void DoAttackA(InputAction.CallbackContext context)
    {
        if (onAttacking == false)
        {
            Debug.Log("Do Attack A");
            onAttacking = true;
            animator.Play("Attack1");
        }
    }
    public void DoAttackB(InputAction.CallbackContext context)
    {
        if (onAttacking == false)
        {
            Debug.Log("Do Attack B");
            onAttacking = true;
            animator.Play("Attack2");
        }
    }
    public void DoAttackC(InputAction.CallbackContext context)
    {
        if (onAttacking == false)
        {
            Debug.Log("Do Attack C");
            onAttacking = true;
            animator.Play("Attack3");
        }
    }
}
