using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBuilder : MonoBehaviour
{

    public GameObject Cube;

    // Start is called before the first frame update
    void Start()
    {
        BuildTheBackWall();
        BuildTheLeftWall();
        BuildTheRightWall();
        BuildTheFloor();
        BuildTheRoof();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BuildTheBackWall()
    {
        for ( int Xpos = 0; Xpos < 20; Xpos++)
        {
            for ( int Ypos = 0; Ypos < 10; Ypos++)
            {
                Instantiate(Cube, new Vector3(Xpos * 1 - 10, Ypos, 10), Quaternion.identity);
            }
        }
    }

    void BuildTheLeftWall()
    {
        for (int Ypos = 0; Ypos < 10; Ypos++)
        {
            for (int Zpos = 0; Zpos < 10; Zpos++)
            {
                Instantiate(Cube, new Vector3(-10, Ypos, Zpos), Quaternion.identity);
            }
        }
    }

    void BuildTheRightWall()
    {
        for (int Ypos = 0; Ypos < 10; Ypos++)
        {
            for (int Zpos = 0; Zpos < 10; Zpos++)
            {
                Instantiate(Cube, new Vector3(9, Ypos, Zpos), Quaternion.identity);
            }
        }
    }

    void BuildTheFloor()
    {
        for (int Xpos = 0; Xpos < 20; Xpos++)
        {
            for (int Zpos = 0; Zpos < 10; Zpos++)
            {
                Instantiate(Cube, new Vector3(Xpos * 1 - 10, -1, Zpos), Quaternion.identity);
            }
        }
    }

    void BuildTheRoof()
    {
        for (int Xpos = 0; Xpos < 20; Xpos++)
        {
            for (int Zpos = 0; Zpos < 10; Zpos++)
            {
                Instantiate(Cube, new Vector3(Xpos * 1 - 10, 9, Zpos), Quaternion.identity);
            }
        }
    }
}