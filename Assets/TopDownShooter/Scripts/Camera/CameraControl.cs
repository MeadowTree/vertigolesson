using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.Shooting;


namespace TopDownShooter.Camera
{
    public class CameraControl : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private Transform _rotationtarget;
        [SerializeField] private Transform _targetTransform;
        [SerializeField] private Transform _cameraTransform;

        public ShootingManager _shootingManager;

        private void Update()
        {
            CameraRotationFollow();
            CameraMovementFollow();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _shootingManager.Shoot(_cameraTransform.position, _cameraTransform.forward);
            }
        }

        private void CameraRotationFollow()
        {
            _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation, Quaternion.LookRotation(_rotationtarget.forward), Time.deltaTime * _cameraSettings.RotationLerpSpeed);

        }

        private void CameraMovementFollow()
        {
            _cameraTransform.position = Vector3.Lerp(_cameraTransform.position, _targetTransform.position + _cameraSettings.PositionOffset, Time.deltaTime * _cameraSettings.PositionLerp);

        }

    }

}
