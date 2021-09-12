using UnityEngine;

public class Singleton : MonoBehaviour 
{
    void Awake() 
    {
        MakeSingleton();
    }

    private void MakeSingleton() 
    {
        if (instance) 
            Destroy(gameObject);
        else 
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}