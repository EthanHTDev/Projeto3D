using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController controller;
    private Transform myCam;
    private Animator anime;

    public float velocidade = 2f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anime = GetComponent<Animator>();
        myCam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxisRaw("Horizontal") * velocidade;
        float eixoZ = Input.GetAxisRaw("Vertical") * velocidade;

        Vector3 moviment = new Vector3(eixoX, 0, eixoZ);

        anime.SetBool("IsWalking", moviment != Vector3.zero);

        moviment = myCam.TransformDirection(moviment);
        moviment.y = 0;

        controller.Move(moviment * Time.deltaTime);
        controller.Move(new Vector3(0, -9.81f,0) * Time.deltaTime);
        if(moviment != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,
            Quaternion.LookRotation(moviment),  Time.deltaTime * 10);
        }

        
    }
}
