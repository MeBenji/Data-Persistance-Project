#if UNITY_EDITOR
using UnityEditor;
#endif

using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    public TMP_InputField playerNameInputField;

    void Start()
    {
        bestScoreText.text = $"Best Score : {MenuManager.Instance.highScoreName} : {MenuManager.Instance.highScore}";
    }

    public void StartNew()
    {
        MenuManager.Instance.playerName = playerNameInputField.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        MenuManager.Instance.SaveHighScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
