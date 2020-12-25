using UnityEngine ;
using EasyJoystick ;

public class Player : MonoBehaviour {

   [SerializeField] private float speed ;
   [SerializeField] private Joystick joystick ;

   private void Update () {
      float xMovement = joystick.Horizontal () ;
      float zMovement = joystick.Vertical () ;

      transform.position += new Vector3 (xMovement, 0f, zMovement) * speed * Time.deltaTime ;
   }

}
