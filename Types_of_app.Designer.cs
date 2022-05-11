
namespace Профсоюзная_база
{
    partial class Types_of_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Types_of_app));
            this.dataSet1 = new Профсоюзная_база.DataSet1();
            this.типы_заявленийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типы_заявленийTableAdapter = new Профсоюзная_база.DataSet1TableAdapters.Типы_заявленийTableAdapter();
            this.tableAdapterManager = new Профсоюзная_база.DataSet1TableAdapters.TableAdapterManager();
            this.типы_заявленийBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.типы_заявленийBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.типы_заявленийDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_заявленийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_заявленийBindingNavigator)).BeginInit();
            this.типы_заявленийBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типы_заявленийDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // типы_заявленийBindingSource
            // 
            this.типы_заявленийBindingSource.DataMember = "Типы_заявлений";
            this.типы_заявленийBindingSource.DataSource = this.dataSet1;
            // 
            // типы_заявленийTableAdapter
            // 
            this.типы_заявленийTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Профсоюзная_база.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГендерTableAdapter = null;
            this.tableAdapterManager.Дети_родителиTableAdapter = null;
            this.tableAdapterManager.ДетиTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЗаявленияTableAdapter = null;
            this.tableAdapterManager.Материальная_выплатаTableAdapter = null;
            this.tableAdapterManager.Общественные_организацииTableAdapter = null;
            this.tableAdapterManager.ОО_ЧПTableAdapter = null;
            this.tableAdapterManager.Основания_МПTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.Протоколы_заседанийTableAdapter = null;
            this.tableAdapterManager.ТелефоныTableAdapter = null;
            this.tableAdapterManager.Типы_заявленийTableAdapter = this.типы_заявленийTableAdapter;
            this.tableAdapterManager.Типы_пользователяTableAdapter = null;
            this.tableAdapterManager.Члены_профсоюзаTableAdapter = null;
            // 
            // типы_заявленийBindingNavigator
            // 
            this.типы_заявленийBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.типы_заявленийBindingNavigator.BindingSource = this.типы_заявленийBindingSource;
            this.типы_заявленийBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.типы_заявленийBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.типы_заявленийBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.типы_заявленийBindingNavigatorSaveItem});
            this.типы_заявленийBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.типы_заявленийBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.типы_заявленийBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.типы_заявленийBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.типы_заявленийBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.типы_заявленийBindingNavigator.Name = "типы_заявленийBindingNavigator";
            this.типы_заявленийBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.типы_заявленийBindingNavigator.Size = new System.Drawing.Size(435, 25);
            this.типы_заявленийBindingNavigator.TabIndex = 0;
            this.типы_заявленийBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // типы_заявленийBindingNavigatorSaveItem
            // 
            this.типы_заявленийBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.типы_заявленийBindingNavigatorSaveItem.Image = global::Профсоюзная_база.Properties.Resources.save;
            this.типы_заявленийBindingNavigatorSaveItem.Name = "типы_заявленийBindingNavigatorSaveItem";
            this.типы_заявленийBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.типы_заявленийBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.типы_заявленийBindingNavigatorSaveItem.Click += new System.EventHandler(this.типы_заявленийBindingNavigatorSaveItem_Click);
            // 
            // типы_заявленийDataGridView
            // 
            this.типы_заявленийDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.типы_заявленийDataGridView.AutoGenerateColumns = false;
            this.типы_заявленийDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.типы_заявленийDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.типы_заявленийDataGridView.DataSource = this.типы_заявленийBindingSource;
            this.типы_заявленийDataGridView.Location = new System.Drawing.Point(0, 28);
            this.типы_заявленийDataGridView.Name = "типы_заявленийDataGridView";
            this.типы_заявленийDataGridView.Size = new System.Drawing.Size(435, 307);
            this.типы_заявленийDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_ТЗ";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номера";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Тип_заявления";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип_заявления";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Types_of_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 338);
            this.Controls.Add(this.типы_заявленийDataGridView);
            this.Controls.Add(this.типы_заявленийBindingNavigator);
            this.Name = "Types_of_app";
            this.Text = "Типы заявлений";
            this.Load += new System.EventHandler(this.Types_of_app_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_заявленийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типы_заявленийBindingNavigator)).EndInit();
            this.типы_заявленийBindingNavigator.ResumeLayout(false);
            this.типы_заявленийBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типы_заявленийDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource типы_заявленийBindingSource;
        private DataSet1TableAdapters.Типы_заявленийTableAdapter типы_заявленийTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator типы_заявленийBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton типы_заявленийBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView типы_заявленийDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}