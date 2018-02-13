namespace ATowerDefenceGame
{
    abstract class Enemy : IObject
    {
        public float MaxHealth { get; }
        public float Health { get; set; }

        public bool Dead => Health < 0;

        public Enemy(float maxHealth)
        {
            MaxHealth = maxHealth;
        }
    }
}