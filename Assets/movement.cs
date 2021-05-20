using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class movement : MonoBehaviour
{
    public InputHelpers.Button button = InputHelpers.Button.None;
    public float speed = 1;
    public XRNode inputSource;
    private Vector2 inputAxis;
    private CharacterController character;
    private bool grip, trigger;
    public GameObject dron;
    float grad = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
        

        device.TryGetFeatureValue(CommonUsages.gripButton, out grip);

        device.TryGetFeatureValue(CommonUsages.triggerButton, out trigger);
    }

    private void FixedUpdate()
    {
        Vector3 direction = new Vector3(inputAxis.x, 0, inputAxis.y);
        character.Move(direction * Time.fixedDeltaTime * speed);
        
        dron.transform.localRotation = Quaternion.Euler(inputAxis.y * grad, 0, -(inputAxis.x * grad));
        
        if ( trigger)
        {
            //Debug.Log("Press");
            //isPressed = false;
            Vector3 up = new Vector3(0, 1, 0);
            character.Move(up * Time.fixedDeltaTime * speed);

        }

        if (grip)
        {
            //Debug.Log("Press");
            //isPressed = false;
            Vector3 dowm = new Vector3(0, -1, 0);
            character.Move(dowm * Time.fixedDeltaTime * speed);
        }
    }

    //protected override Vector2 ReadInput()
    //{
    //    throw new System.NotImplementedException();
    //}
}
