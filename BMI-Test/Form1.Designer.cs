namespace BMI_Test
{
    partial class mainWindow
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.peopleLabel = new System.Windows.Forms.Label();
            this.peopleAddButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.personNameLabel = new System.Windows.Forms.Label();
            this.personWeightLabel = new System.Windows.Forms.Label();
            this.personHeightLabel = new System.Windows.Forms.Label();
            this.personBmiLabel = new System.Windows.Forms.Label();
            this.personBmiCategoryLabel = new System.Windows.Forms.Label();
            this.personNameDisplay = new System.Windows.Forms.Label();
            this.personWeightDisplay = new System.Windows.Forms.Label();
            this.personHeightDisplay = new System.Windows.Forms.Label();
            this.personBmiDisplay = new System.Windows.Forms.Label();
            this.personBmiCategoryDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peopleLabel.Location = new System.Drawing.Point(12, 9);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(115, 55);
            this.peopleLabel.TabIndex = 0;
            this.peopleLabel.Text = "Lidé";
            this.peopleLabel.Click += new System.EventHandler(this.peopleLabel_Click);
            // 
            // peopleAddButton
            // 
            this.peopleAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peopleAddButton.Location = new System.Drawing.Point(133, 12);
            this.peopleAddButton.Name = "peopleAddButton";
            this.peopleAddButton.Size = new System.Drawing.Size(98, 52);
            this.peopleAddButton.TabIndex = 1;
            this.peopleAddButton.Text = "Přidat";
            this.peopleAddButton.UseVisualStyleBackColor = true;
            this.peopleAddButton.Click += new System.EventHandler(this.peopleAddButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 199);
            this.listBox1.TabIndex = 2;
            // 
            // personNameLabel
            // 
            this.personNameLabel.AutoSize = true;
            this.personNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personNameLabel.Location = new System.Drawing.Point(252, 13);
            this.personNameLabel.Name = "personNameLabel";
            this.personNameLabel.Size = new System.Drawing.Size(103, 31);
            this.personNameLabel.TabIndex = 3;
            this.personNameLabel.Text = "Jméno:";
            // 
            // personWeightLabel
            // 
            this.personWeightLabel.AutoSize = true;
            this.personWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personWeightLabel.Location = new System.Drawing.Point(252, 44);
            this.personWeightLabel.Name = "personWeightLabel";
            this.personWeightLabel.Size = new System.Drawing.Size(139, 31);
            this.personWeightLabel.TabIndex = 4;
            this.personWeightLabel.Text = "Hmotnost:";
            // 
            // personHeightLabel
            // 
            this.personHeightLabel.AutoSize = true;
            this.personHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personHeightLabel.Location = new System.Drawing.Point(252, 75);
            this.personHeightLabel.Name = "personHeightLabel";
            this.personHeightLabel.Size = new System.Drawing.Size(97, 31);
            this.personHeightLabel.TabIndex = 5;
            this.personHeightLabel.Text = "Výška:";
            // 
            // personBmiLabel
            // 
            this.personBmiLabel.AutoSize = true;
            this.personBmiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personBmiLabel.Location = new System.Drawing.Point(252, 107);
            this.personBmiLabel.Name = "personBmiLabel";
            this.personBmiLabel.Size = new System.Drawing.Size(70, 31);
            this.personBmiLabel.TabIndex = 6;
            this.personBmiLabel.Text = "BMI:";
            // 
            // personBmiCategoryLabel
            // 
            this.personBmiCategoryLabel.AutoSize = true;
            this.personBmiCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personBmiCategoryLabel.Location = new System.Drawing.Point(252, 138);
            this.personBmiCategoryLabel.Name = "personBmiCategoryLabel";
            this.personBmiCategoryLabel.Size = new System.Drawing.Size(138, 31);
            this.personBmiCategoryLabel.TabIndex = 7;
            this.personBmiCategoryLabel.Text = "Kategorie:";
            // 
            // personNameDisplay
            // 
            this.personNameDisplay.AutoSize = true;
            this.personNameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personNameDisplay.Location = new System.Drawing.Point(397, 13);
            this.personNameDisplay.Name = "personNameDisplay";
            this.personNameDisplay.Size = new System.Drawing.Size(0, 31);
            this.personNameDisplay.TabIndex = 3;
            // 
            // personWeightDisplay
            // 
            this.personWeightDisplay.AutoSize = true;
            this.personWeightDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personWeightDisplay.Location = new System.Drawing.Point(397, 44);
            this.personWeightDisplay.Name = "personWeightDisplay";
            this.personWeightDisplay.Size = new System.Drawing.Size(0, 31);
            this.personWeightDisplay.TabIndex = 4;
            // 
            // personHeightDisplay
            // 
            this.personHeightDisplay.AutoSize = true;
            this.personHeightDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personHeightDisplay.Location = new System.Drawing.Point(397, 75);
            this.personHeightDisplay.Name = "personHeightDisplay";
            this.personHeightDisplay.Size = new System.Drawing.Size(0, 31);
            this.personHeightDisplay.TabIndex = 5;
            // 
            // personBmiDisplay
            // 
            this.personBmiDisplay.AutoSize = true;
            this.personBmiDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personBmiDisplay.Location = new System.Drawing.Point(397, 107);
            this.personBmiDisplay.Name = "personBmiDisplay";
            this.personBmiDisplay.Size = new System.Drawing.Size(0, 31);
            this.personBmiDisplay.TabIndex = 6;
            // 
            // personBmiCategoryDisplay
            // 
            this.personBmiCategoryDisplay.AutoSize = true;
            this.personBmiCategoryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personBmiCategoryDisplay.Location = new System.Drawing.Point(397, 138);
            this.personBmiCategoryDisplay.Name = "personBmiCategoryDisplay";
            this.personBmiCategoryDisplay.Size = new System.Drawing.Size(0, 31);
            this.personBmiCategoryDisplay.TabIndex = 7;
            this.personBmiCategoryDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(624, 289);
            this.Controls.Add(this.personBmiCategoryDisplay);
            this.Controls.Add(this.personBmiCategoryLabel);
            this.Controls.Add(this.personBmiDisplay);
            this.Controls.Add(this.personBmiLabel);
            this.Controls.Add(this.personHeightDisplay);
            this.Controls.Add(this.personHeightLabel);
            this.Controls.Add(this.personWeightDisplay);
            this.Controls.Add(this.personWeightLabel);
            this.Controls.Add(this.personNameDisplay);
            this.Controls.Add(this.personNameLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.peopleAddButton);
            this.Controls.Add(this.peopleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Kalkulátor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.Button peopleAddButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label personNameLabel;
        private System.Windows.Forms.Label personWeightLabel;
        private System.Windows.Forms.Label personHeightLabel;
        private System.Windows.Forms.Label personBmiLabel;
        private System.Windows.Forms.Label personBmiCategoryLabel;
        private System.Windows.Forms.Label personNameDisplay;
        private System.Windows.Forms.Label personWeightDisplay;
        private System.Windows.Forms.Label personHeightDisplay;
        private System.Windows.Forms.Label personBmiDisplay;
        private System.Windows.Forms.Label personBmiCategoryDisplay;
    }
}

