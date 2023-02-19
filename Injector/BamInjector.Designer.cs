namespace Injector
{
    partial class BamInjector
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BamInjector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Inject = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.inputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_Inject);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 426);
            this.panel1.TabIndex = 0;
            // 
            // btn_Inject
            // 
            this.btn_Inject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Inject.FlatAppearance.BorderSize = 0;
            this.btn_Inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inject.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inject.ForeColor = System.Drawing.Color.Black;
            this.btn_Inject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inject.Location = new System.Drawing.Point(185, 329);
            this.btn_Inject.Name = "btn_Inject";
            this.btn_Inject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Inject.Size = new System.Drawing.Size(231, 49);
            this.btn_Inject.TabIndex = 2;
            this.btn_Inject.Text = "Inject";
            this.btn_Inject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Inject.UseVisualStyleBackColor = false;
            this.btn_Inject.Click += new System.EventHandler(this.btn_Inject_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.progressBar1.Location = new System.Drawing.Point(32, 384);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(516, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 80;
            // 
            // inputFileDialog
            // 
            this.inputFileDialog.FileName = "inputFile";
            this.inputFileDialog.InitialDirectory = "..";
            this.inputFileDialog.Title = "InputFileDialog";
            this.inputFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // BamInjector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BamInjector";
            this.Text = "BamInjector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog inputFileDialog;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_Inject;
    }
}

