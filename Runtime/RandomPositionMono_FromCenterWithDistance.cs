using UnityEngine;

public class RandomPositionMono_FromCenterWithDistance : AbstractRandomPositionMono
{
    public Transform m_centerAnchor;
    public float m_distanceX = short.MaxValue / 1000f;
    public float m_distanceY = short.MaxValue / 1000f;
    public float m_distanceZ = short.MaxValue / 1000f;

    public override Vector3 GetRandomPosition()
    {


        float x = Random.Range(-m_distanceX, m_distanceX);
        float y = Random.Range(-m_distanceY, m_distanceY);
        float z = Random.Range(-m_distanceZ, m_distanceZ);

        Vector3 randomPosition = new Vector3(x, y, z);
        if (m_centerAnchor == null)
        {
            return randomPosition;
        }
        else
        {
            Vector3 randomPositionRotated = m_centerAnchor.rotation * randomPosition;
            return m_centerAnchor.position + randomPositionRotated;
        }
    }

}