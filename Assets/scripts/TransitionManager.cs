using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : Singleton<TransitionManager>
{
    public string startScene;
    public CanvasGroup fadeCanvasGroup;
    public float fadeDuration;
    private bool isFade;
    private bool canTransition;

    private void OnEnable()
    {
        EventHandler.GameStateChangeEvent += OnGameStateChangeEvent;
    }

    private void OnDisable()
    {
        EventHandler.GameStateChangeEvent -= OnGameStateChangeEvent;
    }

    private void Start()
    {
        
      StartCoroutine(TransitionToScene(string.Empty, startScene));
       canTransition = true;
    }


    public void Transition(string from, string to)
    {
        if (!isFade && canTransition)
            StartCoroutine(TransitionToScene(from, to));
    }


    private IEnumerator TransitionToScene(string from, string to)
    {

        yield return Fade(1);
        if (from != string.Empty ) //执行卸载场景方法
        {
            EventHandler.CallBeforeSceneUnloadEvent();
           
            yield return SceneManager.UnloadSceneAsync(from);
        }

        yield return SceneManager.LoadSceneAsync(to, LoadSceneMode.Additive);

        Active();

        EventHandler.CallAfterSceneloadEvent();
        yield return Fade(0);

        //设置新场景为激活场景


    }

    private IEnumerator Fade(float targetAlpha)
    {
        isFade = true;

        fadeCanvasGroup.blocksRaycasts = true;

        float speed = Mathf.Abs(fadeCanvasGroup.alpha - targetAlpha) / fadeDuration;

        while (!Mathf.Approximately(fadeCanvasGroup.alpha, targetAlpha))
        {
            fadeCanvasGroup.alpha = Mathf.MoveTowards(fadeCanvasGroup.alpha, targetAlpha, speed * Time.deltaTime);
            yield return null;
        }

        fadeCanvasGroup.blocksRaycasts = false;
        isFade = false;
    }



    void Active()
    {
        Scene newScene = SceneManager.GetSceneAt(SceneManager.sceneCount - 1);
        SceneManager.SetActiveScene(newScene);
    }

    private void OnGameStateChangeEvent(GameState gameState)
    {
        canTransition = gameState == GameState.Gameplay; //对话时无法切换场景，因其状态为Pause
    }
}


