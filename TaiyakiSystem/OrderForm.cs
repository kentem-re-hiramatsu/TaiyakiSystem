using System;
using System.Linq;
using System.Windows.Forms;
using TaiyakiSystem.Cores.Enums;
using TaiyakiSystem.Cores.Managers;

namespace TaiyakiSystem
{
    public partial class OrderForm : Form
    {
        private TaiyakiManager _taiyakiMana;

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
            DefaultRadioButton.Tag = TaiyakiType.通常たい焼き;
            CustardRadioButton.Tag = TaiyakiType.カスタードたい焼き;
            DeluxeRadioButton.Tag = TaiyakiType.デラックスたい焼き;

            BigRadioButton.Tag = TaiyakiSizeType.大;
            MiddleRadioButton.Tag = TaiyakiSizeType.中;
            SmallRadioButton.Tag = TaiyakiSizeType.小;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            var selectedTaiyakiRadioButton = MenuGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            var selectedTaiyaki = (TaiyakiType)selectedTaiyakiRadioButton.Tag;

            var selectedSizeRadioButton = SizeGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            var selectedSize = (TaiyakiSizeType)selectedSizeRadioButton.Tag;

            try
            {
                var taiyaki = _taiyakiMana.GetTaiyaki(selectedTaiyaki, _taiyakiMana.GetSize(selectedSize));
                _taiyakiMana.Add(taiyaki);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}