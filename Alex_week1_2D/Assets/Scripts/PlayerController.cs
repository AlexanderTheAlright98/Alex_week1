using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 9f;
    private float horizontalMovement;
    private bool gameOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        transform.Translate(moveSpeed * Time.deltaTime * horizontalMovement, 0, 0);


        if(horizontalMovement < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }

        if(transform.position.y < -29.5f)
        {
            gameOver = true;
        }
        
        if(gameOver)
        {
            Destroy(gameObject);
            Debug.Log("Your Quest is Over!!");            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
