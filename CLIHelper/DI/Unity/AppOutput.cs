using DIHelper.Unity;
using Unity;

namespace CLIHelper.Unity;

public class AppOutput 
    : UnityDependencySet
{
    public AppOutput(
        IUnityContainer container)
        : base(container)
    {
    }

    public override void Register()
    {
        Container.RegisterSingleton<IOutput, ConsoleOut>();
        RegisterColumnCalculators();
        RegisterTableProviders();
    }

    protected virtual void RegisterColumnCalculators() { }

    protected virtual void RegisterTableProviders() { }
}