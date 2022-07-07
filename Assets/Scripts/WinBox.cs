using UnityEngine;

public class WinBox : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.name == "Player")
        {
            gameManager.Win();
        }
    }
}