using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 TODO
make a hitbox for a single attack
 */
public class ClownF : MonoBehaviour
{
        string[] chain = { "5", "5", "5", "5", "5", "5", "5", "5", "5", "5" };//numpad notation, 5 is neutral
        int inputDir = 5;
        int inputBut = 0;//0 - none, 1234 - abcd respectively
        string state = "neutral";//neutral, attacking, recovery, blocking, down_blocking, rising, jumping, airborne, hit, grounded, jailed
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.Z))
        {
            inputBut = 1;
        }
        switch(inputBut)
        {
            case 1:
                    
                break;
        }
    }
}
