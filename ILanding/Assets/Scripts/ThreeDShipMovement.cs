using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThreeDShipMovement : MonoBehaviour
{
    public float speed;
    //private float maxSpeed = 200;

    private Vector3 flyingMovement;
    
    public void OnMove(InputAction.CallbackContext context)
    {
        flyingMovement = context.ReadValue<Vector3>();
    }
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flyShip();
    }

    public void flyShip()
    {
        Vector3 shipMovement = new Vector3(flyingMovement.x, flyingMovement.y, flyingMovement.z);
        
        transform.Translate(shipMovement * speed * Time.deltaTime, Space.World);
    }
}
