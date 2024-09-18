using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class CubeDahorinha : MonoBehaviour
{

    public float velocidade;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float resultX = 1;
        float resultZ = 1;
        float resultadoX = Input.GetAxisRaw("Horizontal") * velocidade;
        float resultadoZ = Input.GetAxisRaw("Vertical") * velocidade;

        for (int i = 0; resultadoX != 0; i++)
        {
            resultadoX++;
        }
        Debug.Log(resultX + ", " + resultZ);
      transform.eulerAngles = new Vector3(resultadoX,0,resultadoZ);


        
    }
}
