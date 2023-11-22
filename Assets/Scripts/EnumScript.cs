using UnityEngine;
using System.Collections;

public class EnumScript : MonoBehaviour 
{
    Rigidbody2D body;

    Direction myDirection;
    
    enum Direction {North, East, South, West};

    void Start () 
    {
        body = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();

        myDirection = Direction.North;
    }

    void Update()
    {
        ChangeDirection();

        if (myDirection == Direction.North)
        {
            Debug.Log("IM GOIN TO THE NORTH POLL!!!");
        }
        else if (myDirection == Direction.South)
        {
            body.velocity = new Vector3(0, -1, 0);
        }
        else if (myDirection == Direction.East)
        {
            Destroy(GameObject.FindWithTag("Circle"));
        }
        else if (myDirection == Direction.West)
        {
            Destroy(GameObject.FindWithTag("Square"));
        }


    }
    
    private void ChangeDirection ()
    {
        if(Input.GetKey(KeyCode.W))
            myDirection = Direction.North;
        else if(Input.GetKey(KeyCode.S))
            myDirection = Direction.South;
        else if(Input.GetKey(KeyCode.A))
            myDirection = Direction.West;
        else if(Input.GetKey(KeyCode.D))
            myDirection = Direction.East;    
    }
}