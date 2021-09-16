using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
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
    float landCheckThreshold = 0.025f;

    [Header("Other Stuff")]
    [SerializeField] Rigidbody2D playerPhysics;
    private PlayerInputActions playerInputActions;
    private InputAction movement;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions(); //Create new PlayerInputActions
    }

    private void OnEnable() //These Actions are from the settings in the InputMaster Unity asset
    {
        //movement = playerInputActions.PlayerControls.Movement;
        //movement.Enable();



        playerInputActions.PlayerControls.AttackA.performed += DoAttackA;
        playerInputActions.PlayerControls.AttackA.Enable();

        playerInputActions.PlayerControls.AttackB.performed += DoAttackB;
        playerInputActions.PlayerControls.AttackB.Enable();

        playerInputActions.PlayerControls.AttackC.performed += DoAttackC;
        playerInputActions.PlayerControls.AttackC.Enable();
    }

    private void OnDisable()
    {
        //movement.Disable();
        playerInputActions.PlayerControls.AttackA.Disable();
        playerInputActions.PlayerControls.AttackB.Disable();
        playerInputActions.PlayerControls.AttackC.Disable();
    }

    void Update()
    {
        HorizontalMovement();
    }

    #region Movement
    void HorizontalMovement()
    {
        Vector2 currentVelocity = playerPhysics.velocity;
        Vector2 calculateVelocity = new Vector2(0, currentVelocity.y);

            calculateVelocity += new Vector2(moveSpeed, 0);
        
            calculateVelocity += new Vector2(-moveSpeed, 0);


        if (Input.GetKey(KeyCode.D) == false && Input.GetKey(KeyCode.A) == false)
            calculateVelocity = new Vector2(currentVelocity.x, currentVelocity.y);

        playerPhysics.velocity = calculateVelocity;
    }
    #endregion

    #region Collision Checking
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Start collide with : " + collision.gameObject.name);
        Vector3 playerPosition = gameObject.transform.position;

        for (int index = 0; index < collision.contacts.Length; index += 1)
        {
            Vector3 contactPosition = collision.contacts[index].point;

            if (playerPosition.y + landCheckThreshold > contactPosition.y)
            {
                currentJump = 0;
                break;
            }
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        print("Stop collide with : " + collision.gameObject.name);
    }
    #endregion

    #region Attack Methods
    private void DoAttackA(InputAction.CallbackContext obj)
    {
        Debug.Log("Attack A");
    }
    private void DoAttackB(InputAction.CallbackContext obj)
    {
        Debug.Log("Attack B");
    }
    private void DoAttackC(InputAction.CallbackContext obj)
    {
        Debug.Log("Attack C");
    }
    #endregion
}
