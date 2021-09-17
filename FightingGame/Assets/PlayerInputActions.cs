//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.1.1
//     from Assets/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""701f685b-b760-4320-aa8b-f73ac0f8d074"",
            ""actions"": [
                {
                    ""name"": ""VectorMovement"",
                    ""type"": ""Value"",
                    ""id"": ""b78ddf31-edc5-4d93-a43d-9f954e33a714"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""5c5219fe-7c2b-4bdb-a7d8-c894d0ef71ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Value"",
                    ""id"": ""c5561f04-e95f-425e-8ee5-993f2c140f1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Walk(Left)"",
                    ""type"": ""Value"",
                    ""id"": ""fa26da47-e24e-4d04-9279-09a23b18dd80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Walk(Right)"",
                    ""type"": ""Value"",
                    ""id"": ""06b557f7-d2bc-4e10-8d74-469fa325663c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attack(A)"",
                    ""type"": ""Button"",
                    ""id"": ""205c071f-16d8-4b8d-8b56-fd7d4b66ba87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack(B)"",
                    ""type"": ""Button"",
                    ""id"": ""5745cf94-5aa2-4948-83ab-1cbc0a2395b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack(C)"",
                    ""type"": ""Button"",
                    ""id"": ""63c61ca1-41e2-47d6-90d3-fb0817aba359"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""1bc4f3d6-3e0c-4b4d-a2df-b978fd3d0e4d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VectorMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""ff99dac0-e459-49b1-8ec1-d25da2c5eac8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""VectorMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""884896d4-0157-4583-b561-29041199eb10"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""VectorMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""D-Pad"",
                    ""id"": ""9d7a18b9-ee21-4245-8d32-0a812b6ad06c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VectorMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6516f037-6552-45ca-bdd2-ffae1a5e37df"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""VectorMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""815532a7-815e-4586-bd19-00388b832bbd"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""VectorMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftAnalog"",
                    ""id"": ""04b82abd-a4b3-467c-bae1-62ff361916b4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VectorMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b3da7a4a-80ba-4168-8105-c0d36f52d4a4"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""VectorMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d803cb4f-a469-49b2-ba20-0e16e1c05453"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""VectorMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9ed3283d-33e5-4f4f-bde4-e589d24feede"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack(A)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3cb51b6-d2d9-4246-af2d-3aecd08d7582"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Attack(A)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c25f8823-89be-4b72-9a77-5a82885d5a50"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack(B)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cbf994bf-1f8f-4f28-ac5c-21c723fdb0a0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Attack(B)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""954c38f4-b716-42a8-9be1-b221d8dd80ad"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack(C)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8196402-9662-4bc3-8d69-c5e3b2c23bb6"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Attack(C)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""684ccbde-3a53-437c-aa7c-0b080abd25cd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Walk(Right)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5666f3f8-dbe5-4522-8cc5-ba467352a0f1"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Walk(Right)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0c69b8a-9cb1-4581-95c7-51eb5ff458d2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4f3833f-07c4-4738-888d-33ca0fcb7a54"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d81776a7-a5f4-4b99-a112-8488442f39b5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2da27e5b-cfd7-4216-b35c-f5796725603e"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fcb4d31c-9561-4a70-a439-7c816eb7c32b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Walk(Left)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16b95fec-1679-4c04-aefd-914e03024bd0"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Walk(Left)"",
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
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_VectorMovement = m_PlayerControls.FindAction("VectorMovement", throwIfNotFound: true);
        m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControls_Crouch = m_PlayerControls.FindAction("Crouch", throwIfNotFound: true);
        m_PlayerControls_WalkLeft = m_PlayerControls.FindAction("Walk(Left)", throwIfNotFound: true);
        m_PlayerControls_WalkRight = m_PlayerControls.FindAction("Walk(Right)", throwIfNotFound: true);
        m_PlayerControls_AttackA = m_PlayerControls.FindAction("Attack(A)", throwIfNotFound: true);
        m_PlayerControls_AttackB = m_PlayerControls.FindAction("Attack(B)", throwIfNotFound: true);
        m_PlayerControls_AttackC = m_PlayerControls.FindAction("Attack(C)", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_VectorMovement;
    private readonly InputAction m_PlayerControls_Jump;
    private readonly InputAction m_PlayerControls_Crouch;
    private readonly InputAction m_PlayerControls_WalkLeft;
    private readonly InputAction m_PlayerControls_WalkRight;
    private readonly InputAction m_PlayerControls_AttackA;
    private readonly InputAction m_PlayerControls_AttackB;
    private readonly InputAction m_PlayerControls_AttackC;
    public struct PlayerControlsActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerControlsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @VectorMovement => m_Wrapper.m_PlayerControls_VectorMovement;
        public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
        public InputAction @Crouch => m_Wrapper.m_PlayerControls_Crouch;
        public InputAction @WalkLeft => m_Wrapper.m_PlayerControls_WalkLeft;
        public InputAction @WalkRight => m_Wrapper.m_PlayerControls_WalkRight;
        public InputAction @AttackA => m_Wrapper.m_PlayerControls_AttackA;
        public InputAction @AttackB => m_Wrapper.m_PlayerControls_AttackB;
        public InputAction @AttackC => m_Wrapper.m_PlayerControls_AttackC;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @VectorMovement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnVectorMovement;
                @VectorMovement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnVectorMovement;
                @VectorMovement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnVectorMovement;
                @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouch;
                @WalkLeft.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnWalkLeft;
                @WalkLeft.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnWalkLeft;
                @WalkLeft.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnWalkLeft;
                @WalkRight.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnWalkRight;
                @WalkRight.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnWalkRight;
                @WalkRight.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnWalkRight;
                @AttackA.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackA;
                @AttackA.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackA;
                @AttackA.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackA;
                @AttackB.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackB;
                @AttackB.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackB;
                @AttackB.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackB;
                @AttackC.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackC;
                @AttackC.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackC;
                @AttackC.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackC;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @VectorMovement.started += instance.OnVectorMovement;
                @VectorMovement.performed += instance.OnVectorMovement;
                @VectorMovement.canceled += instance.OnVectorMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @WalkLeft.started += instance.OnWalkLeft;
                @WalkLeft.performed += instance.OnWalkLeft;
                @WalkLeft.canceled += instance.OnWalkLeft;
                @WalkRight.started += instance.OnWalkRight;
                @WalkRight.performed += instance.OnWalkRight;
                @WalkRight.canceled += instance.OnWalkRight;
                @AttackA.started += instance.OnAttackA;
                @AttackA.performed += instance.OnAttackA;
                @AttackA.canceled += instance.OnAttackA;
                @AttackB.started += instance.OnAttackB;
                @AttackB.performed += instance.OnAttackB;
                @AttackB.canceled += instance.OnAttackB;
                @AttackC.started += instance.OnAttackC;
                @AttackC.performed += instance.OnAttackC;
                @AttackC.canceled += instance.OnAttackC;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnVectorMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnWalkLeft(InputAction.CallbackContext context);
        void OnWalkRight(InputAction.CallbackContext context);
        void OnAttackA(InputAction.CallbackContext context);
        void OnAttackB(InputAction.CallbackContext context);
        void OnAttackC(InputAction.CallbackContext context);
    }
}
