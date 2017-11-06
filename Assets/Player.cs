using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float movementSpeed = 10.0f;

    private float movement = 0.0f;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
    }
	
    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}
