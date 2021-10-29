using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitbox : MonoBehaviour
{
    [SerializeField] Player1Controller CharacterControl; // Reference CharacterControl.cs

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player2") == true)
        {
            Debug.Log("Deal damage to : " + collision.gameObject.name);
        }
    }
}
