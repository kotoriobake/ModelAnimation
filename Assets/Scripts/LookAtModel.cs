using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtModel : MonoBehaviour
{
    public Transform target;
    float speed = 0.5f;

    void Update()
    {
        var direction = target.transform.position - transform.position;
        //direction.y = 0;

        var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
        lookRotation *= Quaternion.AngleAxis(90, Vector3.right);
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, speed);

        // 確認用の線
        Debug.DrawRay(transform.position, transform.up * 100, Color.red);
    }

    public void ChangeMoveSpeed(float _speed)
    {
        speed = _speed;
    }
}
