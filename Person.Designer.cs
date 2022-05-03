
namespace Профсоюзная_база
{
    partial class Person
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Person));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьРезервнуюКопиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.восстановитьИзРезервнойКопииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номераТелефоновToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.детиСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общественныеОрганизацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявленияСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыЗаявленийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.материальныеВыплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основанияВыплатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.протоколыЗаседенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнениеSQLзапросаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеПоСотрудникуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пенсионерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.детиСотрудниковДо13ЛетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструкцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.членыпрофсоюзаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Профсоюзная_база.DataSet1();
            this.гендерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.члены_профсоюзаTableAdapter = new Профсоюзная_база.DataSet1TableAdapters.Члены_профсоюзаTableAdapter();
            this.гендерTableAdapter = new Профсоюзная_база.DataSet1TableAdapters.ГендерTableAdapter();
            this.должностиTableAdapter = new Профсоюзная_база.DataSet1TableAdapters.ДолжностиTableAdapter();
            this.allPersonTableAdapter = new Профсоюзная_база.DataSet1TableAdapters.AllPersonTableAdapter();
            this.кодЧПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодполаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.коддолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Номер_телефона = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.членыпрофсоюзаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гендерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 511);
            this.panel1.TabIndex = 18;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.членыпрофсоюзаBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(944, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Профсоюзная_база.Properties.Resources.save;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Save";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЧПDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.кодполаDataGridViewTextBoxColumn,
            this.коддолжностиDataGridViewTextBoxColumn,
            this.Номер_телефона});
            this.dataGridView1.DataSource = this.allPersonBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(938, 456);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.таблицыToolStripMenuItem,
            this.операцииToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьРезервнуюКопиюToolStripMenuItem,
            this.восстановитьИзРезервнойКопииToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьРезервнуюКопиюToolStripMenuItem
            // 
            this.создатьРезервнуюКопиюToolStripMenuItem.Name = "создатьРезервнуюКопиюToolStripMenuItem";
            this.создатьРезервнуюКопиюToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.создатьРезервнуюКопиюToolStripMenuItem.Text = "Создать резервную копию";
            // 
            // восстановитьИзРезервнойКопииToolStripMenuItem
            // 
            this.восстановитьИзРезервнойКопииToolStripMenuItem.Name = "восстановитьИзРезервнойКопииToolStripMenuItem";
            this.восстановитьИзРезервнойКопииToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.восстановитьИзРезервнойКопииToolStripMenuItem.Text = "Восстановить из резервной копии";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.типыПользователейToolStripMenuItem,
            this.номераТелефоновToolStripMenuItem,
            this.детиСотрудниковToolStripMenuItem,
            this.общественныеОрганизацииToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.заявленияСотрудниковToolStripMenuItem,
            this.материальныеВыплатыToolStripMenuItem,
            this.протоколыЗаседенийToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            // 
            // типыПользователейToolStripMenuItem
            // 
            this.типыПользователейToolStripMenuItem.Name = "типыПользователейToolStripMenuItem";
            this.типыПользователейToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.типыПользователейToolStripMenuItem.Text = "Типы пользователей";
            // 
            // номераТелефоновToolStripMenuItem
            // 
            this.номераТелефоновToolStripMenuItem.Name = "номераТелефоновToolStripMenuItem";
            this.номераТелефоновToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.номераТелефоновToolStripMenuItem.Text = "Номера телефонов";
            this.номераТелефоновToolStripMenuItem.Click += new System.EventHandler(this.номераТелефоновToolStripMenuItem_Click);
            // 
            // детиСотрудниковToolStripMenuItem
            // 
            this.детиСотрудниковToolStripMenuItem.Name = "детиСотрудниковToolStripMenuItem";
            this.детиСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.детиСотрудниковToolStripMenuItem.Text = "Дети сотрудников";
            // 
            // общественныеОрганизацииToolStripMenuItem
            // 
            this.общественныеОрганизацииToolStripMenuItem.Name = "общественныеОрганизацииToolStripMenuItem";
            this.общественныеОрганизацииToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.общественныеОрганизацииToolStripMenuItem.Text = "Общественные организации";
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.должностиToolStripMenuItem.Text = "Должности";
            // 
            // заявленияСотрудниковToolStripMenuItem
            // 
            this.заявленияСотрудниковToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типыЗаявленийToolStripMenuItem});
            this.заявленияСотрудниковToolStripMenuItem.Name = "заявленияСотрудниковToolStripMenuItem";
            this.заявленияСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.заявленияСотрудниковToolStripMenuItem.Text = "Заявления сотрудников";
            // 
            // типыЗаявленийToolStripMenuItem
            // 
            this.типыЗаявленийToolStripMenuItem.Name = "типыЗаявленийToolStripMenuItem";
            this.типыЗаявленийToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.типыЗаявленийToolStripMenuItem.Text = "Типы заявлений";
            // 
            // материальныеВыплатыToolStripMenuItem
            // 
            this.материальныеВыплатыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основанияВыплатToolStripMenuItem});
            this.материальныеВыплатыToolStripMenuItem.Name = "материальныеВыплатыToolStripMenuItem";
            this.материальныеВыплатыToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.материальныеВыплатыToolStripMenuItem.Text = "Материальные выплаты";
            // 
            // основанияВыплатToolStripMenuItem
            // 
            this.основанияВыплатToolStripMenuItem.Name = "основанияВыплатToolStripMenuItem";
            this.основанияВыплатToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.основанияВыплатToolStripMenuItem.Text = "Основания выплат";
            // 
            // протоколыЗаседенийToolStripMenuItem
            // 
            this.протоколыЗаседенийToolStripMenuItem.Name = "протоколыЗаседенийToolStripMenuItem";
            this.протоколыЗаседенийToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.протоколыЗаседенийToolStripMenuItem.Text = "Протоколы заседений";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выполнениеSQLзапросаToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // выполнениеSQLзапросаToolStripMenuItem
            // 
            this.выполнениеSQLзапросаToolStripMenuItem.Name = "выполнениеSQLзапросаToolStripMenuItem";
            this.выполнениеSQLзапросаToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.выполнениеSQLзапросаToolStripMenuItem.Text = "Выполнение SQL-запроса";
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеПоСотрудникуToolStripMenuItem,
            this.пенсионерыToolStripMenuItem,
            this.детиСотрудниковДо13ЛетToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // данныеПоСотрудникуToolStripMenuItem
            // 
            this.данныеПоСотрудникуToolStripMenuItem.Name = "данныеПоСотрудникуToolStripMenuItem";
            this.данныеПоСотрудникуToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.данныеПоСотрудникуToolStripMenuItem.Text = "Данные по сотрудникам";
            // 
            // пенсионерыToolStripMenuItem
            // 
            this.пенсионерыToolStripMenuItem.Name = "пенсионерыToolStripMenuItem";
            this.пенсионерыToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.пенсионерыToolStripMenuItem.Text = "Пенсионеры";
            // 
            // детиСотрудниковДо13ЛетToolStripMenuItem
            // 
            this.детиСотрудниковДо13ЛетToolStripMenuItem.Name = "детиСотрудниковДо13ЛетToolStripMenuItem";
            this.детиСотрудниковДо13ЛетToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.детиСотрудниковДо13ЛетToolStripMenuItem.Text = "Дети сотрудников до13 лет";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.инструкцияToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // инструкцияToolStripMenuItem
            // 
            this.инструкцияToolStripMenuItem.Name = "инструкцияToolStripMenuItem";
            this.инструкцияToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.инструкцияToolStripMenuItem.Text = "Инструкция";
            // 
            // членыпрофсоюзаBindingSource
            // 
            this.членыпрофсоюзаBindingSource.DataMember = "Члены_профсоюза";
            this.членыпрофсоюзаBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // гендерBindingSource
            // 
            this.гендерBindingSource.DataMember = "Гендер";
            this.гендерBindingSource.DataSource = this.dataSet1;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.dataSet1;
            // 
            // allPersonBindingSource
            // 
            this.allPersonBindingSource.DataMember = "AllPerson";
            this.allPersonBindingSource.DataSource = this.dataSet1;
            // 
            // члены_профсоюзаTableAdapter
            // 
            this.члены_профсоюзаTableAdapter.ClearBeforeFill = true;
            // 
            // гендерTableAdapter
            // 
            this.гендерTableAdapter.ClearBeforeFill = true;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // allPersonTableAdapter
            // 
            this.allPersonTableAdapter.ClearBeforeFill = true;
            // 
            // кодЧПDataGridViewTextBoxColumn
            // 
            this.кодЧПDataGridViewTextBoxColumn.DataPropertyName = "Код_ЧП";
            this.кодЧПDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.кодЧПDataGridViewTextBoxColumn.Name = "кодЧПDataGridViewTextBoxColumn";
            this.кодЧПDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодЧПDataGridViewTextBoxColumn.Width = 50;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            this.фамилияDataGridViewTextBoxColumn.Width = 120;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            this.имяDataGridViewTextBoxColumn.Width = 120;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            this.отчествоDataGridViewTextBoxColumn.Width = 120;
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            this.датарожденияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодполаDataGridViewTextBoxColumn
            // 
            this.кодполаDataGridViewTextBoxColumn.DataPropertyName = "Код_пола";
            this.кодполаDataGridViewTextBoxColumn.DataSource = this.гендерBindingSource;
            this.кодполаDataGridViewTextBoxColumn.DisplayMember = "Пол";
            this.кодполаDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.кодполаDataGridViewTextBoxColumn.Name = "кодполаDataGridViewTextBoxColumn";
            this.кодполаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодполаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодполаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодполаDataGridViewTextBoxColumn.ValueMember = "Код_пола";
            // 
            // коддолжностиDataGridViewTextBoxColumn
            // 
            this.коддолжностиDataGridViewTextBoxColumn.DataPropertyName = "Код_должности";
            this.коддолжностиDataGridViewTextBoxColumn.DataSource = this.должностиBindingSource;
            this.коддолжностиDataGridViewTextBoxColumn.DisplayMember = "Должность";
            this.коддолжностиDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.коддолжностиDataGridViewTextBoxColumn.Name = "коддолжностиDataGridViewTextBoxColumn";
            this.коддолжностиDataGridViewTextBoxColumn.ReadOnly = true;
            this.коддолжностиDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.коддолжностиDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.коддолжностиDataGridViewTextBoxColumn.ValueMember = "Код_должности";
            this.коддолжностиDataGridViewTextBoxColumn.Width = 150;
            // 
            // Номер_телефона
            // 
            this.Номер_телефона.DataPropertyName = "Номер_телефона";
            this.Номер_телефона.HeaderText = "Номер_телефона";
            this.Номер_телефона.Name = "Номер_телефона";
            this.Номер_телефона.ReadOnly = true;
            this.Номер_телефона.Width = 130;
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 511);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(910, 550);
            this.Name = "Person";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.членыпрофсоюзаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гендерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPersonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource членыпрофсоюзаBindingSource;
        private DataSet1TableAdapters.Члены_профсоюзаTableAdapter члены_профсоюзаTableAdapter;
        private System.Windows.Forms.BindingSource гендерBindingSource;
        private DataSet1TableAdapters.ГендерTableAdapter гендерTableAdapter;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private DataSet1TableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьРезервнуюКопиюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem восстановитьИзРезервнойКопииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem детиСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общественныеОрганизацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявленияСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыЗаявленийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материальныеВыплатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основанияВыплатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem протоколыЗаседенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнениеSQLзапросаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеПоСотрудникуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пенсионерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem детиСотрудниковДо13ЛетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструкцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номераТелефоновToolStripMenuItem;
        private System.Windows.Forms.BindingSource allPersonBindingSource;
        private DataSet1TableAdapters.AllPersonTableAdapter allPersonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЧПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодполаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn коддолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер_телефона;
    }
}

