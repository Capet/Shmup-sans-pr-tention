// GENERATED AUTOMATICALLY FROM 'Assets/Controles.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controles : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controles()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controles"",
    ""maps"": [
        {
            ""name"": ""Vaisseau"",
            ""id"": ""1b88a3ae-1476-4c15-861d-136c9f9c41e1"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""a0af6627-4283-4c20-912f-5658abf1c95a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Deplacement"",
                    ""type"": ""Value"",
                    ""id"": ""e19718c3-cf27-4ff1-9524-893bfd02567f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""a9d06a40-e8fe-4db5-bbe6-ae6c48eb971d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e29f45d6-1c88-49ff-9150-ba43b017512a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4f9f382-6854-407f-a696-054bf63f690e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""121a59af-53bc-4aa6-a672-9a3d9d8fb34e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bbdcd611-cc6e-4f8c-b3ab-8e8e6acd8c84"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b7e48bbd-aba4-446e-b449-58b7d4784c79"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d3a58d44-5c5d-49ee-9a17-f31c4a8e2395"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""124565ff-1621-4554-b636-966e4df755c8"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9c0d2a98-8d6b-4571-90bb-6e95b3f4731a"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Vaisseau
        m_Vaisseau = asset.FindActionMap("Vaisseau", throwIfNotFound: true);
        m_Vaisseau_Shoot = m_Vaisseau.FindAction("Shoot", throwIfNotFound: true);
        m_Vaisseau_Deplacement = m_Vaisseau.FindAction("Deplacement", throwIfNotFound: true);
        m_Vaisseau_Rotation = m_Vaisseau.FindAction("Rotation", throwIfNotFound: true);
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

    // Vaisseau
    private readonly InputActionMap m_Vaisseau;
    private IVaisseauActions m_VaisseauActionsCallbackInterface;
    private readonly InputAction m_Vaisseau_Shoot;
    private readonly InputAction m_Vaisseau_Deplacement;
    private readonly InputAction m_Vaisseau_Rotation;
    public struct VaisseauActions
    {
        private @Controles m_Wrapper;
        public VaisseauActions(@Controles wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Vaisseau_Shoot;
        public InputAction @Deplacement => m_Wrapper.m_Vaisseau_Deplacement;
        public InputAction @Rotation => m_Wrapper.m_Vaisseau_Rotation;
        public InputActionMap Get() { return m_Wrapper.m_Vaisseau; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VaisseauActions set) { return set.Get(); }
        public void SetCallbacks(IVaisseauActions instance)
        {
            if (m_Wrapper.m_VaisseauActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_VaisseauActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_VaisseauActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_VaisseauActionsCallbackInterface.OnShoot;
                @Deplacement.started -= m_Wrapper.m_VaisseauActionsCallbackInterface.OnDeplacement;
                @Deplacement.performed -= m_Wrapper.m_VaisseauActionsCallbackInterface.OnDeplacement;
                @Deplacement.canceled -= m_Wrapper.m_VaisseauActionsCallbackInterface.OnDeplacement;
                @Rotation.started -= m_Wrapper.m_VaisseauActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_VaisseauActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_VaisseauActionsCallbackInterface.OnRotation;
            }
            m_Wrapper.m_VaisseauActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Deplacement.started += instance.OnDeplacement;
                @Deplacement.performed += instance.OnDeplacement;
                @Deplacement.canceled += instance.OnDeplacement;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
            }
        }
    }
    public VaisseauActions @Vaisseau => new VaisseauActions(this);
    public interface IVaisseauActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnDeplacement(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
    }
}
