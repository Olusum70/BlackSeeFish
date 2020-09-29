// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Catch"",
            ""id"": ""9809b5d2-4ea4-4221-9389-af9dfc09d84f"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""4d1c5adf-a8bd-43ab-983c-234a287cd841"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""35e586df-77b2-4c0f-b537-310f98369e8e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold(duration=0.2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Catch
        m_Catch = asset.FindActionMap("Catch", throwIfNotFound: true);
        m_Catch_Newaction = m_Catch.FindAction("New action", throwIfNotFound: true);
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

    // Catch
    private readonly InputActionMap m_Catch;
    private ICatchActions m_CatchActionsCallbackInterface;
    private readonly InputAction m_Catch_Newaction;
    public struct CatchActions
    {
        private @Controls m_Wrapper;
        public CatchActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Catch_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Catch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CatchActions set) { return set.Get(); }
        public void SetCallbacks(ICatchActions instance)
        {
            if (m_Wrapper.m_CatchActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_CatchActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_CatchActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_CatchActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_CatchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public CatchActions @Catch => new CatchActions(this);
    public interface ICatchActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
