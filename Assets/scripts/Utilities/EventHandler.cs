using System;
using UnityEngine;

public static class EventHandler
{
   

    public static event Action BeforeSceneUnloadEvent;

    public static void CallBeforeSceneUnloadEvent()
    {
        BeforeSceneUnloadEvent?.Invoke( );
    }


    public static event Action AfterSceneloadEvent;

    public static void CallAfterSceneloadEvent()
    {
        AfterSceneloadEvent?.Invoke();
    }

   


   

    public static event Action<GameState> GameStateChangeEvent;

    public static void CallSGameStateChangeEvent(GameState gameState)
    {
        GameStateChangeEvent?.Invoke(gameState);
    }



}
