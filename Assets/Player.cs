using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpTime = 20;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


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
        rb.AddForce(new Vector2(0, jumpTime));
        print($"스페이스 바 누른 시간: {jumpTime}");
    }
}
