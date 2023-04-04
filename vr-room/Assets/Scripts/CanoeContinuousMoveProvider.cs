using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Canoe
{
    public class CanoeContinuousMoveProvider : ContinuousMoveProviderBase
    {
        public float ForwardSpeed { get; set; }

        protected override Vector2 ReadInput()
        {
            // TODO: Side-speed
            return new Vector2(0, ForwardSpeed);
        }
    }
}
