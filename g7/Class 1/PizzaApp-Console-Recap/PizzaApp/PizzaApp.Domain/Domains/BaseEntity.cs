namespace PizzaApp.Domain.Domains
{
    public abstract class BaseEntity
    {
        protected virtual  int ID { get; set; }

        protected  int SetId()
        {
            return ID++;
        }
    }
}
