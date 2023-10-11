using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    public void LevelCompleted(Collision collision)
    {
        if (collision.collider.CompareTag("Finish"))
        {
        FindObjectOfType<GameScript>().LevelCleared();
        }
    }
}
