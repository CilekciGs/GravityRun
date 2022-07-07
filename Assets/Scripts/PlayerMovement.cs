using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public GameManager gameManager;

    public bool normalGravity = true;
     void FixedUpdate()
        {
            rb2d.velocity = (new Vector2(gameManager.force * Time.deltaTime, 0f));
        }
     void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (normalGravity == false){
                rb2d.gravityScale = gameManager.gravityScale;
                normalGravity = true;
            }
            else if (normalGravity == true){
                rb2d.gravityScale = gameManager.gravityScale * -1;
                normalGravity = false;
            }
        }

    }
}
