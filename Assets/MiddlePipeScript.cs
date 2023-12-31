using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{
    public GameManagerScript gameManager;
    public SpaceshipScript spaceship;

    // There are many lifecycle methods in addition to Start() and Update()

    // Start is called before the first frame update
    void Start()
    {
        // looks for the first game object in the hierarchy with this tag
        gameManager = GameObject
            .FindGameObjectWithTag(nameof(GameManagerScript))
            .GetComponent<GameManagerScript>();

        spaceship = GameObject
            .FindGameObjectWithTag(nameof(SpaceshipScript))
            .GetComponent<SpaceshipScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // there are additional OnTrigger[] methods
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && spaceship.isAlive)
        {
            // TODO: More difficult obstacles yield more points
            gameManager.IncreaseScore(1);
        }
    }
}
