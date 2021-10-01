using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvent : MonoBehaviour
{
    [SerializeField] CharacterControl c; // Linking Script

    public void End_Attacking()
    {
        c.onAttacking = false;
        c.animator.Play("Idle");
        Debug.Log("Can Attack Again");
    }
    public void Activate_AttackHitBox()
    {
        c.playerHitbox.SetActive(true);
    }

    public void Deactivate_AttackHitBox()
    {
        c.playerHitbox.SetActive(false);
    }
}
