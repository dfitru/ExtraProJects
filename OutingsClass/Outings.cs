using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutingsClass
{
    public enum EventType
    {
        Golf = 1,
        Bowling,
        AmusingPark,
        Concert
    }
    public class Outings
    {
       
        public int NumberOfPeople { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalCostPerPersonPerEvent { get; set; }
        public decimal TotalCostForEvent { get; set; }
        public EventType EventTypes { get; set; }
        public Outings() { }
        public Outings(int peopleNumber,DateTime date,decimal costPerpersoneEvent,decimal eventCost,EventType eventType ) 
        { 
            NumberOfPeople = peopleNumber;
            Date = date;
            TotalCostPerPersonPerEvent = costPerpersoneEvent;
            TotalCostForEvent = eventCost;
            EventTypes = eventType;
        }
    }
}
