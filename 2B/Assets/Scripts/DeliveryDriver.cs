using UnityEngine;
using UnityEngine.Events;

public class DeliveryDriver : MonoBehaviour
{

    [Header("배달원 설정")]

    public float moveSpeed = 8f;

    public float rotationSpeed = 10.0f;

    [Header("상태")]

    public float currentMoney = 0;

    public float batteryLebel = 100f;

    public int deliveryCount = 0;

    [System.Serializable]

    public class DriverEvents
    {
        [Header("이동 Event")]

        public UnityEvent OnMoveStarted;
        public UnityEvent OnMoveStoped;

        [Header("상태 변화 Event")]

        public UnityEvent<float> OnMoneyChanged;
        public UnityEvent<float> OnBatteryChanged;
        public UnityEvent<int> OnDeliveryCountChanged;

        [Header("경고 Event")]

        public UnityEvent OnLowBattery;
        public UnityEvent OnLowBatterEmpty;
        public UnityEvent OnDeliverCompleted;
    }

    public DriverEvents driverEvents;

    public bool isMoving = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //초기 상태 Event 발생
        driverEvents.OnMoneyChanged?.Invoke(currentMoney);
        driverEvents.OnBatteryChanged?.Invoke(batteryLebel);
        driverEvents.OnDeliveryCountChanged?.Invoke(deliveryCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
