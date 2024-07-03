using System.Windows.Forms;
using TaiyakiSystem.Cores.Managers;

namespace TaiyakiSystem
{
    public partial class MainForm : Form
    {
        private TaiyakiManager _taiyakiMana = new TaiyakiManager();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// たい焼きの注文リスト更新
        /// </summary>
        private void UpdateScreen()
        {
            TaiyakiListView.Items.Clear();
            foreach (var taiyaki in _taiyakiMana.TaiyakiOrderList)
            {
                TaiyakiListView.Items.Add(new ListViewItem(new string[] { taiyaki.Name.ToString(), taiyaki.Content.ToString(), taiyaki.Size.ToString(), taiyaki.GetPrice().ToString() }));
            }
            PriceLabel.Text = $"{_taiyakiMana.GetTotalPrice().ToString("#,0円")}";
        }

        /// <summary>
        /// リストビューで選択されたインデックスを返す
        /// </summary>
        /// <returns></returns>
        private int GetSelectedIndex()
        {
            if (TaiyakiListView.SelectedItems.Count > 0)
            {
                return TaiyakiListView.SelectedItems[0].Index;
            }
            return -1;
        }

        /// <summary>
        /// 削除ボタンと変更ボタンの活性状態を変更
        /// </summary>
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
            _taiyakiMana.Remove(GetSelectedIndex());
            UpdateScreen();
            RemoveAndChangeButtonActiveStateChange();
        }

        private void ChangeButton_Click(object sender, System.EventArgs e)
        {
            if (new ChangeForm(_taiyakiMana, GetSelectedIndex()).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
            RemoveAndChangeButtonActiveStateChange();
        }

        private void TaiyakiListView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RemoveAndChangeButtonActiveStateChange();
        }
    }
}