using System;
using System.Windows.Forms;
using PseudoRandom;

namespace passwdGen2
{
    public partial class Main : Form
    {
        readonly string[] _chars = {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
            "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
            "u", "v", "w", "x", "y", "z",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y", "Z",
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
        };
        MersenneTwister rand = new MersenneTwister();

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォームが読み込まれた
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            rand.init_genrand((ulong)rd.Next());
            this.Text = Properties.Resources.title;
        }

        /// <summary>
        /// btnLDec が押されたら桁を 1 減らす
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLDec_Click(object sender, EventArgs e)
        {
            int v = GetTxtLen();
            if (v > 1)
            {
                txtLen.Text = (v - 1).ToString();
            }
        }

        /// <summary>
        /// btnLInc が押されたら桁を 1 増やす
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLInc_Click(object sender, EventArgs e)
        {
            txtLen.Text = (GetTxtLen() + 1).ToString();
        }

        /// <summary>
        /// btnLLShift が押されたら値を半分にする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLLShift_Click(object sender, EventArgs e)
        {
            txtLen.Text = IntelliDec(GetTxtLen()).ToString();
        }

        private void btnLRShift_Click(object sender, EventArgs e)
        {
            txtLen.Text = IntelliInc(GetTxtLen()).ToString();
        }

        /// <summary>
        /// txtLen の値を返す
        /// </summary>
        /// <returns></returns>
        private int GetTxtLen()
        {
            if (int.TryParse(txtLen.Text, out int v))
            {
                return v;
            }
            else
            {
                txtLen.Text = "1";
                return 1;
            }
        }

        /// <summary>
        /// btnNDec が押されたら個数を 1 減らす
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNDec_Click(object sender, EventArgs e)
        {
            int v = GetTxtNum();
            if (v > 1)
            {
                txtNum.Text = (v - 1).ToString();
            }
        }

        /// <summary>
        /// btnNInc が押されたら個数を 1 増やす
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNInc_Click(object sender, EventArgs e)
        {
            txtNum.Text = (GetTxtNum() + 1).ToString();
        }

        /// <summary>
        /// btnNLShift が押されたら値を賢く減らす
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNLShift_Click(object sender, EventArgs e)
        {
            txtNum.Text = IntelliDec(GetTxtNum()).ToString();
        }

        /// <summary>
        /// btnNRShift が押されたら値を賢く増やす
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNRShift_Click(object sender, EventArgs e)
        {
            txtNum.Text = IntelliInc(GetTxtNum()).ToString();
        }

        /// <summary>
        /// txtNum の値を取得する
        /// </summary>
        /// <returns></returns>
        private int GetTxtNum()
        {
            if (int.TryParse(txtNum.Text, out int v))
            {
                return v;
            }
            else
            {
                txtNum.Text = "1";
                return 1;
            }
        }

        /// <summary>
        /// btnGen が押されたら作る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGen_Click(object sender, EventArgs e)
        {
            txtPasswd.Text = "";
            int l = GetTxtLen();
            int n = GetTxtNum();

            // エラーチェック
            if (l <= 0)
            {
                MessageBox.Show("桁数が不正");
                return;
            }
            if (n <= 0)
            {
                MessageBox.Show("個数が不正");
                return;
            }

            bool isLU = chkLowUp.Checked;
            bool isAlNum = chkAlNum.Checked;

            string ps = "";

            for (int i = 0; i < n; i++)
            {
                string tp = Gen1Pass(l, 62);

                if (l >= 3)
                {
                    if (isLU)
                    {
                        if (!IsUseLowUp(tp))
                        {
                            i--;
                            continue;
                        }
                    }
                    if (isAlNum)
                    {
                        if (!IsUseAlNum(tp))
                        {
                            i--;
                            continue;
                        }
                    }
                }

                ps += tp + "\r\n";
            }

            txtPasswd.Text = ps;
        }

        /// <summary>
        /// 1 つだけパスワードを生成する
        /// </summary>
        /// <param name="len"></param>
        /// <param name="useSize"></param>
        /// <returns></returns>
        private string Gen1Pass(int len, int useSize)
        {
            string v = "";
            for (int i = 0; i < len; i++)
            {
                v += this._chars[rand.genrand_N(useSize)];
            }
            return v;
        }

        /// <summary>
        /// 賢く減らす処理
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private int IntelliDec(int v)
        {
            if (v > 1)
            {
                if (v <= 8)
                {
                    v = ((v / 2) - 1) * 2;
                }
                else if (v <= 16)
                {
                    v = ((v / 4) - 1) * 4;
                }
                else
                {
                    v = ((v / 8) - 1) * 8;
                }
                if (v < 1)
                {
                    v = 1;
                }
                return v;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// 賢く増やす
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private int IntelliInc(int v)
        {
            if (v >= 1)
            {
                if (v <= 8)
                {
                    v = ((v / 2) + 1) * 2;
                }
                else if (v <= 16)
                {
                    v = ((v / 4) + 1) * 4;
                }
                else
                {
                    v = ((v / 8) + 1) * 8;
                }
                return v;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// 大文字・小文字を使っているかチェック
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool IsUseLowUp(string s)
        {
            string u = s.ToUpper();
            string l = s.ToLower();
            return ((s != u) && (s != l));
        }

        /// <summary>
        /// 数字とアルファベットを使っているかチェック
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool IsUseAlNum(string s)
        {
            bool useAl = false;
            bool useNum = false;
            for (int i = s.Length - 1; i >= 1; i--)
            {
                int code = (int)s[i];
                if (code >= 48 && code <= 57)
                {
                    useNum = true;
                }
                else
                {
                    useAl = true;
                }

                if (useNum && useAl)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
