//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Controlls/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""MoveCube"",
            ""id"": ""479655c8-bb70-4835-a9f7-d8867b28ad57"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""2b7819ba-a661-4d42-a0ef-7ce54b9796d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""Button"",
                    ""id"": ""95f36a9c-5b77-49ae-878e-21e31deafadd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""55500885-836f-4849-bcff-d731d5f83497"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Y"",
                    ""id"": ""d2e741b1-7c36-457e-be75-419dec8bb7c0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press"",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7a1e3dea-f411-43ec-9af4-e9003de80740"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b4df2d15-b57a-42dc-a56f-f920a51786b5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""X"",
                    ""id"": ""3b028db3-f9c7-460f-b6b0-b1c84fe2b423"",
                    ""path"": ""1DAxis(whichSideWins=1)"",
                    ""interactions"": ""Press(pressPoint=1.401298E-45)"",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6faf3b12-4464-4f43-9ff1-48fc089f6a8f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""25fb2945-ed03-4135-b80e-49c85d61443c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""770bf221-cba7-43d6-b76c-0738a9990501"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MoveCube
        m_MoveCube = asset.FindActionMap("MoveCube", throwIfNotFound: true);
        m_MoveCube_Move = m_MoveCube.FindAction("Move", throwIfNotFound: true);
        m_MoveCube_MoveY = m_MoveCube.FindAction("MoveY", throwIfNotFound: true);
        m_MoveCube_Jump = m_MoveCube.FindAction("Jump", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // MoveCube
    private readonly InputActionMap m_MoveCube;
    private IMoveCubeActions m_MoveCubeActionsCallbackInterface;
    private readonly InputAction m_MoveCube_Move;
    private readonly InputAction m_MoveCube_MoveY;
    private readonly InputAction m_MoveCube_Jump;
    public struct MoveCubeActions
    {
        private @Controls m_Wrapper;
        public MoveCubeActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MoveCube_Move;
        public InputAction @MoveY => m_Wrapper.m_MoveCube_MoveY;
        public InputAction @Jump => m_Wrapper.m_MoveCube_Jump;
        public InputActionMap Get() { return m_Wrapper.m_MoveCube; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveCubeActions set) { return set.Get(); }
        public void SetCallbacks(IMoveCubeActions instance)
        {
            if (m_Wrapper.m_MoveCubeActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MoveCubeActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MoveCubeActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MoveCubeActionsCallbackInterface.OnMove;
                @MoveY.started -= m_Wrapper.m_MoveCubeActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_MoveCubeActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_MoveCubeActionsCallbackInterface.OnMoveY;
                @Jump.started -= m_Wrapper.m_MoveCubeActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MoveCubeActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MoveCubeActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_MoveCubeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public MoveCubeActions @MoveCube => new MoveCubeActions(this);
    public interface IMoveCubeActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
