using System;
using System.Windows.Forms;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Managers;

namespace TaiyakiSystem
{
    public partial class ChangeForm : Form
    {
        private TaiyakiManager _taiyakiMana;
        private int _selectedIndex;
        private TaiyakiSizeEnum _size;

        public ChangeForm(TaiyakiManager taiyakiMana, int selectedIndex)
        {
            InitializeComponent();
            _taiyakiMana = taiyakiMana;
            _selectedIndex = selectedIndex;
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            var taiyaki = _taiyakiMana.GetTaiyakiOrder(_selectedIndex);
            _size = taiyaki.Size;

            DefaultRadioButton.Checked = taiyaki.Name == TaiyakiEnum.通常たい焼き;
            CustardRadioButton.Checked = taiyaki.Name == TaiyakiEnum.カスタードたい焼き;
            DeluxeRadioButton.Checked = taiyaki.Name == TaiyakiEnum.デラックスたい焼き;

            BigRadioButton.Checked = taiyaki.Size == TaiyakiSizeEnum.大;
            MiddleRadioButton.Checked = taiyaki.Size == TaiyakiSizeEnum.中;
            SmallRadioButton.Checked = taiyaki.Size == TaiyakiSizeEnum.小;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            try
            {
                _taiyakiMana.ChangeOrder(_selectedIndex, _size);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}