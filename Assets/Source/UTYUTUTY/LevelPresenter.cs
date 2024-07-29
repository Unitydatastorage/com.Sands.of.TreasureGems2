using VContainer;
using VContainer.Unity;

namespace Source.Level
{
    public class LevelPresenter: IStartable, ITickable
    {
        [Inject] private readonly SAKLJLKASDJASKLD m_Sakljlkasdjaskld;

        private eqwqweoijjqwe m_CurrentEqwqweoijjqwe;
        
        public void Start()
        {
            m_CurrentEqwqweoijjqwe = m_Sakljlkasdjaskld.Create();
            //_currentLevel.Generate();
        }

        public void Tick()
        {
            m_CurrentEqwqweoijjqwe.UpdateCells();
        }
    }
}