using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public class Car : MonoBehaviour
{

   Rigidbody physics;
  public float speed = 500;
    
    void Start()
    {

        physics = GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {
        CarMove();
        
    }


    public virtual void CarMove(){

        if(Input.GetKeyDown(KeyCode.Space)&& physics !=null){

            physics.AddForce((Vector3.right*speed),ForceMode.Force);
            Debug.Log("Woww");

        

            
        }




    }
}
