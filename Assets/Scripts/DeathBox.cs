using UnityEngine;

public class DeathBox : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.name == "Player")
        {
            gameManager.Dead();
        }
    }
}