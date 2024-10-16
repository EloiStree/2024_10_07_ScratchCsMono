using UnityEngine;

public class RandomPositionMono_FromZeroWithDistance : AbstractRandomPositionMono
{
    public Vector3 m_position = Vector3.zero;
    public Vector3 m_distance = Vector3.one;
    
    public override Vector3 GetRandomPosition()
    {
        float x = Random.Range(-m_distance.x, m_distance.x);
        float y = Random.Range(-m_distance.y, m_distance.y);
        float z = Random.Range(-m_distance.z, m_distance.z);
        return new Vector3(x, y, z);
    }
}
