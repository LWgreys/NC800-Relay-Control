namespace NC800_Control
{
    partial class FormChangeIPport
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
            label1 = new Label();
            label2 = new Label();
            textBoxIPaddress = new TextBox();
            textBoxPortNumber = new TextBox();
            buttonChangeStore = new Button();
            buttonCancelChanges = new Button();
            buttonSetDefaults = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 20);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "IP Address : ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 48);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Port Number : ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxIPaddress
            // 
            textBoxIPaddress.Location = new Point(111, 17);
            textBoxIPaddress.Name = "textBoxIPaddress";
            textBoxIPaddress.Size = new Size(100, 23);
            textBoxIPaddress.TabIndex = 2;
            textBoxIPaddress.Text = "234.345.456.567";
            // 
            // textBoxPortNumber
            // 
            textBoxPortNumber.Location = new Point(111, 46);
            textBoxPortNumber.Name = "textBoxPortNumber";
            textBoxPortNumber.Size = new Size(100, 23);
            textBoxPortNumber.TabIndex = 3;
            textBoxPortNumber.Text = "30000";
            // 
            // buttonChangeStore
            // 
            buttonChangeStore.Font = new Font("Segoe UI", 9.75F);
            buttonChangeStore.Location = new Point(61, 87);
            buttonChangeStore.Name = "buttonChangeStore";
            buttonChangeStore.Size = new Size(122, 32);
            buttonChangeStore.TabIndex = 4;
            buttonChangeStore.Text = "Change and Store";
            buttonChangeStore.UseVisualStyleBackColor = true;
            buttonChangeStore.Click += buttonChangeStore_Click;
            // 
            // buttonCancelChanges
            // 
            buttonCancelChanges.Font = new Font("Segoe UI", 9.75F);
            buttonCancelChanges.Location = new Point(61, 125);
            buttonCancelChanges.Name = "buttonCancelChanges";
            buttonCancelChanges.Size = new Size(122, 32);
            buttonCancelChanges.TabIndex = 5;
            buttonCancelChanges.Text = "Cancel Changes";
            buttonCancelChanges.UseVisualStyleBackColor = true;
            buttonCancelChanges.Click += buttonCancelChanges_Click;
            // 
            // buttonSetDefaults
            // 
            buttonSetDefaults.Font = new Font("Segoe UI", 9.75F);
            buttonSetDefaults.Location = new Point(61, 163);
            buttonSetDefaults.Name = "buttonSetDefaults";
            buttonSetDefaults.Size = new Size(122, 32);
            buttonSetDefaults.TabIndex = 6;
            buttonSetDefaults.Text = "Set Defaul IP/Port";
            buttonSetDefaults.UseVisualStyleBackColor = true;
            buttonSetDefaults.Click += buttonSetDefaults_Click;
            // 
            // FormChangeIPport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(244, 211);
            ControlBox = false;
            Controls.Add(buttonSetDefaults);
            Controls.Add(buttonCancelChanges);
            Controls.Add(buttonChangeStore);
            Controls.Add(textBoxPortNumber);
            Controls.Add(textBoxIPaddress);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormChangeIPport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChangeIPportForm";
            Load += FormChangeIPport_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxIPaddress;
        private TextBox textBoxPortNumber;
        private Button buttonChangeStore;
        private Button buttonCancelChanges;
        private Button buttonSetDefaults;
    }
}