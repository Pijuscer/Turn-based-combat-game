using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using Detail;

//Pijus Černiauskas PS1-1


//Namespace
namespace Game3
{
    //Inkapsuliacija
    //Paveldimumas
    public partial class Form1 : Form
    {
        Player player;
        Enemy enemy;

        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            player = new Warrior();
            enemy = new Enemy(1);
            LevelBox.Text = "Level: 1";
        }

        //Inkapsuliacija
        private void Form1_Load(object sender, EventArgs e)
        {
            NewPlayerHealthBoxRange();
            NewEnemyHealthBoxRange();


        }

        //Inkapsuliacija
        public void NewPlayerHealthBoxRange()
        {
            playerHealthBox.Maximum = player.Health;
            playerHealthBox.Value = player.Health;
        }

        //Inkapsuliacija
        public void PlayerHealthBoxRange()
        {
            if (player.Health > playerHealthBox.Value)
            {
                NewPlayerHealthBoxRange();
            }
            else
            {
                playerHealthBox.Value = player.Health;
            }
            
        }
        //Inkapsuliacija
        public void NewEnemyHealthBoxRange()
        {
            enemyHealthBox.Maximum = enemy.Health;
            enemyHealthBox.Value = enemy.Health;
        }

        //Inkapsuliacija
        public void EnemyHealthBoxRange()
        {
            if (enemy.Health > enemyHealthBox.Value)
            {
                NewEnemyHealthBoxRange();
            }
            else if (enemy.Health < 1)
            {
                enemy = new Enemy(enemy.Level + 1);
                LevelBox.Text = $"Level: {enemy.Level}";
                NewEnemyHealthBoxRange();
            }
            else
            {
                enemyHealthBox.Value = enemy.Health;
                
            }

        }

        //Inkapsuliacija
        private void hitAttack(object sender, EventArgs e)
        {
            enemy.Health -= rnd.Next(1, Convert.ToInt32(player.Hit * 2));
            EnemyHealthBoxRange();
            turnMade();
        }

        //Inkapsuliacija

        public void enemyAttack()
        {
            player.Health -= rnd.Next(1, Convert.ToInt32(enemy.Damage));
            PlayerHealthBoxRange();
        }

        //Inkapsuliacija
        public void turnMade()
        {
            HitButton.Enabled = false;
            PierceButton.Enabled = false;
            PotionsButton.Enabled = false;

            Thread.Sleep(500);
            enemyAttack();

            HitButton.Enabled = true;
            PierceButton.Enabled = true;
            PotionsButton.Enabled = true;
        }

        //Inkapsuliacija
        private void pierceAttack(object sender, EventArgs e)
        {
            enemy.Health -= rnd.Next(1, Convert.ToInt32(player.Pierce * 2));
            EnemyHealthBoxRange();
            turnMade();
        }

        //Inkapsuliacija
        private void PotionsHeal(object sender, EventArgs e)
        {
            player.Health += rnd.Next(1, Convert.ToInt32(player.Potions * 2));
            EnemyHealthBoxRange();
            turnMade();
        }
    }
}

