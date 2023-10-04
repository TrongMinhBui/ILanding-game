using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class TwoDShipMovement : MonoBehaviour
{
    public float speed;
    //public float acceleration;
    public float sideThrust;
    public float upThrust;
    private Vector2 move;

    //private Vector3 move1;
    
    
    
    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        
     movePlayer();   
    }

    public void movePlayer()
    {
        
        Vector3 movement = new Vector3( -move.x, move.y, 0f);
        
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
