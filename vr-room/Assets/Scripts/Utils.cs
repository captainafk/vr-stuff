using UnityEngine;

namespace Canoe
{
    public static class Utils
    {
        public static bool Contains(this LayerMask layerMask, int layer)
        {
            return (layerMask & (1 << layer)) != 0;
        }
    }
}