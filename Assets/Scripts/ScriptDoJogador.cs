using System; // pro meu oi funcionar
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDoJogador : MonoBehaviour
{

    public float Speed;
    public float Hspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Speed += 0.1f * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.S))
        {
            Speed -= 0.05f * Time.deltaTime;
        } else {
            Speed += Math.Sign(Speed) * -0.01f; // this might cause an error if we change the velocity
        }

        
        Speed = Math.Min(Math.Max(-1f, Speed), 1f);
        transform.Translate(0f, Speed, 0f);
        
        
        // if (Speed >= 10)
        // {
        //     Speed == 10;
        // }

        //if (Input.GetKey(KeyCode.A))
        //{
        //    Hspeed += 0.1f * Time.deltaTime;
        //    transform.Translate(Hspeed, 0f, 0f);
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    Hspeed -= 0.5f * Time.deltaTime;
        //    transform.Translate(Hspeed, 0f, 0f);
        //}

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -30f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, 30f * Time.deltaTime);
        }
    }
    //eu sou foda
}