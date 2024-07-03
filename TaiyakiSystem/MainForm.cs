﻿using System.Windows.Forms;
using TaiyakiSystem.Cores.Managers;

namespace TaiyakiSystem
{
    public partial class MainForm : Form
    {
        private TaiyakiManager _taiyakiMana = new TaiyakiManager();
        private int _selectedIndex;

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateScreen()
        {
            TaiyakiListView.Items.Clear();
            foreach (var taiyaki in _taiyakiMana.TaiyakiOrderList)
            {
                TaiyakiListView.Items.Add(new ListViewItem(new string[] { taiyaki.Name.ToString(), taiyaki.Content.ToString() }));
            }
            PriceLabel.Text = $"{_taiyakiMana.GetTotalPrice().ToString("#,0円")}";
        }

        private void SelectedIndex()
        {
            if (TaiyakiListView.SelectedItems.Count > 0)
            {
                _selectedIndex = TaiyakiListView.SelectedItems[0].Index;
            }
        }

        private void RemoveAndChangeButtonActiveStateChange()
        {
            RemoveButton.Enabled = TaiyakiListView.SelectedItems.Count > 0;
            ChangeButton.Enabled = TaiyakiListView.SelectedItems.Count > 0;
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            if (new OrderForm(_taiyakiMana).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
            RemoveAndChangeButtonActiveStateChange();
        }

        private void RemoveButton_Click(object sender, System.EventArgs e)
        {
            _taiyakiMana.Remove(_selectedIndex);
            UpdateScreen();
            RemoveAndChangeButtonActiveStateChange();
        }

        private void ChangeButton_Click(object sender, System.EventArgs e)
        {
            if (new ChangeForm(_taiyakiMana, _selectedIndex).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
            RemoveAndChangeButtonActiveStateChange();
        }

        private void TaiyakiListView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SelectedIndex();
            RemoveAndChangeButtonActiveStateChange();
        }
    }
}