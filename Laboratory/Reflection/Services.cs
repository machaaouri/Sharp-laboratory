namespace Reflection
{
    public interface Ilogger
    {

    }

    public  class SqlServerLogger : Ilogger
    {

    }

    // Wrap data access code
    public interface IRepository<T>
    {

    }

    public class SqlRepository<T> : IRepository<T>
    {
        public SqlRepository(Ilogger logger)
        {

        }
    }

    public class InvoiceSerice
    {
        public InvoiceSerice(IRepository<Person> repository,Ilogger logger)
        {

        }
    }
}
