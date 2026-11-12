using System.Diagnostics.Eventing.Reader;

namespace Tutorial_5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal RATE = 0.005m;  
            Decimal balance;
            int months;


            if (decimal.TryParse(textBox1.Text, out balance))
            {
                if (int.TryParse(textBox2.Text, out months))
                {
                    int count = 1;
                    while (count <= months)
                    {
                        balance = balance * (1 + RATE);
                        listBox1.Items.Add($"第 {count}個月的本利和 : {balance:C2}");
                        count++;
                    }
                }
                else
                {
                    MessageBox.Show("請輸入有效的月份數字。");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的起始餘額。");
            }
         textBox3.Text = balance.ToString("C2");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listBox1.Items.Clear();
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 設定 TextBox 的初始值為空字串
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty; listBox1.Items.Clear(); }
          