using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScreen : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(GlobalConstants.GAME_SCENE);
    }
}