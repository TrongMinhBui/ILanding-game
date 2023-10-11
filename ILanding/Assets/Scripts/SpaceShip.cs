using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpaceShip : MonoBehaviour
{
    //public float speed;
    //public float acceleration;
    public float sideThrust = 5f;
    public float upThrust = 5f;
    private Vector2 move;
    bool thrust = false;
    private Rigidbody rbRocket;
    
    //private Vector3 move1;
    
    
    
    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        rbRocket = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
        thrust = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W);
        MoveShip();   
    }

    public void MoveShip()
    {
        
        Vector3 movementZAngle = new Vector3( 0f, 0f, move.x * sideThrust * Time.deltaTime) ;
        //Debug.Log(movementZAngle.z);
        if(Mathf.Approximately(movementZAngle.z, 0f))
        {
            rbRocket.freezeRotation = false;
            
        }
        //transform.Translate(movementYAngle * upThrust * Time.deltaTime, Space.World);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + movementZAngle);
        rbRocket.freezeRotation = true;
    }

    
    public void FixedUpdate()
    {
        Vector3 movementYAngle = new Vector3(0f, move.y * upThrust * Time.deltaTime, 0f);
        if (thrust)
        {
            rbRocket.AddRelativeForce(movementYAngle);
        }
    }

    
}
