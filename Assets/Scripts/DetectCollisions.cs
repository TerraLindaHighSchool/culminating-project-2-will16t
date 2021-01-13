using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private object gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            other.GetComponent<PlayerController>().speed = 0;
            gameObject.GetComponent<MoveForward>().speed = 0;
            gameManager.GameOver();
            Time.timeScale = 0;
        }

        else
        {
            Destroy(gameObject);
        }

    }
}
