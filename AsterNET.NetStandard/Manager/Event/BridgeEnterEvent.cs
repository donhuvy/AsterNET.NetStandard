﻿namespace AsterNET.NetStandard.Manager.Event
{
    public class BridgeEnterEvent : BridgeActivityEvent
    {
        public BridgeEnterEvent(ManagerConnection source) : base(source)
        {
        }
    }
}
