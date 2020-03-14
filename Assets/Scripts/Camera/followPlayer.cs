using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public float rotationSpeed;
    public Transform Target;
    float mouseX, mouseY;

   void Start() {
       Cursor.visible = false;
       Cursor.lockState = CursorLockMode.Locked;
   }


    void Update()
    {
        cameraControl();
    }

    void cameraControl() {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -36, 60);

        transform.LookAt(Target);

        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
    }
}
