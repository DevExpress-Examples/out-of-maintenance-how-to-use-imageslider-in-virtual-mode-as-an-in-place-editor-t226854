namespace WindowsFormsApplication202 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.MoscowImages = new DevExpress.Utils.ImageCollection(this.components);
            this.NewYorkImages = new DevExpress.Utils.ImageCollection(this.components);
            this.ParisImages = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoscowImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewYorkImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParisImages)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(819, 654);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(280, 180);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Saint-Basils-Cathedral.jpg");
            this.imageCollection1.Images.SetKeyName(1, "Statue-of-Liberty.jpg");
            this.imageCollection1.Images.SetKeyName(2, "Eiffel-Tower.jpg");
            // 
            // MoscowImages
            // 
            this.MoscowImages.ImageSize = new System.Drawing.Size(280, 180);
            this.MoscowImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("MoscowImages.ImageStream")));
            this.MoscowImages.Images.SetKeyName(0, "Saint-Basils-Cathedral.jpg");
            this.MoscowImages.Images.SetKeyName(1, "Bolshoi-Theatre.jpg");
            this.MoscowImages.Images.SetKeyName(2, "Cathedral-of-Christ-the-Saviour.jpg");
            this.MoscowImages.Images.SetKeyName(3, "Novodevichy-Convent.jpg");
            this.MoscowImages.Images.SetKeyName(4, "Ostankino-Tower.jpg");
            this.MoscowImages.Images.SetKeyName(5, "Spasskaya-Tower.jpg");
            // 
            // NewYorkImages
            // 
            this.NewYorkImages.ImageSize = new System.Drawing.Size(280, 180);
            this.NewYorkImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("NewYorkImages.ImageStream")));
            this.NewYorkImages.Images.SetKeyName(0, "Statue-of-Liberty.jpg");
            this.NewYorkImages.Images.SetKeyName(1, "Broadway.jpg");
            this.NewYorkImages.Images.SetKeyName(2, "Brooklyn-Bridge.jpg");
            this.NewYorkImages.Images.SetKeyName(3, "Empire-State-Building.jpg");
            this.NewYorkImages.Images.SetKeyName(4, "Rockefeller-Center.jpg");
            this.NewYorkImages.Images.SetKeyName(5, "Times-Square.jpg");
            // 
            // ParisImages
            // 
            this.ParisImages.ImageSize = new System.Drawing.Size(280, 180);
            this.ParisImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ParisImages.ImageStream")));
            this.ParisImages.Images.SetKeyName(0, "Eiffel-Tower.jpg");
            this.ParisImages.Images.SetKeyName(1, "Arc-de-Triomphe.jpg");
            this.ParisImages.Images.SetKeyName(2, "Louvre.jpg");
            this.ParisImages.Images.SetKeyName(3, "Montmartre.jpg");
            this.ParisImages.Images.SetKeyName(4, "Notre-Dame-de-Paris.jpg");
            this.ParisImages.Images.SetKeyName(5, "Sainte-Chapelle.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 654);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "ImageSliderInplace";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoscowImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewYorkImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParisImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.Utils.ImageCollection MoscowImages;
        private DevExpress.Utils.ImageCollection NewYorkImages;
        private DevExpress.Utils.ImageCollection ParisImages;
    }
}

