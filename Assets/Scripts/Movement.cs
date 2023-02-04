using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private int speed = 10;
    private bool Up;
    private bool Down;
    private bool Left;
    private bool Right;
    private bool W;
    private bool A;
    private bool S;
    private bool D;


    public void Move()
    {
        int x = 0;
        int y = 0;

        if (A || Left)
        {
            x = -1;
        } else if (D || Right)
        {
            x = 1;
        }

        if (S || Down)
        {
            y = -1;
        }
        else if (W || Up)
        {
            y = 1;
        }


        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(x, y, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;

        transform.position += tempVect;

    }
    public void Keys()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Up = true;
        } else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Up = false;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Down = true;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Down = false;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Right = true;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Right = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Left = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Left = false;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            A = true;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            A = false;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            W = true;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            W = false;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            A = true;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            S = false;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            D = true;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            D = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Keys();
        Move();

    }
}
