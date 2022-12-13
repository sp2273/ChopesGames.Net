
namespace ChopesGames
{
    partial class FormModifierProduit
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
            this.lvCommandes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvCommandes
            // 
            this.lvCommandes.HideSelection = false;
            this.lvCommandes.Location = new System.Drawing.Point(206, 87);
            this.lvCommandes.Name = "lvCommandes";
            this.lvCommandes.Size = new System.Drawing.Size(388, 277);
            this.lvCommandes.TabIndex = 3;
            this.lvCommandes.UseCompatibleStateImageBehavior = false;
            // 
            // FormModifierProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvCommandes);
            this.Name = "FormModifierProduit";
            this.Text = "FormModifierProduit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCommandes;
    }
}