using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Player {  //namespace makes it easy to snip and reuse code for other areas. 

    [RequireComponent(typeof(CharacterController))] // makes it need characrterConteoller to work
public class PlayerController : MonoBehaviour
{
    private CharacterController _contoller; // Getting the actual controller


    #region Var: Movement
    [SerializeField]
    private const float _MOVE_SPED = 8f;

    private Vector3 _move;

    #endregion


    void Start() 
    {

        _contoller = GetComponent<CharacterController>();



    }

    void Update() 
    {
        _move = new Vector3 (
            Input.GetAxis("Horizontal"),
            0,
            Input.GetAxis("Vertical")).normalized;

            _contoller.Move(_move * Time.deltaTime * _MOVE_SPED);
           


    }


}


}
