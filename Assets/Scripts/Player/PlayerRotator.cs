using UnityEngine;

public class PlayerRotator : MonoBehaviour
{
    [SerializeField] private float _minAngleZ;
    [SerializeField] private float _maxAngleZ;
    
    [SerializeField] private float _duration;
    
    private float _currentTime;
    private bool _canRotate;
    
    private Quaternion _quaternionMinAngleZ;
    private Quaternion _quaternionMaxAngleZ;

    private void Awake()
    {
        _canRotate = true;
        
        _quaternionMinAngleZ = Quaternion.Euler(0f, 0f, _minAngleZ);
        _quaternionMaxAngleZ = Quaternion.Euler(0f, 0f, _maxAngleZ);
    }

    private void Update()
    {
        if (_canRotate)
        {
            Rotate();
        }
    }
    
    public void StartRotation()
    {
        _canRotate = true;
    }

    public void StopRotation()
    {
        _canRotate = false;
    }

    private void Rotate()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, _duration) / _duration;
        transform.rotation = Quaternion.Lerp(_quaternionMinAngleZ, _quaternionMaxAngleZ, progress);
    }
}