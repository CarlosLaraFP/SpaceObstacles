using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float levitationFactor;

    // Start is called before the first frame update
    void Start()
    {
        this.name = "Spaceship";
        levitationFactor = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.velocity = Vector2.up * levitationFactor;
        }
    }
}
