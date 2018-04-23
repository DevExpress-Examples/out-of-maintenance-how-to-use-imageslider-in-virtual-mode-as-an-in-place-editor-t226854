Namespace WindowsFormsApplication202
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.MoscowImages = New DevExpress.Utils.ImageCollection(Me.components)
			Me.NewYorkImages = New DevExpress.Utils.ImageCollection(Me.components)
			Me.ParisImages = New DevExpress.Utils.ImageCollection(Me.components)
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.MoscowImages, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.NewYorkImages, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ParisImages, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(819, 654)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridView1.Appearance.Row.Options.UseFont = True
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageSize = New System.Drawing.Size(280, 180)
			Me.imageCollection1.ImageStream = (DirectCast(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "Saint-Basils-Cathedral.jpg")
			Me.imageCollection1.Images.SetKeyName(1, "Statue-of-Liberty.jpg")
			Me.imageCollection1.Images.SetKeyName(2, "Eiffel-Tower.jpg")
			' 
			' MoscowImages
			' 
			Me.MoscowImages.ImageSize = New System.Drawing.Size(280, 180)
			Me.MoscowImages.ImageStream = (DirectCast(resources.GetObject("MoscowImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.MoscowImages.Images.SetKeyName(0, "Saint-Basils-Cathedral.jpg")
			Me.MoscowImages.Images.SetKeyName(1, "Bolshoi-Theatre.jpg")
			Me.MoscowImages.Images.SetKeyName(2, "Cathedral-of-Christ-the-Saviour.jpg")
			Me.MoscowImages.Images.SetKeyName(3, "Novodevichy-Convent.jpg")
			Me.MoscowImages.Images.SetKeyName(4, "Ostankino-Tower.jpg")
			Me.MoscowImages.Images.SetKeyName(5, "Spasskaya-Tower.jpg")
			' 
			' NewYorkImages
			' 
			Me.NewYorkImages.ImageSize = New System.Drawing.Size(280, 180)
			Me.NewYorkImages.ImageStream = (DirectCast(resources.GetObject("NewYorkImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.NewYorkImages.Images.SetKeyName(0, "Statue-of-Liberty.jpg")
			Me.NewYorkImages.Images.SetKeyName(1, "Broadway.jpg")
			Me.NewYorkImages.Images.SetKeyName(2, "Brooklyn-Bridge.jpg")
			Me.NewYorkImages.Images.SetKeyName(3, "Empire-State-Building.jpg")
			Me.NewYorkImages.Images.SetKeyName(4, "Rockefeller-Center.jpg")
			Me.NewYorkImages.Images.SetKeyName(5, "Times-Square.jpg")
			' 
			' ParisImages
			' 
			Me.ParisImages.ImageSize = New System.Drawing.Size(280, 180)
			Me.ParisImages.ImageStream = (DirectCast(resources.GetObject("ParisImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.ParisImages.Images.SetKeyName(0, "Eiffel-Tower.jpg")
			Me.ParisImages.Images.SetKeyName(1, "Arc-de-Triomphe.jpg")
			Me.ParisImages.Images.SetKeyName(2, "Louvre.jpg")
			Me.ParisImages.Images.SetKeyName(3, "Montmartre.jpg")
			Me.ParisImages.Images.SetKeyName(4, "Notre-Dame-de-Paris.jpg")
			Me.ParisImages.Images.SetKeyName(5, "Sainte-Chapelle.jpg")
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(819, 654)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "ImageSliderInplace"
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.MoscowImages, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.NewYorkImages, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ParisImages, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private MoscowImages As DevExpress.Utils.ImageCollection
		Private NewYorkImages As DevExpress.Utils.ImageCollection
		Private ParisImages As DevExpress.Utils.ImageCollection
	End Class
End Namespace

