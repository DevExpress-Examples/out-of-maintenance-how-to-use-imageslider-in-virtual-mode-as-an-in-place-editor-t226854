Imports DevExpress.Utils
Imports DevExpress.XtraEditors.CustomEditor
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsFormsApplication202
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = GetData(3)
			ImageSliderHelper.BindImageSlider(gridControl1, "Image", MoscowImages, NewYorkImages, ParisImages)
		End Sub
		Private Function GetData(ByVal rows As Integer) As DataTable
			Dim dt As New DataTable()
			dt.Columns.Add("Description", GetType(String))
			dt.Columns.Add("Image", GetType(Image))
			dt.Rows.Add("Moscow", imageCollection1.Images(0))
			dt.Rows.Add("NewYork", imageCollection1.Images(1))
			dt.Rows.Add("Paris", imageCollection1.Images(2))
			Return dt
		End Function
	End Class
End Namespace
