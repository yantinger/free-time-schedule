namespace Project
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.database2DataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet5 = new Project.Database2DataSet5();
            this.database2DataSet3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet3 = new Project.Database2DataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.database2DataSet4 = new Project.Database2DataSet4();
            this.database2DataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet2 = new Project.Database2DataSet2();
            this.database2DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1TableAdapter = new Project.Database2DataSet5TableAdapters.Table1TableAdapter();
            this.tableAdapterManager = new Project.Database2DataSet5TableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(802, 588);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "時 間 && 日 期";
            // 
            // database2DataSet5BindingSource
            // 
            this.database2DataSet5BindingSource.DataSource = this.database2DataSet5;
            this.database2DataSet5BindingSource.Position = 0;
            // 
            // database2DataSet5
            // 
            this.database2DataSet5.DataSetName = "Database2DataSet5";
            this.database2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database2DataSet3BindingSource1
            // 
            this.database2DataSet3BindingSource1.DataSource = this.database2DataSet3;
            this.database2DataSet3BindingSource1.Position = 0;
            // 
            // database2DataSet3
            // 
            this.database2DataSet3.DataSetName = "Database2DataSet3";
            this.database2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(655, 633);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // database2DataSet4
            // 
            this.database2DataSet4.DataSetName = "Database2DataSet4";
            this.database2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database2DataSet4BindingSource
            // 
            this.database2DataSet4BindingSource.DataSource = this.database2DataSet4;
            this.database2DataSet4BindingSource.Position = 0;
            // 
            // database2DataSet3BindingSource
            // 
            this.database2DataSet3BindingSource.DataSource = this.database2DataSet3;
            this.database2DataSet3BindingSource.Position = 0;
            // 
            // database2DataSet2
            // 
            this.database2DataSet2.DataSetName = "Database2DataSet2";
            this.database2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database2DataSet2BindingSource
            // 
            this.database2DataSet2BindingSource.DataSource = this.database2DataSet2;
            this.database2DataSet2BindingSource.Position = 0;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.database2DataSet5;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table1TableAdapter = this.table1TableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.Database2DataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(843, 694);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form3";
            this.Text = "查看結果";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource database2DataSet3BindingSource1;
        private Database2DataSet3 database2DataSet3;
        private Database2DataSet4 database2DataSet4;
        private System.Windows.Forms.BindingSource database2DataSet4BindingSource;
        private System.Windows.Forms.BindingSource database2DataSet3BindingSource;
        private Database2DataSet2 database2DataSet2;
        private System.Windows.Forms.BindingSource database2DataSet2BindingSource;
        private System.Windows.Forms.BindingSource database2DataSet5BindingSource;
        private Database2DataSet5 database2DataSet5;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private Database2DataSet5TableAdapters.Table1TableAdapter table1TableAdapter;
        private Database2DataSet5TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}