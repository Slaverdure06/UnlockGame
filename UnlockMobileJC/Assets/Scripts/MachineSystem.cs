using UnityEngine;

public class MachineSystem : MonoBehaviour
{
    public static MachineSystem Instance;
    [SerializeField] private GameObject Machine;
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this);

    }

    public void ClickMachine()
    {
        if (!TimeSystem.Instance.isRunning) { return; }
        Machine.SetActive(!Machine.activeInHierarchy);
    }
}
