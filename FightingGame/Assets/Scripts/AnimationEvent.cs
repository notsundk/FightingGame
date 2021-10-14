using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvent : MonoBehaviour
{
    [SerializeField] CharacterControl CharacterControl; // Linking Script

    public void End_Attacking() // Return player to the Idle Stage in which they can do "anything". Player can also walk to cancel attacks.
    {
        CharacterControl.onAttacking = false;
        CharacterControl.animator.Play("Idle");
        Debug.Log("Can Attack Again");
    }

    public void Activate_AttackHitBox()
    {
        CharacterControl.playerHitbox.SetActive(true);
    }

    public void Deactivate_AttackHitBox()
    {
        CharacterControl.playerHitbox.SetActive(false);
    }

    public void Lock_Movement() // Lock Controls When Player is not allow to cancel out using movement.
    {

    }

    public void Unlock_Movement()
    {

    }
}
