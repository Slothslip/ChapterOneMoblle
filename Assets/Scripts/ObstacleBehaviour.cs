using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleBehaviour : MonoBehaviour
{
    [Tooltip("How long to wait before restarting the game")]
    public float waitTime = 2.0f;


    private void OnCollisionEnter(Collision collision)
    {
        // First check if we collided with the player 
        if (collision.gameObject.GetComponent<PlayerBehaviour>())
        {
            // destroy the player
            Destroy(collision.gameObject);

            // Call the function ResetGame after wait  time has passed
            Invoke("ResetGame", waitTime);
        }
    }

    private void ResetGame()
    {
        // Get the current level's name
        string sceneName = SceneManager.GetActiveScene().name;

        // restarts the current level
        SceneManager.LoadScene(sceneName);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
