using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingEnemy : MonoBehaviour
{
	public float speed;
	
	private SpriteRenderer sr;
	private Vector2 direction;
	
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
		direction = Vector2.left;
    }

    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), new Vector2(transform.position.x, transform.position.y) + direction, speed * Time.deltaTime);
    }
	
	
	void OnCollisionEnter2D(Collision2D other)
    {
        if(!other.gameObject.CompareTag("Grass"))
		{
			transform.Rotate(0,180,0);
			transform.position = new Vector2(transform.position.x, transform.position.y);
			if(direction.Equals(Vector2.left))
			{
				direction = Vector2.right;
			}
			else
			{
				direction = Vector2.left;
			}
		}
		
		if(other.gameObject.CompareTag("Player"))
		{
			other.gameObject.SetActive(false);
		}
    }
}
