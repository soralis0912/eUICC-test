using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCSC;
using PCSC.Iso7816;
using PCSC.Exceptions;

namespace eUICC_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                using (var context = ContextFactory.Instance.Establish(SCardScope.System))
                {
                    var readerNames = context.GetReaders();
                    if (readerNames == null || readerNames.Length == 0)
                    {
                        MessageBox.Show("スマートカードリーダが見つかりません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        Application.Exit();  // スマートカードリーダが無ければ終了する
                    }
                    foreach (var readerName in readerNames)
                    {
                        comboBoxDevice.Items.Add(readerName);  // カードリーダの名前をコンボボックスに追加
                    }
                }
            }
            catch (NoServiceException)
            {
                MessageBox.Show("スマートカードリソースマネージャが稼働していません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Application.Exit();
            }
            comboBoxDevice.SelectedIndex = 0;

            // データグリッドビューの初期設定
            dataGridView.AllowUserToResizeColumns = true;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView.Columns.Add("request", "リクエスト");
            dataGridView.Columns.Add("response", "レスポンス");

            dataGridView.Columns["request"].Width = 200;
            dataGridView.Columns["response"].Width = 350;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var readerName = comboBoxDevice.Text;
            using (var context = ContextFactory.Instance.Establish(SCardScope.System))
            {
                try
                {
                    using (var isoReader = new IsoReader(context, readerName, SCardShareMode.Shared, SCardProtocol.T0, false))
                    {

                        // テキストボックスからコマンドを作成

                        byte CLA = (byte)Convert.ToInt32(txb_send_cla.Text, 16);
                        byte INS = (byte)Convert.ToInt32(txb_send_ins.Text, 16);
                        byte P1 = (byte)Convert.ToInt32(txb_send_p1.Text, 16);
                        byte P2 = (byte)Convert.ToInt32(txb_send_p2.Text, 16);
                        byte[] DATA = StringToBytes(txb_send_data.Text);




                        // APDUコマンドの作成
                        var apdu = new CommandApdu(IsoCase.Case4Extended, isoReader.ActiveProtocol)
                        {
                            CLA = CLA,
                            INS = INS,
                            P1 = P1,
                            P2 = P2,
                            Data = DATA,
                        };
                        var response = isoReader.Transmit(apdu);
                        MessageBox.Show("SW1 :" + string.Format("{0:X2}", response.SW1) + " SW2: " + string.Format("{0:X2}", response.SW2));



                        dataGridView.Rows.Add(txb_send_cla.Text + ' ' + txb_send_ins.Text + ' ' + txb_send_p1.Text + ' ' + txb_send_p2.Text + ' ' + txb_send_data.Text + ' ', "SW1 :" + string.Format("{0:X2}", response.SW1) + " SW2: " + string.Format("{0:X2}", response.SW2));

                    }
                }
                catch (RemovedCardException)
                {
                    MessageBox.Show("スマートカードが取り外されたため、通信できません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                catch (PCSCException ex)
                {
                    MessageBox.Show(ex.Message, "スマートカードエラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void btn_getccid_Click(object sender, EventArgs e)
        {
            var readerName = comboBoxDevice.Text;
            using (var context = ContextFactory.Instance.Establish(SCardScope.System))
            {
                try
                {
                    using (var isoReader = new IsoReader(context, readerName, SCardShareMode.Shared, SCardProtocol.T0, false))
                    {

                        // Select Master File

                        byte CLA = 0xA0;
                        byte INS = 0xA4;
                        byte P1 = 0x00;
                        byte P2 = 0x00;
                        byte LE = 0x00;
                        byte[] DATA = new byte[2] { 0x3F, 0x00 };



                        // APDUコマンドの作成
                        var apdu = new CommandApdu(IsoCase.Case4Extended, isoReader.ActiveProtocol)
                        {
                            CLA = CLA,
                            INS = INS,
                            P1 = P1,
                            P2 = P2,
                            Data = DATA,
                        };
                        var response = isoReader.Transmit(apdu);



                        dataGridView.Rows.Add(string.Format("{0:X2}", CLA) + ' ' + string.Format("{0:X2}", INS) + ' ' + string.Format("{0:X2}", P1) + ' ' + string.Format("{0:X2}", P2) + ' ' + string.Format("{0:X2}", apdu.Lc) + ' ' + string.Format("{0:X2}", BytesToString(DATA)) + ' ', "SW1 :" + string.Format("{0:X2}", response.SW1) + " SW2: " + string.Format("{0:X2}", response.SW2));

                        // Select ICCID

                        CLA = 0xA0;
                        INS = 0xA4;
                        P1 = 0x00;
                        P2 = 0x00;
                        DATA = new byte[2] { 0x2F, 0xE2 };



                        // APDUコマンドの作成
                        apdu = new CommandApdu(IsoCase.Case4Extended, isoReader.ActiveProtocol)
                        {
                            CLA = CLA,
                            INS = INS,
                            P1 = P1,
                            P2 = P2,
                            Data = DATA,
                        };
                        response = isoReader.Transmit(apdu);



                        dataGridView.Rows.Add(string.Format("{0:X2}", CLA) + ' ' + string.Format("{0:X2}", INS) + ' ' + string.Format("{0:X2}", P1) + ' ' + string.Format("{0:X2}", P2) + ' ' + string.Format("{0:X2}", apdu.Lc) + ' ' + string.Format("{0:X2}", BytesToString(DATA)) + ' ', "SW1 :" + string.Format("{0:X2}", response.SW1) + " SW2: " + string.Format("{0:X2}", response.SW2));

                        // Read the 10 bytes of ICCID EF

                        CLA = 0xA0;
                        INS = 0xB0;
                        P1 = 0x00;
                        P2 = 0x00;
                        LE = 0x0A;



                        // APDUコマンドの作成
                        apdu = new CommandApdu(IsoCase.Case2Extended, isoReader.ActiveProtocol)
                        {
                            CLA = CLA,
                            INS = INS,
                            P1 = P1,
                            P2 = P2,
                            Le = LE
                        };
                        response = isoReader.Transmit(apdu);

                        byte[] iccid = response.GetData();

                        dataGridView.Rows.Add(string.Format("{0:X2}", CLA) + ' ' + string.Format("{0:X2}", INS) + ' ' + string.Format("{0:X2}", P1) + ' ' + string.Format("{0:X2}", P2) + ' ' + string.Format("{0:X2}", LE) + ' ', "SW1 :" + string.Format("{0:X2}", response.SW1) + " SW2: " + string.Format("{0:X2}", response.SW2) + " DATA: " + BytesToString(iccid));

                        txb_iccid.Text = SwapICCID(BytesToString(iccid));


                    }
                }
                catch (RemovedCardException)
                {
                    MessageBox.Show("スマートカードが取り外されたため、通信できません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                catch (PCSCException ex)
                {
                    MessageBox.Show(ex.Message, "スマートカードエラー", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }



        public static string SwapICCID(String str)
        {
            var bs = str.Split(' ');
            string result = "";
            foreach (string value in bs)
            {

                result += value[1];
                result += value[0];

            }
            return result;
        }


        public static string BytesToString(byte[] bs)
        {
            var str = BitConverter.ToString(bs);
            // "-"がいらないなら消しておく
            str = str.Replace("-", " ");
            return str;
        }
        public static byte[] StringToBytes(string str)
        {

            var bs = str.Split(' ').Select(hex => Convert.ToByte(hex, 16));
            return bs.ToArray();
        }
    }


}
