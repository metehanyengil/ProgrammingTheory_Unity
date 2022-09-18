using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public class Car : MonoBehaviour
{

   Rigidbody physics;
   protected float speed;
 
    
    void Start()
    {

        physics = GetComponent<Rigidbody>();
        speed = 500;
        
    }

    
    void Update()
    {
        CarMove();
        
    }


    public virtual void CarMove(){



        if(Input.GetKeyDown(KeyCode.Space)&& physics !=null){

            physics.AddForce((Vector3.right*speed),ForceMode.Force);
            Debug.Log("Car");

        

            
        }




    }
}
