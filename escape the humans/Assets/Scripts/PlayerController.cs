using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float jumpForce;
	
	
	bool isGrounded = false; 
	public Transform isGroundedChecker; 
	public float checkGroundRadius; 
	public LayerMask groundLayer;
	
	
	private Rigidbody2D rb;
	
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		Move();
		Jump();
		CheckIfGrounded();
    }
	
	void Move() { 
		/*float x = Input.GetAxisRaw("Horizontal"); 
		float moveBy = x * speed; 
		rb.velocity = new Vector2(moveBy, rb.velocity.y); */
		
		Vector3 horizontal = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, 0.0f);
		transform.position = transform.position + horizontal * speed * Time.deltaTime;
	}
	
	void Jump() { 
		if (Input.GetKeyDown(KeyCode.Space) && isGrounded) { 
			rb.velocity = new Vector2(rb.velocity.x, jumpForce); 
		} 
	}
	
	void CheckIfGrounded() { 
		Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer); 
		if (collider != null) { 
			isGrounded = true; 
		} else { 
			isGrounded = false; 
		} 
	}
}
