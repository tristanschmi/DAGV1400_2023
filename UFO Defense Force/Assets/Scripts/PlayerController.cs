using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private AudioSource blasterAudio;
    
    public float horizontalInput;

    public float speed;

    public float xRange;

    public Transform Blaster;

    public GameObject Bolt;

    public AudioClip blasterSound;

    public GameManager gameManager;

    void Start()
    {
        blasterAudio = GetComponent<AudioSource>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            Instantiate(Bolt, Blaster.transform.position, Bolt.transform.rotation);
            blasterAudio.PlayOneShot(blasterSound, 1.0f);
        }
        
    }

    
}
