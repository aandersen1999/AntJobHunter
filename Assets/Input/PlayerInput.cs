//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Input/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""MainGame"",
            ""id"": ""010e37f0-a2e8-43e5-a756-32efcbb478ae"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""dffd92ef-a227-453e-a718-e815ebe3e537"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""6de23797-5cfd-4806-b69f-8fbc2a36e74b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""4c44a1d2-924e-4473-99ca-65162dae0c05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dig"",
                    ""type"": ""Button"",
                    ""id"": ""12d75b14-a620-4752-a14c-77bad26993cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1316bdc1-c42c-43f0-8fa1-00054dd6a5fe"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""342a8fa0-8c4f-4813-acde-ae39302dd3c7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d6d7efeb-3a60-46cf-8e51-e3851ade058e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""24955637-c001-4ba1-bd2a-1b6784f46c04"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ed9ec2ed-30bf-4133-ba40-e6fe1b12c265"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""997625c7-85fd-43e2-b23c-e8ae13998d7a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""37d1fcd9-8266-4c9b-8abd-d6e3e6ed7c0d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b70d5918-9fee-42b8-9859-4de4a79ed8a9"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dig"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        }
    ]
}");
        // MainGame
        m_MainGame = asset.FindActionMap("MainGame", throwIfNotFound: true);
        m_MainGame_Interact = m_MainGame.FindAction("Interact", throwIfNotFound: true);
        m_MainGame_Move = m_MainGame.FindAction("Move", throwIfNotFound: true);
        m_MainGame_Jump = m_MainGame.FindAction("Jump", throwIfNotFound: true);
        m_MainGame_Dig = m_MainGame.FindAction("Dig", throwIfNotFound: true);
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

    // MainGame
    private readonly InputActionMap m_MainGame;
    private IMainGameActions m_MainGameActionsCallbackInterface;
    private readonly InputAction m_MainGame_Interact;
    private readonly InputAction m_MainGame_Move;
    private readonly InputAction m_MainGame_Jump;
    private readonly InputAction m_MainGame_Dig;
    public struct MainGameActions
    {
        private @PlayerInput m_Wrapper;
        public MainGameActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_MainGame_Interact;
        public InputAction @Move => m_Wrapper.m_MainGame_Move;
        public InputAction @Jump => m_Wrapper.m_MainGame_Jump;
        public InputAction @Dig => m_Wrapper.m_MainGame_Dig;
        public InputActionMap Get() { return m_Wrapper.m_MainGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainGameActions set) { return set.Get(); }
        public void SetCallbacks(IMainGameActions instance)
        {
            if (m_Wrapper.m_MainGameActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_MainGameActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_MainGameActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_MainGameActionsCallbackInterface.OnInteract;
                @Move.started -= m_Wrapper.m_MainGameActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MainGameActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MainGameActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_MainGameActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MainGameActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MainGameActionsCallbackInterface.OnJump;
                @Dig.started -= m_Wrapper.m_MainGameActionsCallbackInterface.OnDig;
                @Dig.performed -= m_Wrapper.m_MainGameActionsCallbackInterface.OnDig;
                @Dig.canceled -= m_Wrapper.m_MainGameActionsCallbackInterface.OnDig;
            }
            m_Wrapper.m_MainGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Dig.started += instance.OnDig;
                @Dig.performed += instance.OnDig;
                @Dig.canceled += instance.OnDig;
            }
        }
    }
    public MainGameActions @MainGame => new MainGameActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IMainGameActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDig(InputAction.CallbackContext context);
    }
}