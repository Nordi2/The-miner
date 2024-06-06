using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBootstrap : MonoBehaviour
{
    private const string SceneName = "Main";

    private void Awake()
    {
        StartCoroutine(LoadScene(SceneName));
        DontDestroyOnLoad(this);
    }
    private IEnumerator LoadScene(string SceneName) 
    {
        if (SceneManager.GetActiveScene().name == SceneName)
        {
            yield break;
        }
        AsyncOperation waitNextScene = SceneManager.LoadSceneAsync(SceneName);
        while (!waitNextScene.isDone)
        {
            yield return null;
        }
    }
}
