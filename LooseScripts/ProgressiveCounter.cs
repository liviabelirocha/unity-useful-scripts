using UnityEngine;
using UnityEngine.UI;

public class ProgressiveCounter : MonoBehaviour
{

    [SerializeField] private float initial = 0;
    [SerializeField] private Text countText;

    private bool active = false;

    void Start()
    {
        countText.text = initial.ToString("F2"); // .00
    }

    private void Update()
    {
        if (active)
        {
            initial += Time.deltaTime;
            countText.text = Math.Round(initial).ToString();
        }
    }

    public void SetActive()
    {
        active = !active;
    }
}