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
            DefaultRadioButton.Tag = TaiyakiEnum.通常たい焼き;
            CustardRadioButton.Tag = TaiyakiEnum.カスタードたい焼き;
            DeluxeRadioButton.Tag = TaiyakiEnum.デラックスたい焼き;

            BigRadioButton.Tag = TaiyakiSizeEnum.大;
            MiddleRadioButton.Tag = TaiyakiSizeEnum.中;
            SmallRadioButton.Tag = TaiyakiSizeEnum.小;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            var selectedTaiyakiRadioButton = MenuGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            var selectedTaiyaki = (TaiyakiEnum)selectedTaiyakiRadioButton.Tag;

            var selectedSizeRadioButton = SizeGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            var selectedSize = (TaiyakiSizeEnum)selectedSizeRadioButton.Tag;

            try
            {
                var taiyaki = _taiyakiMana.GetTaiyaki(selectedTaiyaki, selectedSize);
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