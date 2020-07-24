//// GENERATED AUTOMATICALLY FROM 'Assets/User Controls/InputActions.inputactions'

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.InputSystem;
//using UnityEngine.InputSystem.Utilities;

//public class @InputActions : IInputActionCollection, IDisposable
//{
//    public InputActionAsset asset { get; }
//    public @InputActions()
//    {
//        asset = InputActionAsset.FromJson(@"{
//    ""name"": ""InputActions"",
//    ""maps"": [
//        {
//            ""name"": ""Player"",
//            ""id"": ""f05cfa7b-83ad-4234-a946-2fac7b941008"",
//            ""actions"": [
//                {
//                    ""name"": ""Move"",
//                    ""type"": ""Value"",
//                    ""id"": ""6d492368-e6ba-4c41-baf4-58f6bfaefe62"",
//                    ""expectedControlType"": ""Vector2"",
//                    ""processors"": """",
//                    ""interactions"": """"
//                },
//                {
//                    ""name"": ""Look"",
//                    ""type"": ""Value"",
//                    ""id"": ""68f6ac2f-ce92-46fb-9aa1-c2dcd2aecffc"",
//                    ""expectedControlType"": ""Vector2"",
//                    ""processors"": """",
//                    ""interactions"": """"
//                },
//                {
//                    ""name"": ""Interact"",
//                    ""type"": ""PassThrough"",
//                    ""id"": ""460f1acb-bd07-4615-ad34-ceb3625b7387"",
//                    ""expectedControlType"": ""Button"",
//                    ""processors"": """",
//                    ""interactions"": """"
//                },
//                {
//                    ""name"": ""Float"",
//                    ""type"": ""PassThrough"",
//                    ""id"": ""059243fc-ca51-408d-9a97-835d425f4674"",
//                    ""expectedControlType"": ""Button"",
//                    ""processors"": """",
//                    ""interactions"": """"
//                }
//            ],
//            ""bindings"": [
//                {
//                    ""name"": """",
//                    ""id"": ""cdcbc396-0e1a-4483-bcfb-2c3190771f68"",
//                    ""path"": ""<Gamepad>/rightStick"",
//                    ""interactions"": """",
//                    ""processors"": ""NormalizeVector2,StickDeadzone(max=0.25)"",
//                    ""groups"": "";Gamepad"",
//                    ""action"": ""Look"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": false
//                },
//                {
//                    ""name"": """",
//                    ""id"": ""4b66ed76-0490-4402-9046-c7235b63419e"",
//                    ""path"": ""<Mouse>/delta"",
//                    ""interactions"": """",
//                    ""processors"": ""ScaleVector2(x=0.35,y=0.35)"",
//                    ""groups"": "";Keyboard&Mouse"",
//                    ""action"": ""Look"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": false
//                },
//                {
//                    ""name"": """",
//                    ""id"": ""74ec5a32-fe5d-4ada-8987-554b600c0167"",
//                    ""path"": ""<Gamepad>/buttonWest"",
//                    ""interactions"": ""Press"",
//                    ""processors"": """",
//                    ""groups"": "";Gamepad"",
//                    ""action"": ""Interact"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": false
//                },
//                {
//                    ""name"": """",
//                    ""id"": ""6a315d20-c043-414b-9247-70204e76b1f0"",
//                    ""path"": ""<Mouse>/rightButton"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": ""Keyboard&Mouse"",
//                    ""action"": ""Interact"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": false
//                },
//                {
//                    ""name"": ""WASD"",
//                    ""id"": ""94d59446-f86c-41a7-be27-d40a701be2d0"",
//                    ""path"": ""2DVector"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": """",
//                    ""action"": ""Move"",
//                    ""isComposite"": true,
//                    ""isPartOfComposite"": false
//                },
//                {
//                    ""name"": ""up"",
//                    ""id"": ""7d147262-da44-4cfe-bd07-3421663f12b7"",
//                    ""path"": ""<Keyboard>/w"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": ""Keyboard&Mouse"",
//                    ""action"": ""Move"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": true
//                },
//                {
//                    ""name"": ""down"",
//                    ""id"": ""29aa33a2-f92a-465c-9a1a-574aa9102ae3"",
//                    ""path"": ""<Keyboard>/s"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": ""Keyboard&Mouse"",
//                    ""action"": ""Move"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": true
//                },
//                {
//                    ""name"": ""left"",
//                    ""id"": ""48f9be8a-81f1-4e02-80c4-f4a494e680ba"",
//                    ""path"": ""<Keyboard>/a"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": ""Keyboard&Mouse"",
//                    ""action"": ""Move"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": true
//                },
//                {
//                    ""name"": ""right"",
//                    ""id"": ""c546dcbf-0e21-4cb1-94b8-4aa01234ac3f"",
//                    ""path"": ""<Keyboard>/d"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": ""Keyboard&Mouse"",
//                    ""action"": ""Move"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": true
//                },
//                {
//                    ""name"": """",
//                    ""id"": ""90f15516-b6a7-4613-9e74-ea405732123b"",
//                    ""path"": ""<Gamepad>/leftStick"",
//                    ""interactions"": """",
//                    ""processors"": ""NormalizeVector2"",
//                    ""groups"": ""Gamepad"",
//                    ""action"": ""Move"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": false
//                },
//                {
//                    ""name"": ""1D Axis"",
//                    ""id"": ""8c6ecaa3-c79a-401c-a9af-cfd4e50170a4"",
//                    ""path"": ""1DAxis"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": """",
//                    ""action"": ""Float"",
//                    ""isComposite"": true,
//                    ""isPartOfComposite"": false
//                },
//                {
//                    ""name"": ""negative"",
//                    ""id"": ""6b9f97ca-03c3-48cb-94e7-f7c7e8390360"",
//                    ""path"": ""<Keyboard>/leftShift"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": ""Keyboard&Mouse"",
//                    ""action"": ""Float"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": true
//                },
//                {
//                    ""name"": ""positive"",
//                    ""id"": ""534f02ae-2f60-432e-b88c-042b20b7ec16"",
//                    ""path"": ""<Keyboard>/space"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": ""Keyboard&Mouse"",
//                    ""action"": ""Float"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": true
//                },
//                {
//                    ""name"": ""1D Axis"",
//                    ""id"": ""dcca9fb2-b303-483a-854a-6df6da8af309"",
//                    ""path"": ""1DAxis"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": """",
//                    ""action"": ""Float"",
//                    ""isComposite"": true,
//                    ""isPartOfComposite"": false
//                },
//                {
//                    ""name"": ""negative"",
//                    ""id"": ""16fd9b76-132c-4520-94d8-eaeedf89e195"",
//                    ""path"": ""<Gamepad>/leftTrigger"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": ""Gamepad"",
//                    ""action"": ""Float"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": true
//                },
//                {
//                    ""name"": ""positive"",
//                    ""id"": ""7de23018-a5a0-4fd3-a6db-d455dc304038"",
//                    ""path"": ""<Gamepad>/rightTrigger"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": ""Gamepad"",
//                    ""action"": ""Float"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": true
//                }
//            ]
//        },
//        {
//            ""name"": ""UI"",
//            ""id"": ""644ec927-b7b0-427c-a500-4bd7cfb39ee8"",
//            ""actions"": [
//                {
//                    ""name"": ""Navigate"",
//                    ""type"": ""Value"",
//                    ""id"": ""8c6ee165-58a3-4620-8e3f-84b2188cbaa9"",
//                    ""expectedControlType"": ""Vector2"",
//                    ""processors"": """",
//                    ""interactions"": """"
//                },
//                {
//                    ""name"": ""Submit"",
//                    ""type"": ""Button"",
//                    ""id"": ""7ee58294-1c56-452b-b0d4-c8c065f70cec"",
//                    ""expectedControlType"": ""Button"",
//                    ""processors"": """",
//                    ""interactions"": """"
//                },
//                {
//                    ""name"": ""Cancel"",
//                    ""type"": ""Button"",
//                    ""id"": ""c7ecdafa-9254-4e73-bcb8-c63082b60840"",
//                    ""expectedControlType"": ""Button"",
//                    ""processors"": """",
//                    ""interactions"": """"
//                },
//                {
//                    ""name"": ""Point"",
//                    ""type"": ""Value"",
//                    ""id"": ""6d754209-5fc8-473d-bbd0-067e331a56a7"",
//                    ""expectedControlType"": ""Vector2"",
//                    ""processors"": """",
//                    ""interactions"": """"
//                },
//                {
//                    ""name"": ""Click"",
//                    ""type"": ""Button"",
//                    ""id"": ""f8c6eff9-6e89-4a32-b55e-5517f51d6f43"",
//                    ""expectedControlType"": ""Button"",
//                    ""processors"": """",
//                    ""interactions"": """"
//                }
//            ],
//            ""bindings"": [
//                {
//                    ""name"": """",
//                    ""id"": ""7a9df39b-f7a9-459b-ad79-1d7df99d1b9c"",
//                    ""path"": ""<Gamepad>/leftStick"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": "";Gamepad"",
//                    ""action"": ""Navigate"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": false
//                },
//                {
//                    ""name"": """",
//                    ""id"": ""fb9e8cd4-95f9-4dc5-b684-01dea17adc60"",
//                    ""path"": ""<Gamepad>/buttonSouth"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": "";Gamepad"",
//                    ""action"": ""Submit"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": false
//                },
//                {
//                    ""name"": """",
//                    ""id"": ""199a4619-a78e-4989-8a64-d8908c09571e"",
//                    ""path"": ""<Gamepad>/buttonEast"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": "";Gamepad"",
//                    ""action"": ""Cancel"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": false
//                },
//                {
//                    ""name"": """",
//                    ""id"": ""2b25f134-0396-41da-abe4-b0494dbf1f13"",
//                    ""path"": ""<Mouse>/position"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": "";Keyboard&Mouse"",
//                    ""action"": ""Point"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": false
//                },
//                {
//                    ""name"": """",
//                    ""id"": ""10b949b6-3d51-40e4-82a0-cfa43b641c3c"",
//                    ""path"": ""<Mouse>/leftButton"",
//                    ""interactions"": """",
//                    ""processors"": """",
//                    ""groups"": "";Keyboard&Mouse"",
//                    ""action"": ""Click"",
//                    ""isComposite"": false,
//                    ""isPartOfComposite"": false
//                }
//            ]
//        }
//    ],
//    ""controlSchemes"": [
//        {
//            ""name"": ""Keyboard&Mouse"",
//            ""bindingGroup"": ""Keyboard&Mouse"",
//            ""devices"": [
//                {
//                    ""devicePath"": ""<Keyboard>"",
//                    ""isOptional"": false,
//                    ""isOR"": false
//                },
//                {
//                    ""devicePath"": ""<Mouse>"",
//                    ""isOptional"": false,
//                    ""isOR"": false
//                }
//            ]
//        },
//        {
//            ""name"": ""Gamepad"",
//            ""bindingGroup"": ""Gamepad"",
//            ""devices"": [
//                {
//                    ""devicePath"": ""<Gamepad>"",
//                    ""isOptional"": false,
//                    ""isOR"": false
//                }
//            ]
//        }
//    ]
//}");
//        // Player
//        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
//        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
//        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
//        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
//        m_Player_Float = m_Player.FindAction("Float", throwIfNotFound: true);
//        // UI
//        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
//        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
//        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
//        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
//        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
//        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
//    }

