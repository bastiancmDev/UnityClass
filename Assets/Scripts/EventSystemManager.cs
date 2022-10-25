#if UNITY_5_3_OR_NEWER
#define NOESIS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
#else

using System.Collections;
using System.Collections.Generic;
using System;

#endif



public class EventSystemManager: IDisposable
{
    private static EventSystemManager _instance;
    private SortedList<ActionType, Delegate> _actions;
    private SortedList<GuiActionType, Delegate> _GUIactions;
    private SortedList<LanguageAction, Delegate> _LanguageAction;

    private object _InterSceneData;
    public object InterSceneData { get => _InterSceneData; set => _InterSceneData = value; }


    public EventSystemManager()
    {
        _actions = new SortedList<ActionType, Delegate>();
        _GUIactions = new SortedList<GuiActionType, Delegate>();
        _LanguageAction = new SortedList<LanguageAction, Delegate>();
    }

    public void Dispose()
    {
        ClearActions();
       
    }

    public void ClearActions()
    {
        _actions.Clear();
        _GUIactions.Clear();
        _LanguageAction.Clear();
    }

    public static EventSystemManager Instance
    {
        get
        {
            if (_instance == null) _instance = new EventSystemManager();
            
            return _instance;
        }
    }

    public void destroy()
    {
        ClearActions();
        _instance = null;
        Dispose();
    }

    public void setAction(ActionType actionname, Delegate action)
    {
        if (_actions.ContainsKey(actionname))
        {
            _actions[actionname] = action;
            return;
        }
        _actions.Add(actionname, action);
    }
    public void setGUIAction(GuiActionType actionname, Delegate action)
    {
        foreach (KeyValuePair<GuiActionType, Delegate> KeyValue in _GUIactions)
        {
            if (KeyValue.Key == actionname)
            {
                _GUIactions[actionname] = action;
                return;
            }
        }

        _GUIactions.Add(actionname, action);

    }


    public object triggerAction(ActionType actionname,params object[] args)
    {
#if NOESIS
      
        if (_actions.ContainsKey(actionname))
        {
         
            Delegate trigger = _actions[actionname];

            if (trigger != null)
            {
              
               return trigger.DynamicInvoke(args);
            }
        }
#endif
        return null;
    }
    public object triggerGUIAction(GuiActionType actionname, params object[] args)
    {

        foreach(KeyValuePair<GuiActionType,Delegate> KeyValue in _GUIactions)
        {
            if(KeyValue.Key == actionname)
            {
             
                Delegate trigger = _GUIactions[actionname];

                if (trigger != null)
                {
                   
                    return trigger.DynamicInvoke(args);
                }
                else
                {
                    
                }
            }
        } 

        return null;


    }

    private delegate void LanguageChangedDelegate();

    private LanguageChangedDelegate OnLanguageChanged;
    
    public void setLanguageAction(Action action)
    {
        OnLanguageChanged += action.Invoke;
        
        // foreach (KeyValuePair<LanguageAction, Delegate> KeyValue in _LanguageAction)
        // {
        //     if (KeyValue.Key == actionname)
        //     {
        //         _LanguageAction[actionname] = action;
        //         return;
        //     }
        // }
        //
        // _LanguageAction.Add(actionname, action);

    }
    public void triggerLaunguageAction()
    {

        // foreach (KeyValuePair<LanguageAction, Delegate> KeyValue in _LanguageAction)
        // {
        //     if (KeyValue.Key == actionname)
        //     {
        //
        //         Delegate trigger = _LanguageAction[actionname];
        //
        //         if (trigger != null)
        //         {
        //             trigger.DynamicInvoke(args);
        //         }
        //     }
        // }
        
        OnLanguageChanged?.Invoke();
    }


    public void setFunc(ActionType actionname, Delegate action)
    {

        if (_actions.ContainsKey(actionname))
        {

            _actions[actionname] = action;
            return;
        }
        _actions.Add(actionname, action);
    }
}
