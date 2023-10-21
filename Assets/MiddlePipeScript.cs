using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{
    public GameManagerScript gameManager;

    // There are many lifecycle methods in addition to Start() and Update()

    // Start is called before the first frame update
    void Start()
    {
        // looks for the first game object in the hierarchy with this tag
        gameManager = GameObject
            .FindGameObjectWithTag("GameManager")
            .GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // there are additional OnTrigger[] methods
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.playerScore++;
        gameManager.scoreText.text = gameManager.playerScore.ToString();
    }
}
