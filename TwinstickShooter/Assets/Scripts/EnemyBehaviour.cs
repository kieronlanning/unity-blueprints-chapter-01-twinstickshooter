using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

    // How many times should I be hit before I die?
    public int health = 2;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Uncomment this line to check for collision.
        //Debug.Log("Hit: " + collision.gameObject.name);

        // This line looks for "laser" in the names of
        // anything collided.
        if (collision.gameObject.name.Contains("laser"))
        {
            var laser = (LaserBehaviour) collision.gameObject.GetComponent("LaserBehaviour");
            health -= laser.damage;

            // Destroy the laser.
            Destroy(collision.gameObject);
        }

        if (health <= 0)
            Destroy(this.gameObject);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
