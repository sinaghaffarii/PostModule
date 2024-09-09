namespace PostModule.Domain.Common
{
    public class BaseEntity<TKey>
    {
        public int id { get; private set; }
        public DateTime CreateDate { get; private set; }

        public BaseEntity()
        {
            CreateDate =  DateTime.Now;
        }
    }
}