//    public void Dispose()
//    {
//        UnityEngine.Object.Destroy(asset);
//    }

//    public InputBinding? bindingMask
//    {
//        get => asset.bindingMask;
//        set => asset.bindingMask = value;
//    }

//    public ReadOnlyArray<InputDevice>? devices
//    {
//        get => asset.devices;
//        set => asset.devices = value;
//    }

//    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

//    public bool Contains(InputAction action)
//    {
//        return asset.Contains(action);
//    }

//    public IEnumerator<InputAction> GetEnumerator()
//    {
//        return asset.GetEnumerator();
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return GetEnumerator();
//    }

//    public void Enable()
//    {
//        asset.Enable();
//    }

//    public void Disable()
//    {
//        asset.Disable();
//    }

//    // Player
//    private readonly InputActionMap m_Player;
//    private IPlayerActions m_PlayerActionsCallbackInterface;
//    private readonly InputAction m_Player_Move;
//    private readonly InputAction m_Player_Look;
//    private readonly InputAction m_Player_Interact;
//    private readonly InputAction m_Player_Float;
//    public struct PlayerActions
//    {
//        private @InputActions m_Wrapper;
//        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
//        public InputAction @Move => m_Wrapper.m_Player_Move;
//        public InputAction @Look => m_Wrapper.m_Player_Look;
//        public InputAction @Interact => m_Wrapper.m_Player_Interact;
//        public InputAction @Float => m_Wrapper.m_Player_Float;
//        public InputActionMap Get() { return m_Wrapper.m_Player; }
//        public void Enable() { Get().Enable(); }
//        public void Disable() { Get().Disable(); }
//        public bool enabled => Get().enabled;
//        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
//        public void SetCallbacks(IPlayerActions instance)
//        {
//            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
//            {
//                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
//                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
//                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
//                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
//                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
//                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
//                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
//                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
//                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
//                @Float.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFloat;
//                @Float.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFloat;
//                @Float.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFloat;
//            }
//            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
//            if (instance != null)
//            {
//                @Move.started += instance.OnMove;
//                @Move.performed += instance.OnMove;
//                @Move.canceled += instance.OnMove;
//                @Look.started += instance.OnLook;
//                @Look.performed += instance.OnLook;
//                @Look.canceled += instance.OnLook;
//                @Interact.started += instance.OnInteract;
//                @Interact.performed += instance.OnInteract;
//                @Interact.canceled += instance.OnInteract;
//                @Float.started += instance.OnFloat;
//                @Float.performed += instance.OnFloat;
//                @Float.canceled += instance.OnFloat;
//            }
//        }
//    }
//    public PlayerActions @Player => new PlayerActions(this);

