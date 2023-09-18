using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GapScript : MonoBehaviour
{
    public LogicScript logic;
    public PlayerScript player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (player.birdIsAlive)
            logic.AddScore();
    }
}
