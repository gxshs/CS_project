using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_app
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            // Настройка начальных значений
            progressBarStrength.Value = 0;
            labelStrengthText.Text = "Надёжность: 0%";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private bool HasConsecutive(List<int> indexes)
        {
            indexes.Sort();
            for (int i = 1; i < indexes.Count; i++)
            {
                if (indexes[i] == indexes[i - 1] + 1)
                    return true;
            }
            return false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private Color GetColorByScore(int score)
        {
            if (score <= 40)
                return Color.Red;
            else if (score <= 60)
                return Color.Orange;
            else if (score <= 80)
                return Color.Goldenrod;
            else
                return Color.Green;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            int score = 0;
            listBoxRecommendations.Items.Clear();

            // 1. Проверка длины
            if (password.Length >= 8)
                score += 10;
            else
                listBoxRecommendations.Items.Add("Увеличьте длину пароля (минимум 8 символов)");

            // 2. Проверка заглавных букв (2 и не подряд)
            var uppercaseIndexes = password
                .Select((c, i) => new { Char = c, Index = i })
                .Where(x => char.IsUpper(x.Char))
                .Select(x => x.Index)
                .ToList();

            if (uppercaseIndexes.Count >= 2 && !HasConsecutive(uppercaseIndexes))
                score += 20;
            else
                listBoxRecommendations.Items.Add("Добавьте не менее двух заглавных букв, не идущих подряд");

            // 3. Проверка цифр (3 и не подряд)
            var digitIndexes = password
                .Select((c, i) => new { Char = c, Index = i })
                .Where(x => char.IsDigit(x.Char))
                .Select(x => x.Index)
                .ToList();

            if (digitIndexes.Count >= 3 && !HasConsecutive(digitIndexes))
                score += 20;
            else
                listBoxRecommendations.Items.Add("Добавьте не менее трёх цифр, не идущих подряд");

            // 4. Специальные символы
            if (Regex.Matches(password, @"[\W_]").Count >= 1)
                score += 20;
            else
                listBoxRecommendations.Items.Add("Добавьте специальные символы (!, @, # и т.п.)");

            // 5. Проверка на шаблоны
            string[] patterns = { "qwerty", "12345", "abcdef", "admin", "user", "root", "password" };
            string lower = password.ToLower();
            if (patterns.Any(p => lower.Contains(p)))
                listBoxRecommendations.Items.Add("Избегайте популярных шаблонов (например, qwerty, admin)");
            else
                score += 20;

            // 6. Проверка на длинные группы букв (5+ подряд одинакового типа)
            if (Regex.IsMatch(password, @"[a-z]{4,}") || Regex.IsMatch(password, @"[A-Z]{4,}"))
                listBoxRecommendations.Items.Add("Избегайте длинных групп подряд идущих букв одного регистра");
            else
                score += 10;

            // Итог
            progressBarStrength.Value = score > 100 ? 100 : score;
            labelStrengthText.Text = "Надёжность: " + score.ToString() + "%";

            labelStrengthText.ForeColor = GetColorByScore(score);
        }

        private void buttonTogglePassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBoxRecommendations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
