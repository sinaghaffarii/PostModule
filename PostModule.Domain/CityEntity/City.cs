using PostModule.Domain.Common;
using PostModule.Domain.StateEntity;

namespace PostModule.Domain.CityEntity
{
    public class City : BaseEntity<int>
    {
        public int StateId { get; private set; }
        public string Title { get; private set; }
        public bool Tehran { get; private set; }
        public bool Center { get; private set; }
        public State State { get; private set; }
        public City(int stateId, string title)
        {
            StateId = stateId;
            Title = title;
            Tehran = false;
            Center = false;
        }
        public void Edit(string title)
        {
            Title = title; 
        }
        public void IsTehran()
        {
            Tehran = true;
            Center = false;
        }
        public void IsCenter()
        {
            Center = true;
            Tehran = false;
        }
        public void NotCenterOrTehran()
        {
            Center = false;
            Tehran = false;
        }
    }
}
