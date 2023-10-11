using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public bool levelCleared = false;
    [Header("Obstacle")]
    
    //[SerializeField] private Transform walls;
    //[SerializeField] private Transform startingMark;
    //[SerializeField] private Transform landingMark;
    
    
    [Header("Player")]
    
    [SerializeField] private SpaceShip _spaceShip;
    [SerializeField] private PowerUps _powerUps;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    
    public void LevelFailed()
    {
        if (levelCleared == false)
        {
            levelCleared = true;
            Debug.Log("Game OVER");
            ResetLevel();
        }
    }

    public void LevelCleared()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GameStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
