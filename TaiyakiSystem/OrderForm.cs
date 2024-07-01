﻿using System;
using System.Windows.Forms;
using TaiyakiSystem.Cores;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Managers;

namespace TaiyakiSystem
{
    public partial class OrderForm : Form
    {
        private TaiyakiManager _taiyakiMana;
        private int _taiyakiIndex;
        private TaiyakiSizeEnum _size;

        public OrderForm(TaiyakiManager taiyakiMana)
        {
            InitializeComponent();
            _taiyakiMana = taiyakiMana;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            DefaultRadioButton.Tag = Consts.DEFAULT_TAIYAKI_INDEX;
            CustardRadioButton.Tag = Consts.CUSTARD_TAIYAKI_INDEX;
            DeluxeRadioButton.Tag = Consts.DELUXE_TAIYAKI_INDEX;

            _taiyakiIndex = (int)DefaultRadioButton.Tag;
            _size = TaiyakiSizeEnum.大;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            try
            {
                var taiyaki = new TaiyakiMenu().GetTaiyaki(_taiyakiIndex, _size);
                _taiyakiMana.Add(taiyaki);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DefaultRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _taiyakiIndex = (int)DefaultRadioButton.Tag;
        }

        private void CustardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _taiyakiIndex = (int)CustardRadioButton.Tag;
        }

        private void DeluxeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _taiyakiIndex = (int)DeluxeRadioButton.Tag;
        }

        private void BigRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _size = TaiyakiSizeEnum.大;
        }

        private void MiddleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _size = TaiyakiSizeEnum.中;
        }

        private void SmallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _size = TaiyakiSizeEnum.小;
        }
    }
}