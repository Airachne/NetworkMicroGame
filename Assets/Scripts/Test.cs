using Platformer.Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public PlayerController player; 
    public int jumpCount;

    void OnTriggerEnter2D(Collider2D other)
    {
        //only exectue OnPlayerEnter if the player collides with this token.
        //  var player = other.gameObject.GetComponent<PlayerController>();
           if (player != null)
          {

        player.jumpCount = jumpCount; // при активации бонуса  увеличиается количество прыжков
            
            Destroy(this.gameObject); // удаление бонуса 
        }
    }
}
