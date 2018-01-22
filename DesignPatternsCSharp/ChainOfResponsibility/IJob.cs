namespace ChainOfResponsibility
{
    public interface IJob
    {
        bool Run(object context);
    }
}
