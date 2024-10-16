using System.Collections.Generic;
using UnityEngine;

public abstract class ScratchCsMono_FloatValueFetchMono: ScratchCsMono_AbstractGenericValueFetchMono<float> 
{
}

public abstract class ScratchCsMono_StringValueFetchMono: ScratchCsMono_AbstractGenericValueFetchMono<string>
{
}

public abstract class ScratchCsMono_IntValueFetchMono: ScratchCsMono_AbstractGenericValueFetchMono<int>
{
}

public abstract class ScratchCsMono_BoolValueFetchMono: ScratchCsMono_AbstractGenericValueFetchMono<bool>
{
}

public abstract class ScratchCsMono_Vector3ValueFetchMono: ScratchCsMono_AbstractGenericValueFetchMono<Vector3>
{
}

public abstract class ScratchCsMono_Vector2ValueFetchMono: ScratchCsMono_AbstractGenericValueFetchMono<Vector2>
{
}


public abstract class ScratchCsMono_TransformFloatValue : ScratchCsMono_FloatValueFetchMono
{
    public Transform m_whatToObserve;
    public Space Space = Space.World;
    public void Reset()
    {
        m_whatToObserve = transform;
    
    }
}







