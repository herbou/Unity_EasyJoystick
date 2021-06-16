# Unity Joystick input
### Video tutorial: [https://youtu.be/J3lZr6NRkiA](https://youtu.be/J3lZr6NRkiA)
![video thumbnail](https://img.youtube.com/vi/J3lZr6NRkiA/0.jpg)

<br /> 

# Documentation :
## ■ How to use ?
1. Add ```EasyJoystick``` package to your project.
2. Create a UI Canvas.
3. Add the ```Joystick``` prefab (located at ```EasyJoystick/Prefabs```) to the Canvas.

<br /> 

## ■ How to control player with the Joystick ?
Default player movement script using keyboard arrow keys :
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

The player movement using our Joystick 😊 :
```C#
using UnityEngine ;
using EasyJoystick ; //line added

public class Player : MonoBehaviour {

   [SerializeField] private float speed ;
   [SerializeField] private Joystick joystick ; //line added

   private void Update () {
      float xMovement = joystick.Horizontal () ; //line changed
      float zMovement = joystick.Vertical () ;   //line changed

      transform.position += new Vector3 (xMovement, 0f, zMovement) * speed * Time.deltaTime ;
   }

}
```

<br /> 

## ■ Scripting :
As we've seen above, we must add ```EasyJoystick``` namespace first :
```C#
using EasyJoystick ;
```
Then add a reference to the Joystick :
```C#
public Joystick joystick ;
```
### 1. Properties :
| Property  | Description |
| ------------- | ------------- |
| IsTouching                  | ```bool```: Returns whether the joystick is held or not  |
| ArrowKeysSimulationEnabled  | ```bool```: Set it to true if you want to simulate joystick with arrow keys. <br> you can set it through the inspector too (Joystick gameobject) : <br> <br> <img src="https://www.mediafire.com/convkey/09e9/slytda007g4j8ka7g.jpg" height="50" /> |

Example :
```C#
// Use arrow keys too :
void Start (){
   joystick.ArrowKeysSimulationEnabled = true;
}

// IsTouching :
void Update (){
   if (joystick.IsTouching){
      // ...
   }
}
```

### 2. Methods :
| Method  | Description |
| ------------- | ------------- |
| Horizontal()  | ```float```: Returns horizontal movement between -1.0 and 1.0  |
| Vertical()    | ```float```: Returns vertical movement between -1.0 and 1.0  |


### 2. Events :
| Event  | Description |
| ------------- | ------------- |
| OnJoystickDownAction  | Executes once when the joystick is touched  |
| OnJoystickUpAction    | Executes once when you lift your finger.  |

Example :
```C#
void Start (){
   joystick.OnJoystickUpAction += ()=>{
      // this block of code always executes once when you lift your finger.
   };
}
```



<br><br><br>
## ❤️ Donate

<a href="https://paypal.me/hamzaherbou" title="https://paypal.me/hamzaherbou" target="_blank"><img align="left" height="50" src="https://www.mediafire.com/convkey/72dc/iz78ys7vtfsl957zg.jpg" alt="Paypal"></a>

<a href="https://www.buymeacoffee.com/hamzaherbou" title="https://www.buymeacoffee.com/hamzaherbou" target="_blank"><img align="left" height="50" src="https://www.mediafire.com/convkey/66bc/dg3xdk96km1pt7gzg.jpg" alt="BuyMeACoffee"></a>

<a href="https://patreon.com/herbou" title="https://patreon.com/herbou" target="_blank"><img align="left" height="50" src="https://www.mediafire.com/convkey/dc61/9kn26we5y76t8vlzg.jpg" alt="Patreon"></a>

