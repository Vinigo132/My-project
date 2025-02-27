using UnityEngine;

public class CarController : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";

    private const string VERTICAL = "Vertical";

    //componentes de fisica do carro
    [SerializeField] private WheelCollider frontLeftWheelTransform;
    [SerializeField] private WheelCollider frontRightWheelTransform;
    [SerializeField] private WheelCollider RearLeftWheelTransform;
    [SerializeField] private WheelCollider RearLRightWheelTransform;

    //componentes do carro
    [SerializeField] private Transform frontLeftWheelCollider;
    [SerializeField] private Transform frontRightWheelCollider;
    [SerializeField] private Transform RearLeftWheelCollider;
    [SerializeField] private Transform RearRightWheelCollider;

    //compontentes do controller
    [SerializeField] private float motorforce;
    [SerializeField] private float breakforce;
    [SerializeField] private float maxSteeringAngleforce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
