using System;

namespace Project_Setup.So_EventSystem
{
    [AttributeUsage(AttributeTargets.Method)]
    public class HookEventAttribute : Attribute
    {
        public HookEventAttribute()
        {
            
        }
    }
}