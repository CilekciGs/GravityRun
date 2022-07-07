using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float force = 10000f;
    public float gravityScale = 20;
    public float respawnTimer = 2f;

    public void Dead()
    {
        force = 0f;
        gravityScale = 0f;
        Invoke("Restart", respawnTimer);
    }

        public void Win()
    {
        force = 0f;
        gravityScale = 0f;
        Invoke("GoToMenu", respawnTimer);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

