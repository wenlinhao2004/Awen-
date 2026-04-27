using System.IO.Ports;
using System.Text;
namespace WinFormsSerialPort2
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort1 = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Encoding = Encoding.UTF8;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 填充可用串口
            comboBox1.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (var p in ports)
            {
                comboBox1.Items.Add(p);
            }
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            // 默认波特率
            comboBox2.Text = "4800";
            // 事件
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);//手动添加事件
            // 初始控件状态
            button1.Enabled = false; // 发送按钮，仅在端口打开时可用
            button2.Enabled = false; // 关闭按钮
            button3.Enabled = true;  // 打开按钮
        }
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // 跨线程安全地更新 UI
            if (!radioButton1.Checked)
            {
                string str = serialPort1.ReadExisting();//从串口读取数据
                AppendTextSafe(str);
            }
            else
            {
                try
                {
                    int read = serialPort1.ReadByte();
                    if (read >= 0)
                    {
                        byte data = (byte)read;
                        string str = Convert.ToString(data, 16).ToUpper();
                        AppendTextSafe("0x" + (str.Length == 1 ? "0" + str : str) + " ");
                    }
                }
                catch
                {
                    // 忽略读取异常（端口可能已关闭）
                }
            }
        }

        // 安全地在 UI 线程追加文本
        private void AppendTextSafe(string text)
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.BeginInvoke(new Action(() => textBox1.AppendText(text)));
            }
            else
            {
                textBox1.AppendText(text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 打开串口
            if (serialPort1.IsOpen)
                return;

            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("请选择端口", "提示");
                return;
            }

            serialPort1.PortName = comboBox1.Text;
            if (int.TryParse(comboBox2.Text, out int baud))
            {
                serialPort1.BaudRate = baud;
            }
            try
            {
                serialPort1.Open();
                button3.Enabled = false;
                button2.Enabled = true;
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("打开串口失败: " + ex.Message, "错误");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] Data = new byte[1];
            if (serialPort1.IsOpen)
            {
                if (textBox2.Text != "")
                {
                    if (!radioButton2.Checked)
                    {

                        try
                        {
                            serialPort1.WriteLine(textBox2.Text);
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("串口数据输入错误", "错误");
                            serialPort1.Close();
                            button1.Enabled = true;
                            button2.Enabled = false;
                        }

                    }
                    else
                    {
                        try
                        {
                            string hex = textBox2.Text.Trim();
                            int len = hex.Length;
                            for (int i = 0; i < (len - len % 2) / 2; i++)
                            {
                                Data[0] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                                serialPort1.Write(Data, 0, 1);
                            }
                            if (len % 2 != 0)
                            {
                                Data[0] = Convert.ToByte(hex.Substring(len - 1, 1), 16);
                                serialPort1.Write(Data, 0, 1);
                            }
                        }
                        catch (FormatException fe)
                        {
                            MessageBox.Show("十六进制字符串格式错误: " + fe.Message, "错误");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("发送失败: " + ex.Message, "错误");
                        }
                    }
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 关闭串口
            try
            {
                if (serialPort1.IsOpen)
                    serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("关闭串口失败: " + ex.Message, "错误");
            }
            finally
            {
                button3.Enabled = true;
                button2.Enabled = false;
                button1.Enabled = false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1 != null && serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            }
            catch
            {
                // 忽略关闭异常
            }
            base.OnFormClosing(e);
        }
    }
}
