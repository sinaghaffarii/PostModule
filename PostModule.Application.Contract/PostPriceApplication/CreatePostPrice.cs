namespace PostModule.Application.Contract.PostPriceApplication
{
    public class CreatePostPrice : UpsertPostPrice
    {
        public int PostId { get; set; }

    }

}
