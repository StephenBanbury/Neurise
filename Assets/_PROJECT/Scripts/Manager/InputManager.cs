using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private GenericXRController _inputActions;
    [SerializeField] private Vector2 _pressedAndReleasedThreshold = new Vector2(0.1f, 0.9f);

    /*
     Left Hand Grip Events
    */
    public static UnityEvent OnGripLeftHandPressed = new UnityEvent();
    public static UnityEvent<float> OnGripLeftHandUpdated = new UnityEvent<float>();
    public static UnityEvent OnGripLeftHandReleased = new UnityEvent();

    /*
     Left Hand Trigger Events
    */
    public static UnityEvent OnTriggerLeftHandPressed = new UnityEvent();
    public static UnityEvent<float> OnTriggerLeftHandUpdated = new UnityEvent<float>();
    public static UnityEvent OnTriggerLeftHandReleased = new UnityEvent();

    /*
     Right Hand Grip Events
    */
    public static UnityEvent OnGripRightHandPressed = new UnityEvent();
    public static UnityEvent<float> OnGripRightHandUpdated = new UnityEvent<float>();
    public static UnityEvent OnGripRightHandReleased = new UnityEvent();

    /*
     Right Hand Trigger Events
    */
    public static UnityEvent OnTriggerRightHandPressed = new UnityEvent();
    public static UnityEvent<float> OnTriggerRightHandUpdated = new UnityEvent<float>();
    public static UnityEvent OnTriggerRightHandReleased = new UnityEvent();

    private float _leftHandGripValue;
    private float _rightHandGripValue;

    private float _leftHandTriggerValue;
    private float _rightHandTriggerValue;

    // pressed bools
    private bool _leftHandGripPressed;
    private bool _rightHandGripPressed;

    private bool _leftHandTriggerPressed;
    private bool _rightHandTriggerPressed;


    /*
     Init
    */
    void Awake() 
    {
        _inputActions = new GenericXRController();
        _inputActions.RightController.Grip.performed += PressGripRight;
        _inputActions.RightController.Trigger.performed += PressTriggerRight;
        _inputActions.LeftController.Grip.performed += PressGripLeft;
        _inputActions.LeftController.Trigger.performed += PressTriggerLeft;
        _inputActions.Enable();
    }

    private void OnEnable()
    {
        _inputActions.Enable();
    }
    private void OnDispose()
    {
        _inputActions.Disable();
    }
    private void OnDestroy()
    {
        _inputActions.Dispose();
    }

    /*
     Input Handlers
    */

    private void PressGripRight(InputAction.CallbackContext obj)
    {
        //Debug.Log("PressGripRight");
        _rightHandGripValue = obj.ReadValue<float>();
        if (_rightHandGripValue > _pressedAndReleasedThreshold.x && _rightHandGripValue < _pressedAndReleasedThreshold.y)
        {
            OnGripRightHandUpdated.Invoke(_rightHandGripValue);
            _rightHandGripPressed = false;
            Debug.Log($"right hand grip value {_rightHandGripValue}");
        }
        if (!_rightHandGripPressed && _rightHandGripValue > _pressedAndReleasedThreshold.y)
        {
            OnGripRightHandPressed.Invoke();
            _rightHandGripPressed = true;
            Debug.Log($"right hand grip pressed");
        }
        if (_rightHandGripPressed && _rightHandGripValue < _pressedAndReleasedThreshold.x)
        {
            OnGripRightHandReleased.Invoke();
            _rightHandGripPressed = false;
            Debug.Log($"right hand grip released");
        }
    }
    private void PressGripLeft(InputAction.CallbackContext obj)
    {
        //Debug.Log("PressGripLeft");
        _leftHandGripValue = obj.ReadValue<float>();
        if (_leftHandGripValue > _pressedAndReleasedThreshold.x && _leftHandGripValue < _pressedAndReleasedThreshold.y)
        {
            OnGripLeftHandUpdated.Invoke(_leftHandGripValue);
            _leftHandGripPressed = false;
            Debug.Log($"left hand grip value {_leftHandGripValue}");
        }
        if (!_leftHandGripPressed && _leftHandGripValue > _pressedAndReleasedThreshold.y)
        {
            OnGripLeftHandPressed.Invoke();
            _leftHandGripPressed = true;
            Debug.Log($"left hand grip pressed");
        }
        if (_leftHandGripPressed && _leftHandGripValue < _pressedAndReleasedThreshold.x)
        {
            OnGripLeftHandReleased.Invoke();
            _leftHandGripPressed = false;
            Debug.Log($"left hand grip released");
        }
    }
    private void PressTriggerRight(InputAction.CallbackContext obj)
    {
        //Debug.Log("PressTriggerRight");
        _rightHandTriggerValue = obj.ReadValue<float>();
        if (_rightHandTriggerValue > _pressedAndReleasedThreshold.x && _rightHandTriggerValue < _pressedAndReleasedThreshold.y)
        {
            OnTriggerRightHandUpdated.Invoke(_rightHandTriggerValue);
            _rightHandTriggerPressed = false;
            Debug.Log($"right hand trigger value {_rightHandTriggerValue}");
        }
        if (!_rightHandTriggerPressed && _rightHandTriggerValue > _pressedAndReleasedThreshold.y)
        {
            OnTriggerRightHandPressed.Invoke();
            _rightHandTriggerPressed = true;
            Debug.Log($"right hand trigger pressed");
        }
        if (_rightHandTriggerPressed && _rightHandTriggerValue < _pressedAndReleasedThreshold.x)
        {
            OnTriggerRightHandReleased.Invoke();
            _rightHandTriggerPressed = false;
            Debug.Log($"right hand trigger released");
        }
    }
    private void PressTriggerLeft(InputAction.CallbackContext obj)
    {
        //Debug.Log("PressTriggerLeft");
        _leftHandTriggerValue = obj.ReadValue<float>();
        if (_leftHandTriggerValue > _pressedAndReleasedThreshold.x && _leftHandTriggerValue < _pressedAndReleasedThreshold.y)
        {
            OnTriggerLeftHandUpdated.Invoke(_leftHandTriggerValue);
            _leftHandTriggerPressed = false;
            Debug.Log($"left hand trigger value {_leftHandTriggerValue}");
        }
        if (!_leftHandTriggerPressed && _leftHandTriggerValue > _pressedAndReleasedThreshold.y)
        {
            OnTriggerLeftHandPressed.Invoke();
            _leftHandTriggerPressed = true;
            Debug.Log($"left hand trigger pressed");
        }
        if (_leftHandTriggerPressed && _leftHandTriggerValue < _pressedAndReleasedThreshold.x)
        {
            OnTriggerLeftHandReleased.Invoke();
            _leftHandTriggerPressed = false;
            Debug.Log($"left hand trigger released");
        }
    }
}
