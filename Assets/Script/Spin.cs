using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float _spinSpeed = 10f;

    private void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, 0, _spinSpeed * Time.deltaTime));
    }
}
