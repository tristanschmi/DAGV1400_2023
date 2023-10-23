using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private AudioSource explosionAudio;

    public ScoreManager scoreManager;

    public AudioClip explosion;

    public int scoreToGive;

    

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void Awake()
    {
        explosionAudio = GetComponent<AudioSource>();
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        
        scoreManager.IncreaseScore(scoreToGive);
        Destroy(gameObject);
        Destroy(other.gameObject);
        
    }
}
