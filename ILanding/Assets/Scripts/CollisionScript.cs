using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour
{
    public SpaceShip spaceShipMovement ;
    public GameScript game;

    

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            FindObjectOfType<SpaceShip>().enabled = false;
            //spaceShipMovement.enabled = false;
            //game.LevelFailed();
            FindObjectOfType<GameScript>().LevelFailed();
            
            //Debug.Log(game.levelCleared);
            //Debug.Log("Game Over" );
        }

        if (collision.collider.CompareTag("Finish"))
        {
            
            FindObjectOfType<GameScript>().LevelCleared();
        }
    }

    
    
}
