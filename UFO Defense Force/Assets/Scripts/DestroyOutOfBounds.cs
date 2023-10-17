using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
   
    public float topBounds = 150.0f;

    public float lowBounds = -150.0f;

    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

   

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowBounds)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
            gameManager.isGameOver = true;
        }
    }
}