//    // UI
//    private readonly InputActionMap m_UI;
//    private IUIActions m_UIActionsCallbackInterface;
//    private readonly InputAction m_UI_Navigate;
//    private readonly InputAction m_UI_Submit;
//    private readonly InputAction m_UI_Cancel;
//    private readonly InputAction m_UI_Point;
//    private readonly InputAction m_UI_Click;
//    public struct UIActions
//    {
//        private @InputActions m_Wrapper;
//        public UIActions(@InputActions wrapper) { m_Wrapper = wrapper; }
//        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
//        public InputAction @Submit => m_Wrapper.m_UI_Submit;
//        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
//        public InputAction @Point => m_Wrapper.m_UI_Point;
//        public InputAction @Click => m_Wrapper.m_UI_Click;
//        public InputActionMap Get() { return m_Wrapper.m_UI; }
//        public void Enable() { Get().Enable(); }
//        public void Disable() { Get().Disable(); }
//        public bool enabled => Get().enabled;
//        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
//        public void SetCallbacks(IUIActions instance)
//        {
//            if (m_Wrapper.m_UIActionsCallbackInterface != null)
//            {
//                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
//                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
//                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
//                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
//                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
//                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
//                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
//                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
//                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
//                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
//                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
//                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
//                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
//                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
//                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
//            }
//            m_Wrapper.m_UIActionsCallbackInterface = instance;
//            if (instance != null)
//            {
//                @Navigate.started += instance.OnNavigate;
//                @Navigate.performed += instance.OnNavigate;
//                @Navigate.canceled += instance.OnNavigate;
//                @Submit.started += instance.OnSubmit;
//                @Submit.performed += instance.OnSubmit;
//                @Submit.canceled += instance.OnSubmit;
//                @Cancel.started += instance.OnCancel;
//                @Cancel.performed += instance.OnCancel;
//                @Cancel.canceled += instance.OnCancel;
//                @Point.started += instance.OnPoint;
//                @Point.performed += instance.OnPoint;
//                @Point.canceled += instance.OnPoint;
//                @Click.started += instance.OnClick;
//                @Click.performed += instance.OnClick;
//                @Click.canceled += instance.OnClick;
//            }
//        }
//    }
//    public UIActions @UI => new UIActions(this);
//    private int m_KeyboardMouseSchemeIndex = -1;
//    public InputControlScheme KeyboardMouseScheme
//    {
//        get
//        {
//            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
//            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
//        }
//    }
//    private int m_GamepadSchemeIndex = -1;
//    public InputControlScheme GamepadScheme
//    {
//        get
//        {
//            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
//            return asset.controlSchemes[m_GamepadSchemeIndex];
//        }
//    }
//    public interface IPlayerActions
//    {
//        void OnMove(InputAction.CallbackContext context);
//        void OnLook(InputAction.CallbackContext context);
//        void OnInteract(InputAction.CallbackContext context);
//        void OnFloat(InputAction.CallbackContext context);
//    }
//    public interface IUIActions
//    {
//        void OnNavigate(InputAction.CallbackContext context);
//        void OnSubmit(InputAction.CallbackContext context);
//        void OnCancel(InputAction.CallbackContext context);
//        void OnPoint(InputAction.CallbackContext context);
//        void OnClick(InputAction.CallbackContext context);
//    }
//}
