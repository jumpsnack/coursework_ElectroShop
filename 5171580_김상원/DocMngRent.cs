﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace _5171580_김상원
{
    public partial class DocMngRent : DevExpress.XtraEditors.XtraUserControl
    {
        public DocMngRent()
        {
            InitializeComponent();
            gOODSGRADETableAdapter.Fill(dataSet1.GOODSGRADE);}

        private void ActionButtonSync(object sender, EventArgs e)
        {
            gOODSGRADEBindingSource.EndEdit();
            if (gOODSGRADETableAdapter.Update(dataSet1.GOODSGRADE) > 0)
            {
                MessageBox.Show("동기화 성공");
            }
        }
    }
}
