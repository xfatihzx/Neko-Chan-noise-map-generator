using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour 
{

    float inputX;
    float inputY;

    public Transform Model;

    Animator Anim;

    Vector3 StickDrection;

    Camera MainCamera;

    public float Damp;

    [Range(1,20)]
    public float RotationSpeed;
    // public float speed;



    void Start()
    {

        Anim = GetComponent<Animator>();
        MainCamera = Camera.main;



        
    }



    private void LateUpdate()
    {

        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        StickDrection = new Vector3(inputX, 0, inputY);

        InputMove();
        InputRotation();




    }


    #region  Movement codes = Karakter haraket kodlarý
    void InputMove()
    {

        Anim.SetFloat("speed", Vector3.ClampMagnitude(StickDrection, 1).magnitude, Damp, Time.deltaTime * 10);




    }
    #endregion



    #region InputRotation = Karakter rotasyon ayarlarý   (fare ile dönme)
    void InputRotation() 
    {

        Vector3 rotOfset = MainCamera.transform.TransformDirection(StickDrection);
        rotOfset.y = 0;

        Model.forward = Vector3.Slerp(Model.forward, rotOfset, Time.deltaTime * RotationSpeed);

    }
    #endregion




    void Update()
    {




        
    }
}
