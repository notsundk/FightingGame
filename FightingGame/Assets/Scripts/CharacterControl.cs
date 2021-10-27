using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterControl : MonoBehaviour
{
    [Header("Player Properties")]
    [Tooltip("Maximum Health")] public int maxHealth = 100;
    [Tooltip("Current Health")] public int currentHealth;
    [Tooltip("Controller Horizontal Value")] [SerializeField] private float horizontal;
    [Tooltip("Move Speed")] [SerializeField] float moveSpeed = 10f;
    public bool onAttacking = false; // We will use this to check if our character is still attacking or not.
    public bool onMovement = false;

    [Header("Other Stuff")]
    public Rigidbody2D playerPhysics;
    public GameObject playerHitbox;
    public Animator animator;
    public PlayerInputActions playerInputActions;
    public InputAction movement;

    [Header("Other Scripts")]
    public HealthBar healthBar; // Reference HealthBar.cs

    private void Awake()
    {
        playerInputActions = new PlayerInputActions(); // Create new PlayerInputActions
        playerHitbox.SetActive(false); // Making sure the Sword's HitBox is false. (Technically this is a "HurtBox", must have the name wrong.)
    }

    private void Start()
    {
        currentHealth = maxHealth; // Set Current HP to the Max HP amount, which is 100.
        healthBar.SetMaxHealth(currentHealth); // Set Health Bar to Current HP, which is 100.
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
        Debug.Log("Controller Horizontal Value: " + horizontal);
    }

    private void FixedUpdate()
    {
        playerPhysics.velocity = new Vector2(horizontal * moveSpeed, playerPhysics.velocity.y);
    }

    // -----------------------------------------------------------------------------------------------------//
    // ----------------------------------------------------- MOVEMENT --------------------------------------//

    public void VectorMovement(InputAction.CallbackContext context)
    {
        Debug.Log("Start Running");
        horizontal = context.ReadValue<Vector2>().x; //Read Value
        animator.Play("Run");
        onAttacking = false;

        if (context.canceled)
        {
            Debug.Log("Stop Running");
            horizontal = 0f;
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
            //TakeDamage(20);
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

    //void TakeDamage(int damage) // For testing UI.
    //{
    //    currentHealth -= damage; // Minus Damage from Current HP.

    //    healthBar.SetHealth(currentHealth); // Set Health Bar UI to Current HP.
    //}
}
