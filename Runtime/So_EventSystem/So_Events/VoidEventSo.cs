using UnityEngine;

namespace Project_Setup.So_EventSystem.So_Events
{
    [CreateAssetMenu(fileName = "Void Event", menuName = "Events / Void Event")]
    public class VoidEventSo : BaseEventSo<Void>
    {
        public void RaiseEvent()
        {
            RaiseEvent(new Void());
        }
    }
}
