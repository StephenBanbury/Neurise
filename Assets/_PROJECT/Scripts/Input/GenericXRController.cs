// GENERATED AUTOMATICALLY FROM 'Assets/_PROJECT/Scripts/Input/GenericXRController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GenericXRController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GenericXRController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GenericXRController"",
    ""maps"": [
        {
            ""name"": ""LeftController"",
            ""id"": ""9b8d880f-a206-4000-8928-5ac9780acdfc"",
            ""actions"": [
                {
                    ""name"": ""Grip"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7b9601a0-6c4b-4315-8f14-398e91404275"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trigger"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5dfac093-0898-4111-a677-fd618e4565cb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f1fcacf4-a006-4c0c-adf5-fa9f8a34ec02"",
                    ""path"": ""<XRController>{LeftHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0cf6203-aec8-4e1f-bcf3-5dc05fa3b50c"",
                    ""path"": ""<XRController>{LeftHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RightController"",
            ""id"": ""d8d4baa4-4c0f-46bf-969e-326738472f1d"",
            ""actions"": [
                {
                    ""name"": ""Grip"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c5f324f0-ebb4-4cbc-80c9-f7486ac7eb37"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trigger"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e36724ea-8604-4934-8b19-4b0554db488b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2f89b95b-f507-4532-8998-7ccfaf108e76"",
                    ""path"": ""<XRController>{RightHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c93145ea-ab2b-4aec-aab4-77a279153818"",
                    ""path"": ""<XRController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // LeftController
        m_LeftController = asset.FindActionMap("LeftController", throwIfNotFound: true);
        m_LeftController_Grip = m_LeftController.FindAction("Grip", throwIfNotFound: true);
        m_LeftController_Trigger = m_LeftController.FindAction("Trigger", throwIfNotFound: true);
        // RightController
        m_RightController = asset.FindActionMap("RightController", throwIfNotFound: true);
        m_RightController_Grip = m_RightController.FindAction("Grip", throwIfNotFound: true);
        m_RightController_Trigger = m_RightController.FindAction("Trigger", throwIfNotFound: true);
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

    // LeftController
    private readonly InputActionMap m_LeftController;
    private ILeftControllerActions m_LeftControllerActionsCallbackInterface;
    private readonly InputAction m_LeftController_Grip;
    private readonly InputAction m_LeftController_Trigger;
    public struct LeftControllerActions
    {
        private @GenericXRController m_Wrapper;
        public LeftControllerActions(@GenericXRController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grip => m_Wrapper.m_LeftController_Grip;
        public InputAction @Trigger => m_Wrapper.m_LeftController_Trigger;
        public InputActionMap Get() { return m_Wrapper.m_LeftController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftControllerActions set) { return set.Get(); }
        public void SetCallbacks(ILeftControllerActions instance)
        {
            if (m_Wrapper.m_LeftControllerActionsCallbackInterface != null)
            {
                @Grip.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnGrip;
                @Grip.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnGrip;
                @Grip.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnGrip;
                @Trigger.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrigger;
                @Trigger.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrigger;
                @Trigger.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrigger;
            }
            m_Wrapper.m_LeftControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grip.started += instance.OnGrip;
                @Grip.performed += instance.OnGrip;
                @Grip.canceled += instance.OnGrip;
                @Trigger.started += instance.OnTrigger;
                @Trigger.performed += instance.OnTrigger;
                @Trigger.canceled += instance.OnTrigger;
            }
        }
    }
    public LeftControllerActions @LeftController => new LeftControllerActions(this);

    // RightController
    private readonly InputActionMap m_RightController;
    private IRightControllerActions m_RightControllerActionsCallbackInterface;
    private readonly InputAction m_RightController_Grip;
    private readonly InputAction m_RightController_Trigger;
    public struct RightControllerActions
    {
        private @GenericXRController m_Wrapper;
        public RightControllerActions(@GenericXRController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grip => m_Wrapper.m_RightController_Grip;
        public InputAction @Trigger => m_Wrapper.m_RightController_Trigger;
        public InputActionMap Get() { return m_Wrapper.m_RightController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightControllerActions set) { return set.Get(); }
        public void SetCallbacks(IRightControllerActions instance)
        {
            if (m_Wrapper.m_RightControllerActionsCallbackInterface != null)
            {
                @Grip.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnGrip;
                @Grip.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnGrip;
                @Grip.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnGrip;
                @Trigger.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrigger;
                @Trigger.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrigger;
                @Trigger.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrigger;
            }
            m_Wrapper.m_RightControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grip.started += instance.OnGrip;
                @Grip.performed += instance.OnGrip;
                @Grip.canceled += instance.OnGrip;
                @Trigger.started += instance.OnTrigger;
                @Trigger.performed += instance.OnTrigger;
                @Trigger.canceled += instance.OnTrigger;
            }
        }
    }
    public RightControllerActions @RightController => new RightControllerActions(this);
    public interface ILeftControllerActions
    {
        void OnGrip(InputAction.CallbackContext context);
        void OnTrigger(InputAction.CallbackContext context);
    }
    public interface IRightControllerActions
    {
        void OnGrip(InputAction.CallbackContext context);
        void OnTrigger(InputAction.CallbackContext context);
    }
}
