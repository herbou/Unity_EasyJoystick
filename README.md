# Unity Joystick input 😊 
### Video tutorial: [https://youtu.be/J3lZr6NRkiA](https://youtu.be/J3lZr6NRkiA)
![video thumbnail](https://img.youtube.com/vi/J3lZr6NRkiA/0.jpg)


# Documentation :
## ■ How to use ?
1. Add ```EasyJoystick``` package to your project.
2. Create a UI Canvas.
3. Add the ```Joystick``` prefab (located at ```EasyJoystick/Prefabs```) to the Canvas.

## ■ How to control player with the Joystick ?
Default player movement script :
```C#
using UnityEngine ;

public class Player : MonoBehaviour {

   [SerializeField] private float speed ;

   private void Update () {
      float xMovement = Input.GetAxis ("Horizontal") ;
      float zMovement = Input.GetAxis ("Vertical") ;

      transform.position += new Vector3 (xMovement, 0f, zMovement) * speed * Time.deltaTime ;
   }

}
```

<br><br><br>
## ❤️ Donate

<a href="https://paypal.me/hamzaherbou" title="https://paypal.me/hamzaherbou" target="_blank"><img align="left" height="50" src="https://www.mediafire.com/convkey/72dc/iz78ys7vtfsl957zg.jpg" alt="Paypal"></a>

<a href="https://www.buymeacoffee.com/hamzaherbou" title="https://www.buymeacoffee.com/hamzaherbou" target="_blank"><img align="left" height="50" src="https://www.mediafire.com/convkey/66bc/dg3xdk96km1pt7gzg.jpg" alt="BuyMeACoffee"></a>

<a href="https://patreon.com/herbou" title="https://patreon.com/herbou" target="_blank"><img align="left" height="50" src="https://www.mediafire.com/convkey/dc61/9kn26we5y76t8vlzg.jpg" alt="Patreon"></a>

