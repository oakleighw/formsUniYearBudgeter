namespace University_Budgeter_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.yearLoanLabel = new System.Windows.Forms.Label();
            this.monthlyWageLabel = new System.Windows.Forms.Label();
            this.rentLabel = new System.Windows.Forms.Label();
            this.subscriptionLabel = new System.Windows.Forms.Label();
            this.grossIncomeLabel = new System.Windows.Forms.Label();
            this.foodCostLabel = new System.Windows.Forms.Label();
            this.netIncomeLabel = new System.Windows.Forms.Label();
            this.yearLoanAmount = new System.Windows.Forms.TextBox();
            this.monthlyWageAmount = new System.Windows.Forms.TextBox();
            this.rentAmount = new System.Windows.Forms.TextBox();
            this.subscriptionAmount = new System.Windows.Forms.TextBox();
            this.foodCostAmount = new System.Windows.Forms.TextBox();
            this.grossResult = new System.Windows.Forms.Label();
            this.netResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yearLoanLabel
            // 
            this.yearLoanLabel.AutoSize = true;
            this.yearLoanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLoanLabel.Location = new System.Drawing.Point(29, 33);
            this.yearLoanLabel.Name = "yearLoanLabel";
            this.yearLoanLabel.Size = new System.Drawing.Size(135, 29);
            this.yearLoanLabel.TabIndex = 0;
            this.yearLoanLabel.Text = "Year Loan:";
            // 
            // monthlyWageLabel
            // 
            this.monthlyWageLabel.AutoSize = true;
            this.monthlyWageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyWageLabel.Location = new System.Drawing.Point(29, 98);
            this.monthlyWageLabel.Name = "monthlyWageLabel";
            this.monthlyWageLabel.Size = new System.Drawing.Size(182, 29);
            this.monthlyWageLabel.TabIndex = 1;
            this.monthlyWageLabel.Text = "Monthly Wage:";
            // 
            // rentLabel
            // 
            this.rentLabel.AutoSize = true;
            this.rentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentLabel.Location = new System.Drawing.Point(29, 162);
            this.rentLabel.Name = "rentLabel";
            this.rentLabel.Size = new System.Drawing.Size(102, 29);
            this.rentLabel.TabIndex = 2;
            this.rentLabel.Text = "Rent/m:";
            // 
            // subscriptionLabel
            // 
            this.subscriptionLabel.AutoSize = true;
            this.subscriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionLabel.Location = new System.Drawing.Point(29, 237);
            this.subscriptionLabel.Name = "subscriptionLabel";
            this.subscriptionLabel.Size = new System.Drawing.Size(202, 29);
            this.subscriptionLabel.TabIndex = 3;
            this.subscriptionLabel.Text = "Subscriptions/m:";
            // 
            // grossIncomeLabel
            // 
            this.grossIncomeLabel.AutoSize = true;
            this.grossIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossIncomeLabel.Location = new System.Drawing.Point(29, 311);
            this.grossIncomeLabel.Name = "grossIncomeLabel";
            this.grossIncomeLabel.Size = new System.Drawing.Size(199, 29);
            this.grossIncomeLabel.TabIndex = 4;
            this.grossIncomeLabel.Text = "Monthly Income:";
            // 
            // foodCostLabel
            // 
            this.foodCostLabel.AutoSize = true;
            this.foodCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodCostLabel.Location = new System.Drawing.Point(29, 386);
            this.foodCostLabel.Name = "foodCostLabel";
            this.foodCostLabel.Size = new System.Drawing.Size(165, 29);
            this.foodCostLabel.TabIndex = 5;
            this.foodCostLabel.Text = "Food Cost/m:";
            // 
            // netIncomeLabel
            // 
            this.netIncomeLabel.AutoSize = true;
            this.netIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netIncomeLabel.Location = new System.Drawing.Point(29, 446);
            this.netIncomeLabel.Name = "netIncomeLabel";
            this.netIncomeLabel.Size = new System.Drawing.Size(111, 29);
            this.netIncomeLabel.TabIndex = 6;
            this.netIncomeLabel.Text = "Savings:";
            // 
            // yearLoanAmount
            // 
            this.yearLoanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLoanAmount.Location = new System.Drawing.Point(236, 30);
            this.yearLoanAmount.MaxLength = 8;
            this.yearLoanAmount.Name = "yearLoanAmount";
            this.yearLoanAmount.Size = new System.Drawing.Size(148, 36);
            this.yearLoanAmount.TabIndex = 7;
            this.yearLoanAmount.TextChanged += new System.EventHandler(this.yearLoanAmount_TextChanged);
            // 
            // monthlyWageAmount
            // 
            this.monthlyWageAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyWageAmount.Location = new System.Drawing.Point(236, 95);
            this.monthlyWageAmount.MaxLength = 8;
            this.monthlyWageAmount.Name = "monthlyWageAmount";
            this.monthlyWageAmount.Size = new System.Drawing.Size(148, 36);
            this.monthlyWageAmount.TabIndex = 8;
            this.monthlyWageAmount.TextChanged += new System.EventHandler(this.monthlyWageAmount_TextChanged);
            // 
            // rentAmount
            // 
            this.rentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentAmount.Location = new System.Drawing.Point(236, 159);
            this.rentAmount.MaxLength = 8;
            this.rentAmount.Name = "rentAmount";
            this.rentAmount.Size = new System.Drawing.Size(148, 36);
            this.rentAmount.TabIndex = 9;
            this.rentAmount.TextChanged += new System.EventHandler(this.rentAmount_TextChanged);
            // 
            // subscriptionAmount
            // 
            this.subscriptionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionAmount.Location = new System.Drawing.Point(236, 234);
            this.subscriptionAmount.MaxLength = 8;
            this.subscriptionAmount.Name = "subscriptionAmount";
            this.subscriptionAmount.Size = new System.Drawing.Size(148, 36);
            this.subscriptionAmount.TabIndex = 10;
            this.subscriptionAmount.TextChanged += new System.EventHandler(this.subscriptionAmount_TextChanged);
            // 
            // foodCostAmount
            // 
            this.foodCostAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodCostAmount.Location = new System.Drawing.Point(236, 383);
            this.foodCostAmount.MaxLength = 8;
            this.foodCostAmount.Name = "foodCostAmount";
            this.foodCostAmount.Size = new System.Drawing.Size(148, 36);
            this.foodCostAmount.TabIndex = 11;
            this.foodCostAmount.TextChanged += new System.EventHandler(this.foodCostAmount_TextChanged);
            // 
            // grossResult
            // 
            this.grossResult.AutoSize = true;
            this.grossResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossResult.Location = new System.Drawing.Point(234, 311);
            this.grossResult.Name = "grossResult";
            this.grossResult.Size = new System.Drawing.Size(27, 29);
            this.grossResult.TabIndex = 12;
            this.grossResult.Text = "0";
            // 
            // netResult
            // 
            this.netResult.AutoSize = true;
            this.netResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netResult.Location = new System.Drawing.Point(234, 446);
            this.netResult.Name = "netResult";
            this.netResult.Size = new System.Drawing.Size(27, 29);
            this.netResult.TabIndex = 13;
            this.netResult.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(428, 518);
            this.Controls.Add(this.netResult);
            this.Controls.Add(this.grossResult);
            this.Controls.Add(this.foodCostAmount);
            this.Controls.Add(this.subscriptionAmount);
            this.Controls.Add(this.rentAmount);
            this.Controls.Add(this.monthlyWageAmount);
            this.Controls.Add(this.yearLoanAmount);
            this.Controls.Add(this.netIncomeLabel);
            this.Controls.Add(this.foodCostLabel);
            this.Controls.Add(this.grossIncomeLabel);
            this.Controls.Add(this.subscriptionLabel);
            this.Controls.Add(this.rentLabel);
            this.Controls.Add(this.monthlyWageLabel);
            this.Controls.Add(this.yearLoanLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Budgeter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yearLoanLabel;
        private System.Windows.Forms.Label monthlyWageLabel;
        private System.Windows.Forms.Label rentLabel;
        private System.Windows.Forms.Label subscriptionLabel;
        private System.Windows.Forms.Label grossIncomeLabel;
        private System.Windows.Forms.Label foodCostLabel;
        private System.Windows.Forms.Label netIncomeLabel;
        private System.Windows.Forms.TextBox yearLoanAmount;
        private System.Windows.Forms.TextBox monthlyWageAmount;
        private System.Windows.Forms.TextBox rentAmount;
        private System.Windows.Forms.TextBox subscriptionAmount;
        private System.Windows.Forms.TextBox foodCostAmount;
        private System.Windows.Forms.Label grossResult;
        private System.Windows.Forms.Label netResult;
    }
}

