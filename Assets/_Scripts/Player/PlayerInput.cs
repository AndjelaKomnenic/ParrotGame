using UnityEngine;

public class PlayerInput : MonoBehaviour {
    

    public Vector2 GetMovementVectorNormalized(){

        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W)){
            inputVector.y = +1;  
        } if (Input.GetKey(KeyCode.S)) {
            inputVector.y = -1;
        } if (Input.GetKey(KeyCode.A)) {
            inputVector.x = -1;
        } if (Input.GetKey(KeyCode.D)) {
            inputVector.x = +1;
        }

        inputVector = inputVector.normalized;
        return inputVector;
    }

}