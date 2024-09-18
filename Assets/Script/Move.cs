using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Transform position;
    [SerializeField] Rigidbody rb;
    [SerializeField] public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        position = GetComponent<Transform>();
       
    }

    // Update is called once per frame
    void Update()
    {
        float eixox = Input.GetAxisRaw("Vertical") * velocidade;
        if (transform.position.z >= -14.62f || transform.position.z <= -7.09f)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, eixox);
        }

     


        }
        
}
