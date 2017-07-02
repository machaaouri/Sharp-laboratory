namespace Reflection
{
    public interface Ilogger
    {

    }

    public  class SqlServerLogger : Ilogger
    {

    }

    // Wrap data access code
    public interface Irepository<T>
    {

    }

    public class SqlRepository<T> : Irepository<T>
    {
        public SqlRepository(Ilogger logger)
        {

        }
    }

    public class InvoiceSerice
    {
        public InvoiceSerice(Irepository<Person> repository,Ilogger logger)
        {

        }
    }
}
