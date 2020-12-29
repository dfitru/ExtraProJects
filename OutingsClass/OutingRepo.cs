using System.Collections.Generic;

namespace OutingsClass
{
    public class OutingRepo
    {
        private readonly List<Outings> _outingList = new List<Outings>();

        public void AddOuting(Outings outings)
        {
            _outingList.Add(outings);
        }
        //Outing Read
        public List<Outings> GetOutings()
        {
            return _outingList;
        }
        //Outing Read , Helper
        public Outings GetOutingsByType(EventType events)
        {
            foreach (Outings outing in _outingList)
            {
                if (outing.EventTypes == events)
                {
                    return outing;
                }

            }return null;
        }
        public bool UpdateOuting(EventType events, Outings newOut)
        {
            Outings old = GetOutingsByType(events);
            if (old != null)
            {
                old.Date = newOut.Date;
                old.EventTypes = newOut.EventTypes;
                old.NumberOfPeople = newOut.NumberOfPeople;
                old.TotalCostForEvent = newOut.TotalCostForEvent;
                old.TotalCostPerPersonPerEvent = newOut.TotalCostPerPersonPerEvent;
                return true;
            }
            return false;
        }

    }
}
