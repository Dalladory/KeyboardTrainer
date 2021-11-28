using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyboard_trainer
{
    public partial class Form1 : Form
    {
        List<string> words = new List<string>();
        List<string> inputWords = new List<string>();

        string wordsList;

        InputStatistic statistic;

        bool isValidInputed;

        Button prevBtn = null;

        public Form1()
        {
            InitializeComponent();
            LoadWords("words.txt");
            Timer.Tick += SecondsUpdate;
            statistic = new InputStatistic();
        }

        private void LoadWords(string path)
        {
            using (StreamReader reader = new StreamReader(File.Open(path, FileMode.OpenOrCreate)))
            {
                string  list = reader.ReadToEnd();
                if(string.IsNullOrEmpty(list))
                {
                    MessageBox.Show("Words list is empty");
                    return;
                }

                words.Clear();
                wordsList = list;
                words.AddRange(wordsList.Split(new string[] {" ", "\n" }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
                WordsCountNumeric.Maximum = words.Count;

                if(words.Count > 0)
                {
                    WordsCountNumeric.Value = 1;
                }
                else
                {
                    WordsCountNumeric.Value = 0;
                }
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            int wordsCount = (int)WordsCountNumeric.Value;
            int symbolsCount = 0;
            inputWords.Clear();
            for (int i = 0; i < wordsCount; i++)
            {
                symbolsCount += words[i].Length;
                inputWords.Add(words[i]);
            }

            WordsProgressBarStrip.Maximum = wordsCount;
            WordsProgressBarStrip.Value = 0;
            SymbolsProgressBarStrip.Maximum = symbolsCount;
            SymbolsProgressBarStrip.Value = 0;


            WordsBox.Text = inputWords[0];
            StartBtn.Enabled = false;
            StopBtn.Enabled = true;
            WordsBox.Enabled = true;
            InputBox.Enabled = true;
            this.ActiveControl = InputBox;
            statistic = new InputStatistic();

            if(KeyboardEnabled.Checked)
            {
                prevBtn = GetButton(WordsBox.Text.ToUpper()[0].ToString());
                EditButton(prevBtn, 5, Color.Green);
            }
            Timer.Start();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            StopBtn.Enabled = false;
            StartBtn.Enabled = true;

            WordsBox.Clear();
            InputBox.Clear();

            WordsBox.Enabled = false;
            InputBox.Enabled = false;

            SymbolsProgressBarStrip.Value = SymbolsProgressBarStrip.Maximum;
            WordsProgressBarStrip.Value = WordsProgressBarStrip.Maximum;

            SpeedLabel.Text = $"{statistic.SymbolsPerMinute} s/min";
            AccuracyLb.Text = $"Accuracy:  {statistic.Accuracy}%";

            EditButton(prevBtn, 1, Color.Black);

            ShowStatMenu_Click(null, null);
        }

        private void SecondsUpdate(object sender, EventArgs e)
        {
            statistic.Seconds++;
            TimeStrip.Text = $"Time : {statistic.Seconds}s";
            SpeedLabel.Text = $"{statistic.SymbolsPerMinute} s/min";
            AccuracyLb.Text = $"Accuracy:  {statistic.Accuracy}%";
        }

        private void UploadWordsMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                LoadWords(dialog.FileName);
            }
        }

        private void ShowWordsMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(wordsList);
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                isValidInputed = false;
                return;
            }

            if (e.KeyCode == Keys.Back)
            {
                isValidInputed = false;
                return;
            }

            SymbolsProgressBarStrip.Value = SymbolsProgressBarStrip.Value + 1 <= SymbolsProgressBarStrip.Maximum ? SymbolsProgressBarStrip.Value + 1 : SymbolsProgressBarStrip.Maximum;
            statistic.SymbolCount++;

            isValidInputed = true;
        }
        
        private void InputBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(!isValidInputed)
            {
                return;
            }
            
            if (InputBox.Text == "")
            {
                return;
            }

            if (inputWords[0].StartsWith(InputBox.Text, !CaseCheckBox.Checked, CultureInfo.CurrentCulture))
            {
                this.ActiveControl = WordsBox;
                WordsBox.Select(0, InputBox.Text.Length);
                WordsBox.SelectionBackColor = Color.Green;
                this.ActiveControl = InputBox;

                if (KeyboardEnabled.Checked)
                {
                    EditButton(prevBtn, 1, Color.Black);
                    if (WordsBox.SelectedText.Length < WordsBox.TextLength)
                    {
                        prevBtn = GetButton(WordsBox.Text.ToUpper()[WordsBox.SelectedText.Length].ToString());
                        EditButton(prevBtn, 5, Color.Green);
                    }
                    else
                    {
                        prevBtn = null;
                    }
                }

                if (inputWords[0].ToLower() == InputBox.Text.ToLower())
                {
                    inputWords.Remove(inputWords[0]);
                    WordsProgressBarStrip.Value++;
                    statistic.WordsCount++;

                    if (inputWords.Count == 0)
                    {
                        StopBtn_Click(null, null);
                        return;
                    }
                    WordsBox.Text = inputWords[0];
                    if (KeyboardEnabled.Checked)
                    {
                        prevBtn = GetButton(WordsBox.Text.ToUpper()[0].ToString());
                        EditButton(prevBtn, 5, Color.Green);
                    }
                    InputBox.Clear();
                }
            }
            else
            {
                SymbolsProgressBarStrip.Value = SymbolsProgressBarStrip.Value - 1 >= 0 ? SymbolsProgressBarStrip.Value - 1 : 0;
                statistic.SymbolCount--;
                statistic.ErrorInputs++;
                if (KeyboardEnabled.Checked)
                {
                    EditButton(prevBtn, 5, Color.Red);
                }
            }
        }

        private Button GetButton(string text)
        {
            Button btn = null;
            foreach (var item in KeyboardGroup.Controls.OfType<Button>())
            {
                if (item.Text == text)
                {
                    btn = item;
                    break;
                }
            }
            return btn;
        }

        private void EditButton(Button btn, int borderSize, Color borderColor)
        {
            if (btn != null)
            {
                btn.FlatAppearance.BorderSize = borderSize;
                btn.FlatAppearance.BorderColor = borderColor;
            }
        }

        private void ShowStatMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(statistic.ToString(), "Statistic");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeyboardEnabled_CheckedChanged(object sender, EventArgs e)
        {
            KeyboardGroup.Visible = KeyboardEnabled.Checked;

            if(KeyboardEnabled.Checked)
            {
                if (WordsBox.SelectedText.Length < WordsBox.TextLength)
                {
                    prevBtn = GetButton(WordsBox.Text.ToUpper()[WordsBox.SelectedText.Length].ToString());
                    EditButton(prevBtn, 5, Color.Green);
                }
            }
            else
            {
                EditButton(prevBtn, 1, Color.Black);
                prevBtn = null;
            }
            this.ActiveControl = InputBox;
        }

        private void CaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = InputBox;
        }

        private void KeyboardGroup_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = InputBox;
        }

        private void ShuflleWordsMenu_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < words.Count / 2; i++)
            {
                int randomIndex = rnd.Next(words.Count / 2, words.Count);
                var temp = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = temp;
            }
        }
    }
}