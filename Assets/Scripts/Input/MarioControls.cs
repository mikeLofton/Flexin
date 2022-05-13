// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/MarioControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MarioControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MarioControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MarioControls"",
    ""maps"": [
        {
            ""name"": ""Mario"",
            ""id"": ""62f3094f-72c9-4d14-ab14-de6c089c906d"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""687171b2-982c-4dc4-9ced-5567ea7a5ce0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""41cde6e0-4bcb-4bc4-8401-fd8c1d1b3631"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mario
        m_Mario = asset.FindActionMap("Mario", throwIfNotFound: true);
        m_Mario_Movement = m_Mario.FindAction("Movement", throwIfNotFound: true);
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

    // Mario
    private readonly InputActionMap m_Mario;
    private IMarioActions m_MarioActionsCallbackInterface;
    private readonly InputAction m_Mario_Movement;
    public struct MarioActions
    {
        private @MarioControls m_Wrapper;
        public MarioActions(@MarioControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Mario_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Mario; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MarioActions set) { return set.Get(); }
        public void SetCallbacks(IMarioActions instance)
        {
            if (m_Wrapper.m_MarioActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MarioActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MarioActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MarioActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_MarioActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public MarioActions @Mario => new MarioActions(this);
    public interface IMarioActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
