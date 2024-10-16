using UnityEngine;



public abstract class AbstractRandomPositionMono : MonoBehaviour {

    public  void GetRandomPosition(out Vector3 randomPosition) { 
        randomPosition = GetRandomPosition();
    }
    public abstract Vector3 GetRandomPosition();
}


public abstract class AbstractPositionMono: MonoBehaviour
{
    public void GetPosition(out Vector3 position)
    {
        position = GetPosition();
    }
    public abstract Vector3 GetPosition();
}

