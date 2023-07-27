
namespace paw_proiect_tiketing
{
    partial class Introducere_Task_uri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumeTask = new System.Windows.Forms.TextBox();
            this.btnAdaugaTask = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStergere = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbComplet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti task-ul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduceti data limita pentru rezolvarea task-ului";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Task-ul este complet?";
            // 
            // tbNumeTask
            // 
            this.tbNumeTask.Location = new System.Drawing.Point(489, 70);
            this.tbNumeTask.Name = "tbNumeTask";
            this.tbNumeTask.Size = new System.Drawing.Size(200, 22);
            this.tbNumeTask.TabIndex = 3;
            // 
            // btnAdaugaTask
            // 
            this.btnAdaugaTask.Location = new System.Drawing.Point(66, 318);
            this.btnAdaugaTask.Name = "btnAdaugaTask";
            this.btnAdaugaTask.Size = new System.Drawing.Size(161, 34);
            this.btnAdaugaTask.TabIndex = 7;
            this.btnAdaugaTask.Text = "Adauga";
            this.btnAdaugaTask.UseVisualStyleBackColor = true;
            this.btnAdaugaTask.Click += new System.EventHandler(this.btnAdaugaTask_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(767, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(534, 359);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Task_denumire";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "EsteComplet";
            this.columnHeader3.Width = 231;
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(393, 318);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(168, 34);
            this.btnStergere.TabIndex = 9;
            this.btnStergere.Text = "Sterge task";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(489, 135);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(200, 22);
            this.tbData.TabIndex = 10;
            // 
            // tbComplet
            // 
            this.tbComplet.Location = new System.Drawing.Point(489, 202);
            this.tbComplet.Name = "tbComplet";
            this.tbComplet.Size = new System.Drawing.Size(200, 22);
            this.tbComplet.TabIndex = 11;
            // 
            // Introducere_Task_uri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 444);
            this.Controls.Add(this.tbComplet);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAdaugaTask);
            this.Controls.Add(this.tbNumeTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Introducere_Task_uri";
            this.Text = "Introducere_Task_uri";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumeTask;
        private System.Windows.Forms.Button btnAdaugaTask;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.TextBox tbComplet;
        private System.Windows.Forms.TextBox tbData;
    }
}