using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3f); // Move the enemy downwards at a speed of 3 units per second

        if(transform.position.y < -6.5f)
        {
            Destroy(this.gameObject); // Destroy the enemy if it goes below the screen (y < -6.5)
        }
        else if (transform.position.x < -9f || transform.position.x > 9f)
        {
            Destroy(this.gameObject); // Destroy the enemy if it goes out of the horizontal bounds (x < -9 or x > 9)
            // This ensures that enemies do not stay in the scene indefinitely
        }
    }
}
