namespace MyGame
{
    public class Enemy
    {
        private int health;
        private int shield;
        private string name;
        public Enemy(string name)
        {
            name = SetName(this.name);
            health = 100;
            shield = 0;
        }
        public string GetName()
        {
            return name;
        }
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if(shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }
        public string GetHealth()
        {
            return name;
        }
        public int GetShield()
        {
            return shield;
        }
        public void SetName(string newName)
        {
            newName.Trim();
            name = newName;
        }
    }
}