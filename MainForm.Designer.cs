namespace NC800_Control
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            relay1button = new Button();
            relay2button = new Button();
            relay3button = new Button();
            relay4button = new Button();
            relay5button = new Button();
            relay6button = new Button();
            relay7button = new Button();
            relay8button = new Button();
            relayAllOnOffbutton = new Button();
            Exitbutton = new Button();
            configIpPortbutton = new Button();
            SuspendLayout();
            // 
            // relay1button
            // 
            resources.ApplyResources(relay1button, "relay1button");
            relay1button.BackColor = Color.DarkRed;
            relay1button.ForeColor = Color.Yellow;
            relay1button.Name = "relay1button";
            relay1button.UseVisualStyleBackColor = false;
            relay1button.Click += relay1button_Click;
            // 
            // relay2button
            // 
            resources.ApplyResources(relay2button, "relay2button");
            relay2button.BackColor = Color.DarkRed;
            relay2button.ForeColor = Color.Yellow;
            relay2button.Name = "relay2button";
            relay2button.UseVisualStyleBackColor = false;
            relay2button.Click += relay2button_Click;
            // 
            // relay3button
            // 
            resources.ApplyResources(relay3button, "relay3button");
            relay3button.BackColor = Color.DarkRed;
            relay3button.ForeColor = Color.Yellow;
            relay3button.Name = "relay3button";
            relay3button.UseVisualStyleBackColor = false;
            relay3button.Click += relay3button_Click;
            // 
            // relay4button
            // 
            resources.ApplyResources(relay4button, "relay4button");
            relay4button.BackColor = Color.DarkRed;
            relay4button.ForeColor = Color.Yellow;
            relay4button.Name = "relay4button";
            relay4button.UseVisualStyleBackColor = false;
            relay4button.Click += relay4button_Click;
            // 
            // relay5button
            // 
            resources.ApplyResources(relay5button, "relay5button");
            relay5button.BackColor = Color.DarkRed;
            relay5button.ForeColor = Color.Yellow;
            relay5button.Name = "relay5button";
            relay5button.UseVisualStyleBackColor = false;
            relay5button.Click += relay5button_Click;
            // 
            // relay6button
            // 
            resources.ApplyResources(relay6button, "relay6button");
            relay6button.BackColor = Color.DarkRed;
            relay6button.ForeColor = Color.Yellow;
            relay6button.Name = "relay6button";
            relay6button.UseVisualStyleBackColor = false;
            relay6button.Click += relay6button_Click;
            // 
            // relay7button
            // 
            resources.ApplyResources(relay7button, "relay7button");
            relay7button.BackColor = Color.DarkRed;
            relay7button.ForeColor = Color.Yellow;
            relay7button.Name = "relay7button";
            relay7button.UseVisualStyleBackColor = false;
            relay7button.Click += relay7button_Click;
            // 
            // relay8button
            // 
            resources.ApplyResources(relay8button, "relay8button");
            relay8button.BackColor = Color.DarkRed;
            relay8button.ForeColor = Color.Yellow;
            relay8button.Name = "relay8button";
            relay8button.UseVisualStyleBackColor = false;
            relay8button.Click += relay8button_Click;
            // 
            // relayAllOnOffbutton
            // 
            resources.ApplyResources(relayAllOnOffbutton, "relayAllOnOffbutton");
            relayAllOnOffbutton.BackColor = Color.DarkRed;
            relayAllOnOffbutton.ForeColor = Color.Yellow;
            relayAllOnOffbutton.Name = "relayAllOnOffbutton";
            relayAllOnOffbutton.UseVisualStyleBackColor = false;
            relayAllOnOffbutton.Click += relayAllOnOffbutton_Click;
            // 
            // Exitbutton
            // 
            resources.ApplyResources(Exitbutton, "Exitbutton");
            Exitbutton.BackColor = Color.Red;
            Exitbutton.ForeColor = Color.Yellow;
            Exitbutton.Name = "Exitbutton";
            Exitbutton.UseVisualStyleBackColor = false;
            Exitbutton.Click += ExitApp;
            // 
            // configIpPortbutton
            // 
            resources.ApplyResources(configIpPortbutton, "configIpPortbutton");
            configIpPortbutton.BackColor = Color.DarkRed;
            configIpPortbutton.ForeColor = Color.Yellow;
            configIpPortbutton.Name = "configIpPortbutton";
            configIpPortbutton.UseVisualStyleBackColor = false;
            configIpPortbutton.Click += configIpPortbutton_Click;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ControlBox = false;
            Controls.Add(configIpPortbutton);
            Controls.Add(Exitbutton);
            Controls.Add(relayAllOnOffbutton);
            Controls.Add(relay8button);
            Controls.Add(relay7button);
            Controls.Add(relay6button);
            Controls.Add(relay5button);
            Controls.Add(relay4button);
            Controls.Add(relay3button);
            Controls.Add(relay2button);
            Controls.Add(relay1button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button relay1button;
        private Button relay2button;
        private Button relay3button;
        private Button relay4button;
        private Button relay5button;
        private Button relay6button;
        private Button relay7button;
        private Button relay8button;
        private Button relayAllOnOffbutton;
        private Button Exitbutton;
        private Button configIpPortbutton;
    }
}
