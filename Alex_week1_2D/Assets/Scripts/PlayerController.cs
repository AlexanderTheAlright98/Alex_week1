using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 7.5f;
    public float jumpHeight = 4;
    private float horizontalMovement;
    private bool gameOver = false;
    private bool isJumpPressed = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            isJumpPressed = true;
        }

        horizontalMovement = Input.GetAxis("Horizontal");

        transform.Translate(moveSpeed * Time.deltaTime * horizontalMovement, 0, 0);

        if(transform.position.y < -40.5f)
        {
            gameOver = true;
        }
        
        if(gameOver)
        {
            Destroy(gameObject);
            Debug.Log("Your Quest is Over!!");            
            SceneManager.LoadScene(0);
        }
    }
    private void FixedUpdate()
    {
        if (isJumpPressed)
        {
            transform.Translate(0, jumpHeight * Time.deltaTime, 0);
            isJumpPressed=false;
        }
    }

}
