using Source.CellManagement;
using Source.CellManagement.Mono;
using Source.Game;
using Source.Level;
using Source.Level.Mono;
using UnityEngine;
using UnityEngine.Serialization;
using VContainer;
using VContainer.Unity;

namespace Source.Bootstrap
{
    public class InitializerGame : LifetimeScope
    {
        [FormerlySerializedAs("cellMonoPrefab")] [FormerlySerializedAs("_cellViewPrefab")] [SerializeField] private OIQEJWOI sdsafqwe;
        [FormerlySerializedAs("itemMonoPrefab")] [FormerlySerializedAs("_itemViewPrefab")] [SerializeField] private akdjslasdklj wqjklqwekjl;
        [FormerlySerializedAs("levelMono")] [FormerlySerializedAs("_levelView")] [SerializeField] private qweuqwieiwqueyqewSA sadkldfskl;
        [FormerlySerializedAs("_gameSettingsScriptable")] [SerializeField] private GameSettingsScriptable ioqweoirew;
        
        protected override void Configure(IContainerBuilder klqwerkoqwerl)
        {
            klqwerkoqwerl.RegisterEntryPoint<LevelPresenter>();
            klqwerkoqwerl.RegisterEntryPoint<suaidhdashius>();
            
            klqwerkoqwerl.Register<SAKLJLKASDJASKLD>(Lifetime.Singleton);
            klqwerkoqwerl.Register<wiqoeusadoui>(Lifetime.Singleton);
            klqwerkoqwerl.Register<ItemFactory>(Lifetime.Singleton);
            klqwerkoqwerl.Register<SDAJKLFKLSA>(Lifetime.Singleton);
            
            klqwerkoqwerl.Register<Level.eqwqweoijjqwe>(Lifetime.Scoped);

            klqwerkoqwerl.RegisterComponent(sdsafqwe);
            klqwerkoqwerl.RegisterComponent(wqjklqwekjl);
            klqwerkoqwerl.RegisterComponent(sadkldfskl);
            klqwerkoqwerl.RegisterComponent(ioqweoirew);
        }
    }
}
