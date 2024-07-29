using Source.Level.Mono;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Source.Level
{
    public class SAKLJLKASDJASKLD
    {
        [Inject] private readonly IObjectResolver sjsknasnkj;

        private eqwqweoijjqwe m_CurrentEqwqweoijjqwe;

        public eqwqweoijjqwe Create()
        {
            m_CurrentEqwqweoijjqwe = sjsknasnkj.Resolve<eqwqweoijjqwe>();
            Debug.Log("Level create: "+ m_CurrentEqwqweoijjqwe);
            return m_CurrentEqwqweoijjqwe;
        }
    }
}