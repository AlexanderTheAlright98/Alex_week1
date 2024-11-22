using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 9f;
    public float horizontalMovement;
    public bool gameOverBoy = false;

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

        if(transform.position.y < -20)
        {
            gameOverBoy = true;
        }
        
        if(gameOverBoy)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER BABY!");
        }
    }

}
