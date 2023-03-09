using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class StateDirector : AbstractDirector
{
    private AbstractState _currentState;
    private Dictionary<Type, AbstractState> _stateDictionary = new Dictionary<Type, AbstractState>();
    public override void Initialize()
    {
        base.Initialize();  
        _currentState = StateCreate<AppStartState>();
        StateCreate<MainMenuState>();
        StateCreate<GlobalMapState>();
        StateCreate<BoneRitualCaveState>();
    }
    public T StateCreate<T>() where T : AbstractState, new()
    {
        T tempState = new T();
        Type tempType = typeof(T);
        tempState.Initialize();
        _stateDictionary.TryAdd(tempType, tempState);
        return tempState;
        //Debug.Log($"{tempBool} {tempType}");
    }
    public T StateGet<T>() where T : AbstractState
    {
        Type tempType = typeof(T);
        if (_stateDictionary.TryGetValue(tempType, out AbstractState tempState))
        {
            return tempState as T;
        }
        else
        {
            return null;
        }
    }
    public void SwitchState<T>() where T : AbstractState
    {
        T tempState = StateGet<T>();
        _currentState.StateExit();
        tempState.StateEnter();
        _currentState = tempState;
        //AppStatic.eventDirector.buttonEvents.OnButtonPressedAction(this, new EventArgs());
    }
}
