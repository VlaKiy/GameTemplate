using System;

namespace Assets.Scripts.Game.Main
{
    internal class GameRepository
    {
        public event Action<int> OnScopeChanged;

        private int _scopeAmount = 0;

        public void SetScope(int newScopeAmount)
        {
            if (newScopeAmount < 0)
                _scopeAmount = 0;

            _scopeAmount = newScopeAmount;

            OnScopeChanged?.Invoke(_scopeAmount);
        }

        public int GetScope() { return _scopeAmount; }
    }
}
