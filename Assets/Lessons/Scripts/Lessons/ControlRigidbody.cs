using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lessons
{
    public class ControlRigidbody : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private ControlRigidbody_settings _Settings;

        // Update is called once per frame
        void Update()
        {
            bool spaceKeyDown = Input.GetKeyDown(KeyCode.Space);

            if (spaceKeyDown)
            {
                _rigidbody.AddForce(_Settings.JumpForce, ForceMode.Impulse);
            }
        }
    }
}

