using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpTime = 20;


    void Update()
    {
        JumpTimeCheck();
    }

    private void JumpTimeCheck()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            jumpTime += 1;
            if (jumpTime > 1000)
            {
                Jump();
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Jump();
            jumpTime = 0;
        }
    }

    private void Jump()
    {
        switch (jumpTime)
        {
         
            default:
                break;
        }
    }
}
