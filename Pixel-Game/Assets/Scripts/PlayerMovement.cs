using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private Animator animator;
    private Vector2 movement;


    private void Update()
    {

        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    
    }

    private void FixedUpdate()
    {
        // Obracanie postaci w lewo lub prawo
        if (movement.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (movement.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        // Wykonanie ruchu
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);

    }
}