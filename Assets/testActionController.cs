using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class testActionController : MonoBehaviour
{ 
    Vector2 axis;
    private ActionBasedController controller;
    public GameObject dron;
    public float speed = 1;
    CharacterController character;
    float grad = 10f;
    Vector3 rotation = new Vector3(0, 0, 0);
    bool delay = false;
    bool isPressed;
    Vector2 inputAxis;
    

    //public InputActionReference InputAction = null;
    //public InputActionProperty ActionProperty = null;

    public float rotationSpeed = 1.0f;


    //private void Awake()
    //{
    //    InputAction.action.started += Action_started; ;
    //}

    //private void Action_started(InputAction.CallbackContext obj)
    //{
    //    throw new System.NotImplementedException();
    //}

    //private void OnDestroy()
    //{
    //    InputAction.action.started -= Up;
    //}

    void Start()
    {

        
        //XRControll.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
        controller = GetComponent<ActionBasedController>();
        character = dron.GetComponent<CharacterController>();
        isPressed = controller.uiPressAction.action.ReadValue<bool>();

        //controller.selectAction.action.performed += Action_performed;
        controller.translateAnchorAction.action.performed += Action_performed1;
        controller.selectAction.action.performed += Action_performed2;
        controller.uiPressAction.action.performed += Action_performed3;
        //controller.translateAnchorAction.action.performed -= Action_performed1;
    }

    private void Action_performed3(InputAction.CallbackContext obj)
    {
        Debug.Log(controller.uiPressAction.action.ReadValueAsObject());
        
    }

    private void Action_performed2(InputAction.CallbackContext obj)
    {
        
    }

    //public void OnEnable()
    //{
    //    controller.selectAction.action.performed += Action_performed;
    //    controller.translateAnchorAction.action.performed += Action_performed1;
    //}
    //public void OnDisable()
    //{
    //    controller.selectAction.action.performed -= Action_performed;
    //    controller.translateAnchorAction.action.performed -= Action_performed1;

    //}

    private void Action_performed1(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        axis = controller.translateAnchorAction.action.ReadValue<Vector2>();
        //Vector3 direction = new Vector3(axis.x, 0, axis.y);
        //character.SimpleMove(direction * Time.fixedDeltaTime * speed * (-40f));
    }

    private void Action_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        //Debug.Log(controller.translateAnchorAction.action);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (controller.translateAnchorAction.action.activeControl != null)
        {

            Vector3 direction = new Vector3(axis.x, 0, axis.y);
            character.Move(direction * Time.fixedDeltaTime * speed);


            dron.transform.localRotation = Quaternion.Euler(axis.y * grad, 0, -(axis.x * grad));

        }
        else
        {


            for (int i = 0; dron.transform.rotation != Quaternion.Euler(0,0,0); i++)
            {

                Rotation();
            }
        }


        if (controller.uiPressAction.action.ReadValueAsObject() != null )
        {
            //Debug.Log("Press");
            //isPressed = false;
            Vector3 up = new Vector3(0, 1, 0);
            character.Move(up * Time.fixedDeltaTime * speed);

        }

        if (controller.selectAction.action.ReadValueAsObject() != null)
        {
            //Debug.Log("Press");
            //isPressed = false;
            Vector3 up = new Vector3(0, -1, 0);
            character.Move(up * Time.fixedDeltaTime * speed);
        }

        //if (direction != Vector3.zero)
        //{
        //    dron.transform.forward = direction;
        //}

            //dron.transform.Translate(direction * speed * Time.deltaTime);
            //dron.transform.position += new Vector3(axis.x, 0, axis.y) * speed * Time.deltaTime;
            //Debug.Log(controller.translateAnchorAction.action.activeControl);
    }

    private void Rotation()
    {
        //if (dron.transform.rotation.x != 0f)
        //{
        //    //if(dron.transform.rotation.x > 0)
        //    //    dron.transform.Rotate(new Vector3(-0.001f, 0, 0));
        //    //else dron.transform.Rotate(new Vector3(0.001f, 0, 0));
        //    dron.transform.localRotation = Quaternion.Euler(dron.transform.rotation.x - 0.001f, 0, dron.transform.rotation.z);

        //}
        //if (dron.transform.rotation.z != 0f)
        //{
        //    //if (dron.transform.rotation.z > 0)
        //    //    dron.transform.Rotate(new Vector3(0, 0, -0.001f));
        //    //else dron.transform.Rotate(new Vector3(0, 0, 0.001f));
        //    dron.transform.localRotation = Quaternion.Euler(dron.transform.rotation.x, 0, dron.transform.rotation.z - 0.001f);
        //}

        //dron.transform.rotation.SetFromToRotation(new Vector3(dron.transform.rotation.x, dron.transform.rotation.y, dron.transform.rotation.z), Vector3.zero);

        dron.transform.localEulerAngles = Vector3.MoveTowards(transform.localEulerAngles, new Vector3(0, 0, 0), 1000.0f * Time.deltaTime);

        Quaternion rightRot = Quaternion.Euler(0,0,0);
        dron.transform.rotation = Quaternion.Lerp(dron.transform.rotation, rightRot, Time.deltaTime * rotationSpeed);

        //dron.transform.rotation = Quaternion.Lerp(dron.transform.rotation, Quaternion.Euler(0, 0 , 0), Mathf.Clamp((WhereTime += Time.deltaTime)));

        //dron.transform.localEulerAngles = Vector3.MoveTowards(transform.localEulerAngles, needAngles, 5.0f * Time.deltaTime);
    }
        
}
