using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private Vector3 targetPosition;

    //[SerializeField] private float cameraMoveSpeed;

    private void Update()
    {
        if (target.gameObject != null)
        {
            targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);

            this.transform.position = targetPosition;

            // ī�޶� �÷��̾� �ڷ� ���󰣷���
            //this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, cameraMoveSpeed * Time.deltaTime);
        }
    }
}
