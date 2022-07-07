using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }

    public void LoadLevel01()
    {
        SceneManager.LoadScene("Level01");
    }

    public void LoadLevel02()
    {
        SceneManager.LoadScene("Level02");
    }

    public void LoadLevel03()
    {
        SceneManager.LoadScene("Level03");
    }

    public void LoadLevel01x()
    {
        SceneManager.LoadScene("Level01x");
    }

    public void LoadLevel02x()
    {
        SceneManager.LoadScene("Level02x");
    }

    public void LoadLevel03x()
    {
        SceneManager.LoadScene("Level03x");
    }
}
