namespace wfaTodoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvNames = new System.Windows.Forms.ListView();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buAdd = new System.Windows.Forms.Button();
            this.buSave = new System.Windows.Forms.Button();
            this.buCancel = new System.Windows.Forms.Button();
            this.buDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvNames
            // 
            this.lvNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvNames.Location = new System.Drawing.Point(12, 46);
            this.lvNames.MultiSelect = false;
            this.lvNames.Name = "lvNames";
            this.lvNames.Size = new System.Drawing.Size(273, 392);
            this.lvNames.TabIndex = 0;
            this.lvNames.TabStop = false;
            this.lvNames.UseCompatibleStateImageBehavior = false;
            this.lvNames.View = System.Windows.Forms.View.List;
            // 
            // cbTypes
            // 
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(12, 12);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(273, 28);
            this.cbTypes.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(444, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(344, 27);
            this.tbName.TabIndex = 2;
            // 
            // tbType
            // 
            this.tbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbType.Location = new System.Drawing.Point(444, 45);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(344, 27);
            this.tbType.TabIndex = 3;
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(444, 78);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(344, 308);
            this.tbText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тип";
            // 
            // buAdd
            // 
            this.buAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buAdd.Location = new System.Drawing.Point(394, 392);
            this.buAdd.Name = "buAdd";
            this.buAdd.Size = new System.Drawing.Size(94, 29);
            this.buAdd.TabIndex = 7;
            this.buAdd.Text = "Добавить";
            this.buAdd.UseVisualStyleBackColor = true;
            // 
            // buSave
            // 
            this.buSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buSave.Location = new System.Drawing.Point(594, 392);
            this.buSave.Name = "buSave";
            this.buSave.Size = new System.Drawing.Size(94, 29);
            this.buSave.TabIndex = 8;
            this.buSave.Text = "Сохранить";
            this.buSave.UseVisualStyleBackColor = true;
            // 
            // buCancel
            // 
            this.buCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buCancel.Location = new System.Drawing.Point(694, 392);
            this.buCancel.Name = "buCancel";
            this.buCancel.Size = new System.Drawing.Size(94, 29);
            this.buCancel.TabIndex = 9;
            this.buCancel.Text = "Отмена";
            this.buCancel.UseVisualStyleBackColor = true;
            // 
            // buDelete
            // 
            this.buDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buDelete.Location = new System.Drawing.Point(494, 392);
            this.buDelete.Name = "buDelete";
            this.buDelete.Size = new System.Drawing.Size(94, 29);
            this.buDelete.TabIndex = 10;
            this.buDelete.Text = "Удалить";
            this.buDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buDelete);
            this.Controls.Add(this.buCancel);
            this.Controls.Add(this.buSave);
            this.Controls.Add(this.buAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbTypes);
            this.Controls.Add(this.lvNames);
            this.Name = "Form1";
            this.Text = "wfaTodoList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvNames;
        private ComboBox cbTypes;
        private TextBox tbName;
        private TextBox tbType;
        private TextBox tbText;
        private Label label1;
        private Label label2;
        private Button buAdd;
        private Button buSave;
        private Button buCancel;
        private Button buDelete;
    }
}