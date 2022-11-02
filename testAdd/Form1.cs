using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;


namespace testAdd
{
    public partial class Form1 : Form
    {
                   //dll名称     //dll中入口点的名称   //入口点的调用约定
        [DllImport("add.dll", EntryPoint = "DemoAdd", CallingConvention = CallingConvention.Cdecl)]
        //CallingConvention = CallingConvention.Cdecl 意味着参数可变长
        public static extern int Add(int lA, int lB);


        [DllImport("add.dll", EntryPoint = "DemoSub", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Sub(int lA, int lB);


        [DllImport("add.dll", EntryPoint = "DemoMul", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Mul(int lA, int lB);


        [DllImport("add.dll", EntryPoint = "DemoDiv", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Div(int lA, int lB);


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int a = (int)numericUpDown1.Value;
            int b = (int)numericUpDown2.Value;
            int c = Add(a, b);
            textBox1.Text = c.ToString();

            textBox2.Text = Sub(a, b).ToString();

            textBox3.Text = Mul(a, b).ToString();

            textBox4.Text = Div(a, b).ToString();
        }
    }
}
