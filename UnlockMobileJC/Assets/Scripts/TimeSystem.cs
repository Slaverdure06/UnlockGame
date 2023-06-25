using TMPro;
using UnityEngine;

public class TimeSystem : MonoBehaviour
{
    public static TimeSystem Instance;
    [SerializeField] private TextMeshProUGUI Counter;
    private float timer;
    public bool isRunning = false;

    void Start()
    {
        if(Instance == null)
        {
            Instance = this;
            timer = 1800; // In seconds
            string timeRemaining = string.Format("{0}:{1:00}", Mathf.FloorToInt(timer / 60), Mathf.FloorToInt(timer % 60));
            Counter.text = timeRemaining;
        }
        else
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this);
       
    }

    void Update()
    {
        if(isRunning)
        {
            timer -= Time.deltaTime;
            string timeRemaining = string.Format("{0}:{1:00}", Mathf.FloorToInt(timer / 60), Mathf.FloorToInt(timer % 60));
            Counter.text = timeRemaining;
        }
        
    }

    public void ClickStart()
    {
        isRunning = !isRunning;
    }
}
