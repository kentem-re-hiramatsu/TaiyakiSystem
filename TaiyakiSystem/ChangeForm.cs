using System;
using System.Linq;
using System.Windows.Forms;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Managers;
using TaiyakiSystem.Cores.Models;

namespace TaiyakiSystem
{
    public partial class ChangeForm : Form
    {
        private TaiyakiManager _taiyakiMana;
        private int _selectedIndex;

        public ChangeForm(TaiyakiManager taiyakiMana, int selectedIndex)
        {
            InitializeComponent();
            _taiyakiMana = taiyakiMana;
            _selectedIndex = selectedIndex;
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            var taiyaki = _taiyakiMana.GetTaiyakiOrder(_selectedIndex);

            DefaultRadioButton.Checked = taiyaki is DefaultTaiyaki;
            CustardRadioButton.Checked = taiyaki is CustardTaiyaki;
            DeluxeRadioButton.Checked = taiyaki is DeluxeTaiyaki;

            BigRadioButton.Checked = taiyaki.Size == TaiyakiSizeType.大;
            MiddleRadioButton.Checked = taiyaki.Size == TaiyakiSizeType.中;
            SmallRadioButton.Checked = taiyaki.Size == TaiyakiSizeType.小;

            BigRadioButton.Tag = TaiyakiSizeType.大;
            MiddleRadioButton.Tag = TaiyakiSizeType.中;
            SmallRadioButton.Tag = TaiyakiSizeType.小;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            var selectedSizeRadioButton = SizeGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            var selectedSize = (TaiyakiSizeType)selectedSizeRadioButton.Tag;

            try
            {
                _taiyakiMana.ChangeOrder(_selectedIndex, selectedSize);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}