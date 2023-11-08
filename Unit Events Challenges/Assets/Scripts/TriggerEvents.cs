using UnityEngine;
using UnityEngine.Events;
public class TriggerEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent myTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myTrigger.Invoke();
        }
    }
}
