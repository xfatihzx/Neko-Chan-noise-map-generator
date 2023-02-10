using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerStrafe : MonoBehaviour
{

    float horizontal = 0;
    float vertical = 0;

    Animator animator;

   
    void Start()
    {
       animator= GetComponent<Animator>();




    }





    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        //  Debug.Log(" value of Horizontal = " +  horizontal + "  value of Vertical = " + vertical);               // control walk and run value

        Vector3 vec = new Vector3(horizontal, 0, vertical);
        transform.position += vec*Time.deltaTime*2;

        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);




    }
}
