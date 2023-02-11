using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCharacterControl : MonoBehaviour
{

    float inputX;
    float inputY;

    public Transform Model;

    Animator anim;

    Vector3 StickDirection;

    Camera mainCamara;

    public float dump;

    [Range(1, 20)]
    public float ratationSpeed;


    void Start()
    {
        anim = GetComponent<Animator>();
        mainCamara = Camera.main;



    }



    private void LateUpdate()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        StickDirection = new Vector3(inputX, 0, inputY);

        InputMove();
        InputRotation();

    }


     void InputMove()
    {

        //anim.SetFloat("speed", Vector3.ClampMagnitude(StickDirection, 1).magnitude, dump, Time.deltaTime * 10);




     }


    #region void InputRotation   fare ile dönme kodu.
    void InputRotation()
    {

        Vector3 rotOfset = mainCamara.transform.TransformDirection(StickDirection);
        rotOfset.y = 0;
       
        Model.forward = Vector3.Slerp(Model.forward, rotOfset, Time.deltaTime * ratationSpeed);



    }
    #endregion




    void Update()
    {
        


    }
}
