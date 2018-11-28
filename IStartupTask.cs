namespace ChinaBeacon.Sdk.Kit
{
    public interface IStartupTask
    {
        void Execute();

        int Order { get; }
    }
}
