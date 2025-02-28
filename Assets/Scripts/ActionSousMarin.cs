using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionSousMarin : MonoBehaviour
{

    [SerializeField] private float vitesseMouvement;

    

    private Rigidbody _rb;

    private Vector3 directionInput;

    public InputActionReference move;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        vitesseMouvement = 1;
    }

   // void OnMove(InputValue directionBase)
   // {
      //  Vector2 directionAvecVitesse = directionBase.Get<Vector2>() * vitesseMouvement;
     //   directionInput = new Vector3(directionAvecVitesse.x, 0f, directionAvecVitesse.y);
   // }

    void OnAccelerer(InputValue etatBouton)
     {
         if(etatBouton.isPressed) {
            vitesseMouvement = 2;
       }
         else{
             vitesseMouvement = 1;
         }
     }
    // Update is called once per frame

    
    private void Update()
     {
        directionInput = move.action.ReadValue<Vector3>();
        print(directionInput);
     }
    private void FixedUpdate()
    {
        //Vector3 mouvement = directionInput;
        _rb.velocity = new Vector3(directionInput.x * vitesseMouvement, directionInput.y * vitesseMouvement, directionInput.z * vitesseMouvement);

    }

   



 }