using DevExpress.Utils;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication202 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            gridControl1.DataSource = GetData(3);
            ImageSliderHelper.BindImageSlider(gridControl1, "Image", MoscowImages, NewYorkImages, ParisImages);
        }
        DataTable GetData(int rows) {
            DataTable dt = new DataTable();
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Image", typeof(Image));
            dt.Rows.Add("Moscow", imageCollection1.Images[0]);
            dt.Rows.Add("NewYork", imageCollection1.Images[1]);
            dt.Rows.Add("Paris", imageCollection1.Images[2]);
            return dt;
        }
    }
}
