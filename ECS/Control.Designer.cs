
namespace ECS
{
    partial class Control
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
            this.btnAddDefault = new System.Windows.Forms.Button();
            this.lbAllComp = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEntityComp = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbX = new System.Windows.Forms.MaskedTextBox();
            this.mtbY = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnChangeTexture = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddDefault
            // 
            this.btnAddDefault.Location = new System.Drawing.Point(3, 3);
            this.btnAddDefault.Name = "btnAddDefault";
            this.btnAddDefault.Size = new System.Drawing.Size(75, 23);
            this.btnAddDefault.TabIndex = 0;
            this.btnAddDefault.Text = "Add Entity";
            this.btnAddDefault.UseVisualStyleBackColor = true;
            this.btnAddDefault.Click += new System.EventHandler(this.btnAddDefault_Click);
            // 
            // lbAllComp
            // 
            this.lbAllComp.FormattingEnabled = true;
            this.lbAllComp.Location = new System.Drawing.Point(12, 115);
            this.lbAllComp.Name = "lbAllComp";
            this.lbAllComp.Size = new System.Drawing.Size(112, 160);
            this.lbAllComp.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mtbY);
            this.panel1.Controls.Add(this.mtbX);
            this.panel1.Controls.Add(this.btnAddDefault);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 29);
            this.panel1.TabIndex = 2;
            // 
            // lbEntityComp
            // 
            this.lbEntityComp.FormattingEnabled = true;
            this.lbEntityComp.Location = new System.Drawing.Point(172, 115);
            this.lbEntityComp.Name = "lbEntityComp";
            this.lbEntityComp.Size = new System.Drawing.Size(112, 160);
            this.lbEntityComp.TabIndex = 3;
            this.lbEntityComp.SelectedIndexChanged += new System.EventHandler(this.lbEntityComp_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(130, 198);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(36, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "<-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(130, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "->";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Available \r\nComponents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Entity \r\nComponents";
            // 
            // mtbX
            // 
            this.mtbX.Location = new System.Drawing.Point(84, 5);
            this.mtbX.Mask = "0000";
            this.mtbX.Name = "mtbX";
            this.mtbX.Size = new System.Drawing.Size(91, 20);
            this.mtbX.TabIndex = 1;
            // 
            // mtbY
            // 
            this.mtbY.Location = new System.Drawing.Point(178, 5);
            this.mtbY.Mask = "0000";
            this.mtbY.Name = "mtbY";
            this.mtbY.Size = new System.Drawing.Size(91, 20);
            this.mtbY.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Create Default Entity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangeTexture);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 73);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Image";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "dirt",
            "grass"});
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnChangeTexture
            // 
            this.btnChangeTexture.Location = new System.Drawing.Point(160, 19);
            this.btnChangeTexture.Name = "btnChangeTexture";
            this.btnChangeTexture.Size = new System.Drawing.Size(94, 23);
            this.btnChangeTexture.TabIndex = 1;
            this.btnChangeTexture.Text = "Change";
            this.btnChangeTexture.UseVisualStyleBackColor = true;
            this.btnChangeTexture.Click += new System.EventHandler(this.btnChangeTexture_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbEntityComp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbAllComp);
            this.Name = "Control";
            this.Text = "Control";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDefault;
        private System.Windows.Forms.ListBox lbAllComp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbEntityComp;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbY;
        private System.Windows.Forms.MaskedTextBox mtbX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangeTexture;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}