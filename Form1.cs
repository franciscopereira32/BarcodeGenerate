﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Barcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntEncode_Click(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter()
            {
                Format = BarcodeFormat.CODE_128
            };
            pic.Image = writer.Write(textEncode.Text);
                                   
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode((Bitmap)pic.Image);
            if (result != null)
                textDecode.Text = result.Text;

        }
    }
}
