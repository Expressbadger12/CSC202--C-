using System;

namespace RPGBattleSimulator
{
    public partial class Form1 : Form
    {
        private int EnemyHealth = 100;
        private int YourHealth = 100;
        private int EnemyLuck = 75;
        private int YourLuck = 75;
        private bool playerhashealthpotion = true;
        private bool HasHealthPotion = true;
        public Form1()
        {
            InitializeComponent();
            //set tags for groups
            btnAttack.Tag = "grpAction"; // grpAction = action buttons
            btnHealth.Tag = "grpAction";
            btnSpell.Tag = "grpAction";
            txtEnemyHealth.Text = "100";
            txtYourHealth.Text = "100";
            lblUpdate.Text = "A bandit has attacked!";
            lblPlayerUpdate.Text = "";
            label1.Text = ""; // old bebuging label, don't worry about it.
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction")
                {
                    ctrl.Enabled = true;
                }
            }

        }

        private void EnemyTurn(int Health, int luck)
        {
            Random random = new Random();
            int EnemyAttack = random.Next(1, 101);

            if (Health <= 50 && HasHealthPotion)
            {
                int potion = random.Next(15, 30);
                EnemyHealth = EnemyHealth + potion;
                lblUpdate.Text = $"The bandit drank a potion and regained {potion.ToString()} health!";
                txtEnemyHealth.Text = EnemyHealth.ToString();
                HasHealthPotion = false;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction" && ctrl.Name != "btnHealth")
                    {
                        ctrl.Enabled = true;
                    }
                    if (playerhashealthpotion)
                    {
                        btnHealth.Enabled = true;
                    }
                }
                //label1.Text = $"Enemy Health = {EnemyHealth} Player Health = {YourHealth}.";
                if (EnemyHealth < 1)
                {
                    lblPlayerUpdate.Text = "You killed the bandit! Good job! You Win!";
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction")
                        {
                            ctrl.Enabled = false;
                        }
                    }
                }
                else if (YourHealth < 1)
                {
                    lblUpdate.Text = "The bandit killed you! Bad job! You lose!";
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction")
                        {
                            ctrl.Enabled = false;
                        }
                    }
                }
                return;
            }
            else if (EnemyAttack <= EnemyLuck)
            {
                int Damage = random.Next(10, 25);
                YourHealth = YourHealth - Damage;
                lblUpdate.Text = $"The bandit hit you for {Damage} damage!";
                txtYourHealth.Text = YourHealth.ToString();
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction" && ctrl.Name != "btnHealth")
                    {
                        ctrl.Enabled = true;
                    }
                    if (playerhashealthpotion)
                    {
                        btnHealth.Enabled = true;
                    }
                }
                //label1.Text = $"Enemy Health = {EnemyHealth} Player Health = {YourHealth}.";
                if (EnemyHealth < 1)
                {
                    lblPlayerUpdate.Text = "You killed the bandit! Good job! You Win!";
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction")
                        {
                            ctrl.Enabled = false;
                        }
                    }
                }
                else if (YourHealth < 1)
                {
                    lblUpdate.Text = "The bandit killed you! Bad job! You lose!";
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction")
                        {
                            ctrl.Enabled = false;
                        }
                    }
                }
                return;
            }
            else if (EnemyAttack > EnemyLuck)
            {
                lblUpdate.Text = "The bandit made an attack but it missed!";
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction" && ctrl.Name != "btnHealth")
                    {
                        ctrl.Enabled = true;
                    }
                    if (playerhashealthpotion)
                    {
                        btnHealth.Enabled = true;
                    }
                }
                //label1.Text = $"Enemy Health = {EnemyHealth} Player Health = {YourHealth}.";
                if (EnemyHealth < 1)
                {
                    lblPlayerUpdate.Text = "You killed the bandit! Good job! You Win!";
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction")
                        {
                            ctrl.Enabled = false;
                        }
                    }
                }
                else if (YourHealth < 1)
                {
                    lblUpdate.Text = "The bandit killed you! Bad job! You lose!";
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction")
                        {
                            ctrl.Enabled = false;
                        }
                    }
                }
                return;
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int YourAttack = random.Next(1, 101);
            if (YourAttack <= YourLuck)
            {
                int Damage = random.Next(10, 25);
                EnemyHealth = EnemyHealth - Damage;
                lblPlayerUpdate.Text = $"You hit the bandit for {Damage} damage!";
                txtEnemyHealth.Text = EnemyHealth.ToString();
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction")
                    {
                        ctrl.Enabled = false;
                    }
                }
                EnemyTurn(EnemyHealth, EnemyLuck);
                return;
            }
            else if (YourAttack > YourLuck)
            {
                lblPlayerUpdate.Text = "You attacked the bandit, but you missed! :(";
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction")
                    {
                        ctrl.Enabled = false;
                    }
                }
                EnemyTurn(EnemyHealth, EnemyLuck);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEnemyHealth.Text = "100";
            txtYourHealth.Text = "100";
            lblUpdate.Text = "A bandit has attacked!";
            lblPlayerUpdate.Text = "";
            EnemyHealth = 100;
            YourHealth = 100;
            EnemyLuck = 75;
            YourLuck = 75;
            playerhashealthpotion = true;
            HasHealthPotion = true;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction")
                {
                    ctrl.Enabled = true;
                }
            }
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int potion = random.Next(15, 30);
            YourHealth = YourHealth + potion;
            txtYourHealth.Text = YourHealth.ToString();
            lblPlayerUpdate.Text = $"You drank a potion and regained {potion.ToString()} health!";
            playerhashealthpotion = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction")
                {
                    ctrl.Enabled = false;
                }
            }
            EnemyTurn(EnemyHealth, EnemyLuck);
            return;
        }

        private void btnSpell_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int SpellAttack = random.Next(1, 101);
            if (SpellAttack <= YourLuck && EnemyLuck >= 10)
            {
                int Disluck = random.Next(10, 20);
                EnemyLuck = EnemyLuck - Disluck;
                lblPlayerUpdate.Text = "You reduced the bandit's luck!";
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction")
                    {
                        ctrl.Enabled = false;
                    }
                }
                EnemyTurn(EnemyHealth, EnemyLuck);
                return;
            }
            else if (SpellAttack <= YourLuck && EnemyLuck < 10)
            {
                lblPlayerUpdate.Text = "Your spell hit, but the bandit's luck couldn't get any wose!";
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction")
                    {
                        ctrl.Enabled = false;
                    }
                }
                EnemyTurn(EnemyHealth, EnemyLuck);
                return;
            }
            else if (SpellAttack > YourLuck)
            {
                lblPlayerUpdate.Text = "You cast a spell on the bandit, but it missed! :(";
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Tag != null && ctrl.Tag.ToString() == "grpAction")
                    {
                        ctrl.Enabled = false;
                    }
                }
                EnemyTurn(EnemyHealth, EnemyLuck);
                return;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
