using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using Unity.VisualScripting;

public class EventDirector : AbstractDirector
{
    public static event Action OnEnterStateEventHandler;
    public static event Action OnExitStateEventHandler;
    public static event Action<object, EventArgs> OnButtonPressedEventHandler;
    public override void Initialize()
    {
        base.Initialize();
        OnButtonPressedEventHandler += OnButtonPressed;
    }
    public void OnStateEnterAction()
    {
        OnEnterStateEventHandler?.Invoke();
    }
    public void OnStateExitAction()
    {
        OnExitStateEventHandler?.Invoke();
    }
    //
    public void OnButtonPressedAction(object currentObject, EventArgs currentArguments)
    {
        OnButtonPressedEventHandler?.Invoke(currentObject, currentArguments);
    }
    public static void OnButtonPressed(object currentObject, EventArgs currentArguments)
    {
        //var tempButton = currentObject as UIButton;
        //AppStatic.sceneDirector.SceneLoad(tempButton.sceneNext);
    }
}
