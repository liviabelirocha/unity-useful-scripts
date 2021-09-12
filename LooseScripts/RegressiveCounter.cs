using UnityEngine;
using UnityEngine.UI;

public class Singleton : MonoBehaviour
{

    [SerializeField] private float initial = 60f;
    [SerializeField] private Text countText;

    void Start()
    {
        countText.text = initial.ToString();
    }

    private void Update()
    {
        if (initial >= 0)
        {
            initial -= Time.deltaTime;
            countText.text = Math.Round(initial).ToString();
        }
    }
}