using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class TwoDShipMovement : MonoBehaviour
{
    public float speed;

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
        //Input.GetKey("space");
     movePlayer();   
    }

    public void movePlayer()
    {
        
        Vector3 movement = new Vector3(0f, move.y, move.x);
        
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
