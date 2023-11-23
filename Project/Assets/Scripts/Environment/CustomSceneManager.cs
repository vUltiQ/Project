using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomSceneManager : MonoBehaviour
{
    // Function to start the "Project" scene
    public void StartGame()
    {
        SceneManager.LoadScene("Project");
    }

    public void CodeRepo()
    {
        Application.OpenURL("https://github.com/vUltiQ/Project");
    }
}
