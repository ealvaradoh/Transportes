namespace Transportes
{
    partial class frmCatBuses
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
            System.Windows.Forms.Label cantAsientosLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label placaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatBuses));
            this.cat_BusesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cat_BusesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cantAsientosTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.placaTextBox = new System.Windows.Forms.TextBox();
            this.cat_BusesDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_BusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cantAsientosLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            placaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cat_BusesBindingNavigator)).BeginInit();
            this.cat_BusesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cat_BusesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat_BusesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cantAsientosLabel
            // 
            cantAsientosLabel.AutoSize = true;
            cantAsientosLabel.Location = new System.Drawing.Point(14, 233);
            cantAsientosLabel.Name = "cantAsientosLabel";
            cantAsientosLabel.Size = new System.Drawing.Size(99, 17);
            cantAsientosLabel.TabIndex = 5;
            cantAsientosLabel.Text = "Cant Asientos:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(41, 165);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(45, 17);
            colorLabel.TabIndex = 3;
            colorLabel.Text = "Color:";
            // 
            // placaLabel
            // 
            placaLabel.AutoSize = true;
            placaLabel.Location = new System.Drawing.Point(40, 102);
            placaLabel.Name = "placaLabel";
            placaLabel.Size = new System.Drawing.Size(47, 17);
            placaLabel.TabIndex = 1;
            placaLabel.Text = "Placa:";
            // 
            // cat_BusesBindingNavigator
            // 
            this.cat_BusesBindingNavigator.AddNewItem = null;
            this.cat_BusesBindingNavigator.BindingSource = this.cat_BusesBindingSource;
            this.cat_BusesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cat_BusesBindingNavigator.DeleteItem = null;
            this.cat_BusesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cat_BusesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cat_BusesBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.cat_BusesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cat_BusesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cat_BusesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cat_BusesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cat_BusesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cat_BusesBindingNavigator.Name = "cat_BusesBindingNavigator";
            this.cat_BusesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cat_BusesBindingNavigator.Size = new System.Drawing.Size(662, 27);
            this.cat_BusesBindingNavigator.TabIndex = 8;
            this.cat_BusesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(87, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(87, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // cat_BusesBindingNavigatorSaveItem
            // 
            this.cat_BusesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cat_BusesBindingNavigatorSaveItem.Image")));
            this.cat_BusesBindingNavigatorSaveItem.Name = "cat_BusesBindingNavigatorSaveItem";
            this.cat_BusesBindingNavigatorSaveItem.Size = new System.Drawing.Size(127, 24);
            this.cat_BusesBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // cantAsientosTextBox
            // 
            this.cantAsientosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cat_BusesBindingSource, "CantAsientos", true));
            this.cantAsientosTextBox.Location = new System.Drawing.Point(14, 253);
            this.cantAsientosTextBox.Name = "cantAsientosTextBox";
            this.cantAsientosTextBox.Size = new System.Drawing.Size(178, 22);
            this.cantAsientosTextBox.TabIndex = 6;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cat_BusesBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(14, 185);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(178, 22);
            this.colorTextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cat_BusesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(12, 59);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(178, 22);
            this.idTextBox.TabIndex = 0;
            // 
            // placaTextBox
            // 
            this.placaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cat_BusesBindingSource, "Placa", true));
            this.placaTextBox.Location = new System.Drawing.Point(14, 122);
            this.placaTextBox.Name = "placaTextBox";
            this.placaTextBox.Size = new System.Drawing.Size(178, 22);
            this.placaTextBox.TabIndex = 2;
            // 
            // cat_BusesDataGridView
            // 
            this.cat_BusesDataGridView.AllowUserToAddRows = false;
            this.cat_BusesDataGridView.AllowUserToDeleteRows = false;
            this.cat_BusesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cat_BusesDataGridView.AutoGenerateColumns = false;
            this.cat_BusesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cat_BusesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cat_BusesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cat_BusesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cat_BusesDataGridView.DataSource = this.cat_BusesBindingSource;
            this.cat_BusesDataGridView.Location = new System.Drawing.Point(216, 29);
            this.cat_BusesDataGridView.Name = "cat_BusesDataGridView";
            this.cat_BusesDataGridView.ReadOnly = true;
            this.cat_BusesDataGridView.RowTemplate.Height = 24;
            this.cat_BusesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cat_BusesDataGridView.Size = new System.Drawing.Size(446, 455);
            this.cat_BusesDataGridView.TabIndex = 7;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(90, 24);
            this.toolStripButton1.Text = "Cancelar";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Placa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Placa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn3.HeaderText = "Color";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CantAsientos";
            this.dataGridViewTextBoxColumn4.HeaderText = "CantAsientos";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // cat_BusesBindingSource
            // 
            this.cat_BusesBindingSource.DataSource = typeof(BL.Transportes.BusinessLayer.Cat_Buses);
            // 
            // frmCatBuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 488);
            this.Controls.Add(this.cat_BusesDataGridView);
            this.Controls.Add(cantAsientosLabel);
            this.Controls.Add(this.cantAsientosTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(placaLabel);
            this.Controls.Add(this.placaTextBox);
            this.Controls.Add(this.cat_BusesBindingNavigator);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 535);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 535);
            this.Name = "frmCatBuses";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Buses";
            this.Load += new System.EventHandler(this.frmCatBuses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cat_BusesBindingNavigator)).EndInit();
            this.cat_BusesBindingNavigator.ResumeLayout(false);
            this.cat_BusesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cat_BusesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat_BusesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cat_BusesBindingSource;
        private System.Windows.Forms.BindingNavigator cat_BusesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cat_BusesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cantAsientosTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox placaTextBox;
        private System.Windows.Forms.DataGridView cat_BusesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    }
}